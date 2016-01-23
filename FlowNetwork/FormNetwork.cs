using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowNetwork
{
    public partial class FormNetwork : Form
    {
        Component temp;
        private Network nw = new Network();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<Point> PointList = new List<Point>();
        int x = 0;
        int y = 0;
        int flag = 0;
        bool drag = false;
        Point mouseDown, mouseDownPictureBox;
        ContextMenuStrip selectedSplitter = new ContextMenuStrip();
        ButtonEnumeration aboutPump = ButtonEnumeration.AboutPump;
        ButtonEnumeration aboutSink = ButtonEnumeration.AboutSink;
        ButtonEnumeration aboutSplitter = ButtonEnumeration.AboutSplitter;
        ButtonEnumeration aboutMerger = ButtonEnumeration.AboutMerger;

        public FormNetwork()
        {
            InitializeComponent();
            this.tbcapacity.Enabled = false;
            this.tbflow.Enabled = false;
            selectedSplitter.Items.Add("Normal Splitter");
            selectedSplitter.Items.Add("Adjustable Splitter");     
        }

        private void AddPictureBox(string imagePath)
        {
            if (flag!= 0)
            {
                var pb = new PictureBox();
                pb.Name = "picturebox" + pictureBoxes.Count;
                pb.Location = mouseDown;
                pb.Size = new Size(60, 60);
                pb.BorderStyle = BorderStyle.None;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                panel2.Controls.Add(pb);



                pb.Image = Image.FromFile(imagePath);
                pb.Refresh();
                pb.MouseDown += new MouseEventHandler(picMouseDown);
                pb.MouseMove += new MouseEventHandler(picMouseMove);
                pb.MouseUp += new MouseEventHandler(picMouseUp);

                pictureBoxes.Add(pb);
                flag = 0;
                Invalidate();
            }
        
        }
      private void picMouseDown(object sender, MouseEventArgs e)
        {
            // Get original position of cursor on mousedown
            x = e.X;
            y = e.Y;
            PictureBox pb = (PictureBox)sender;
            if(flag == 5)
            {
                if (PointList.Count() == 0)
                {
                    foreach (Item i in nw.GiveList())
                    {
                        if (i is Component)
                        {
                            int x1 = ((Component)i).GivePoint().X - pb.Location.X;
                            int x2 = ((Component)i).GivePoint().Y - pb.Location.Y;
                            if (Math.Abs(((Component)i).GivePoint().X - pb.Location.X) <= 20 && Math.Abs(((Component)i).GivePoint().Y - pb.Location.Y) <= 20)
                            {
                                if (i is Pump || i is Merger || i is Spliter || i is AdjustableSpliter)
                                {
                                    if (nw.FindConnection(i.ID()))
                                    {
                                        mouseDownPictureBox = new Point(pb.Location.X + 40, pb.Location.Y + 20);
                                        PointList.Add(mouseDownPictureBox);
                                        temp = (Component)i;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Component already has pipe connected");
                                        flag = 0;
                                        PointList = new List<Point>();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pipe can't start from Sink");
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (Component i in nw.GiveList())
                    {
                        if (Math.Abs(i.GivePoint().X - pb.Location.X) <= 20 && Math.Abs(i.GivePoint().Y - pb.Location.Y) <= 20)
                        {
                            if (i is Sink || i is Merger || i is Spliter || i is AdjustableSpliter)
                            {
                                if (nw.FindEndConnection(i.ID()))
                                {
                                    mouseDownPictureBox = new Point(pb.Location.X, pb.Location.Y + 20);
                                    Pen pen = new Pen(Color.Black, 3);
                                    PointList.Add(mouseDownPictureBox);
                                    try
                                    {
                                        nw.SavePipe(Convert.ToInt32(this.tbcapacity.Text), 1, temp.ID(), i.ID(), PointList);

                                        Graphics g = panel2.CreateGraphics();

                                        g.DrawLines(pen, PointList.ToArray());
                                        Invalidate();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("You need to feel in Capacity.");
                                        flag = 0;
                                        PointList = new List<Point>();
                                    }

                                    flag = 0;
                                    PointList = new List<Point>();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Component already has pipe connected");
                                    flag = 0;
                                    PointList = new List<Point>();
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("sdaa");
                                break;
                            }
                        }
                    }
                }
            }
            else
            { 
                drag = true;
            }
        }

        private void picMouseMove(object sender, MouseEventArgs e)
        {
          if (drag)
          {
              PictureBox pb = (PictureBox)sender;
              // Get new position of picture
              pb.Top += e.Y - y;
              pb.Left += e.X - x;
              pb.BringToFront();
          }
        }

        private void picMouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddPictureBox(@"../../../images/pump.png");
            flag = 1;
            this.tbcapacity.Enabled = true;
            this.tbflow.Enabled = true;
            this.lblSelectedComponent.Text = "Pump";
      
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            mouseDown = new Point(x - 20, y - 20);
            switch (flag)
            {
                case 1:
                    AddPictureBox(@"../../../images/pump.png");
                    this.lblSelectedComponent.Text = "";
                    nw.AddItem(new Pump(nw.GetNewId(), x - 30, y - 30));
                    this.tbcapacity.Enabled = false;
                    this.tbflow.Enabled = false;
                    break;
                case 2:
                    AddPictureBox(@"../../../images/sink.png");
                    this.lblSelectedComponent.Text = "";
                    nw.AddItem(new Sink(nw.GetNewId(), x - 30, y - 30));
                    break;
                case 3:
                    AddPictureBox(@"../../../images/splitter.png");
                    this.lblSelectedComponent.Text = "";
                    nw.AddItem(new Spliter(nw.GetNewId(), x - 30, y - 30));
                    break;
                case 4:
                    AddPictureBox(@"../../../images/merger.png");
                    this.lblSelectedComponent.Text = "";
                    nw.AddItem(new Merger(nw.GetNewId(), x - 30, y - 30));
                    break;
                case 5:
                    if (PointList.Count() > 0)
                    {
                        PointList.Add(new Point(x, y));
                    }
                    else
                    {
                        MessageBox.Show("Pipe should start from Component");
                    }
                    break;
            }
        }

        private void buttonSink_Click(object sender, EventArgs e)
        {
            flag = 2;
            this.lblSelectedComponent.Text = "Sink";
            
        }

        private void buttonSplitter_Click(object sender, EventArgs e)
        {
          //  flag = 3;
            //this.lblSelectedComponent.Text = "Splitter";

            selectedSplitter.Show(buttonSplitter, new Point(0, buttonSplitter.Height));
            selectedSplitter.ItemClicked += new ToolStripItemClickedEventHandler(selectedSplitter_ItemClicked);
        }

        private void selectedSplitter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;

            if (item.Text == "Normal Splitter")
            {
                flag = 3;
                this.lblSelectedComponent.Text = e.ClickedItem.Text;
            }
            else if (item.Text == "Adjustable Splitter")
            {
                flag = 3;
                this.lblSelectedComponent.Text = "Adjustable Splitter";
                TrackBar trackform = new TrackBar();
                trackform.ShowDialog();
                int myflow = trackform.MyFlow;
                label1.Text = myflow.ToString();
            }
        }
        private void buttonMerger_Click(object sender, EventArgs e)
        {
            flag = 4;
            this.lblSelectedComponent.Text = "Merger";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            try
            {
                nw.Reset();
                this.panel2.Controls.Clear();
            }
            catch (NullReferenceException) { MessageBox.Show("The drawing board is already empty"); }
        }

        private void FormNetwork_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_pipe_Click(object sender, EventArgs e)
        {
            PointList = new List<Point>();
            flag = 5;
            this.tbcapacity.Enabled = true;
        }
        private void DrawPipe()
        {

        }

        
    }

}
