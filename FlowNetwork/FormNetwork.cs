using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowNetwork
{
    public partial class FormNetwork : Form
    {
        int adjastable;
        Component temp;
        Network nw;
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<Point> PointList = new List<Point>();
        int x = 0;
        int y = 0;
        int flag = 0;
        bool drag = false;
        string path = "";
        Point mouseDown, mouseDownPictureBox;
        ContextMenuStrip selectedSplitter = new ContextMenuStrip();


        public FormNetwork()
        {
            InitializeComponent();
            nw = new Network();
            tbcapacity.Enabled = false;
            tbflow.Enabled = false;
            selectedSplitter.Items.Add("Normal Splitter");
            selectedSplitter.Items.Add("Adjustable Splitter");
        }

        private void AddPictureBox(string imagePath)
        {
            if (flag != 0)
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
            if (flag == 7)
            {
                pb.Visible = false;
                int id1 = -1;
                int id2 = -1;
                foreach (Item i in nw.GetItemList())
                {
                    if (i is Component)
                    {
                        Component c = (Component)i;
                        if (c.GetPoint().X + 10 == pb.Location.X && c.GetPoint().Y + 10 == pb.Location.Y)
                        {
                            foreach (Pipe p in nw.GetListPipes())
                            {
                                Point x = c.GetPoint();
                                x.X += 40;
                                x.Y += 20;
                                if (x == p.pipePoints[0] || x == p.pipePoints[1])
                                {
                                    id2 = p.ID();
                                }
                            }
                        }
                        id1 = c.ID();
                    }
                }
                if (nw.Remove(id2))
                {
                    DrawAllPipes();
                }
                if (nw.Remove(id1))
                {
                    pictureBoxes.Remove(pb);
                    pb.Dispose();
                }
                flag = 0;
            }

            if (flag == 5)
            {
                if (PointList.Count() == 0)
                {
                    foreach (Item i in nw.GetItemList())
                    {
                        if (i is Component)
                        {
                            if (Math.Abs(((Component)i).GetPoint().X - pb.Location.X) <= 20 && Math.Abs(((Component)i).GetPoint().Y - pb.Location.Y) <= 20)
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
                    foreach (Item i in nw.GetItemList())
                    {
                        if ((i is Pipe) == false && Math.Abs(((Component)i).GetPoint().X - pb.Location.X) <= 20 && Math.Abs(((Component)i).GetPoint().Y - pb.Location.Y) <= 20)
                        {
                            if (i is Sink || i is Merger || i is Spliter || i is AdjustableSpliter)
                            {
                                if (nw.FindEndConnection(i.ID()))
                                {
                                    mouseDownPictureBox = new Point(pb.Location.X, pb.Location.Y + 20);
                                    PointList.Add(mouseDownPictureBox);
                                    try
                                    {
                                        ((Component)nw.GetItemFromId(temp.ID())).AddNextComponent(i.ID());
                                        int curFlow = nw.UpdateFlow(temp, i.ID(), temp.currFlow);
                                        if (i is Sink || i is Merger)
                                        {
                                            nw.SavePipe(Convert.ToInt32(tbcapacity.Text), curFlow, temp.ID(), i.ID(), PointList);
                                            tbcapacity.Text = "";
                                            tbcapacity.Enabled = false;

                                        }
                                        else
                                        {
                                            if (i is AdjustableSpliter)
                                            {
                                                nw.SavePipe(Convert.ToInt32(tbcapacity.Text), curFlow, temp.ID(), i.ID(), PointList);
                                                tbcapacity.Text = "";
                                                tbcapacity.Enabled = false;
                                            }
                                            else
                                            {
                                                nw.SavePipe(Convert.ToInt32(tbcapacity.Text), curFlow, temp.ID(), i.ID(), PointList);
                                                tbcapacity.Text = "";
                                                tbcapacity.Enabled = false;
                                            }
                                        }
                                        DrawAllPipes();
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
                        }
                    }
                }
            }
            else {
                drag = true;
            }

        }

        private void picMouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                PictureBox pb = (PictureBox)sender;
                Item temp = null;
                foreach (Item i in nw.GetItemList())
                {
                    if (i is Component)
                    {
                        if (Math.Abs(((Component)i).GetPoint().X - pb.Location.X) <= 20 && Math.Abs(((Component)i).GetPoint().Y - pb.Location.Y) <= 20)
                        {
                            temp = i;
                        }
                    }
                }
                ((Component)temp).GetNewCoordinates(pb.Location.X, pb.Location.Y);
                DrawAllPipes();
                // Get new position of picture
                pb.Top += e.Y - y;
                pb.Left += e.X - x;
                pb.BringToFront();

                ((Component)temp).GetNewCoordinates(pb.Location.X, pb.Location.Y);
            }

        }

        private void picMouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel2MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddPictureBox(@"../../../images/pump.png");
            flag = 1;
            tbcapacity.Enabled = true;
            tbflow.Enabled = true;
            lblSelectedComponent.Text = "Pump";

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = false;
            x = e.X;
            y = e.Y;
            mouseDown = new Point(x - 20, y - 20);
            switch (flag)
            {
                case 1:
                    try
                    {
                        if (Convert.ToInt32(tbcapacity.Text) < Convert.ToInt32(tbflow.Text))
                        {
                            MessageBox.Show("Capacity should be bigger then current flow");
                        }
                        else
                        {
                            AddPictureBox(@"../../../images/pump.png");
                            lblSelectedComponent.Text = "";
                            nw.AddItem(new Pump(nw.GetNewId(), x - 30, y - 30, Convert.ToInt32(tbcapacity.Text), Convert.ToInt32(tbflow.Text)));
                            tbcapacity.Text = "";
                            tbflow.Text = "";
                            tbcapacity.Enabled = false;
                            tbflow.Enabled = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Your input was wrong");
                    }
                    break;
                case 2:
                    AddPictureBox(@"../../../images/sink.png");
                    lblSelectedComponent.Text = "";
                    nw.AddItem(new Sink(nw.GetNewId(), x - 30, y - 30, 0));
                    break;
                case 3:
                    AddPictureBox(@"../../../images/splitter.png");
                    lblSelectedComponent.Text = "";
                    nw.AddItem(new Spliter(nw.GetNewId(), x - 30, y - 30, 0));
                    break;
                case 4:
                    AddPictureBox(@"../../../images/merger.png");
                    lblSelectedComponent.Text = "";
                    nw.AddItem(new Merger(nw.GetNewId(), x - 30, y - 30, 0));
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
                case 6:
                    AddPictureBox(@"../../../images/splitter.png");
                    lblSelectedComponent.Text = "";
                    nw.AddItem(new AdjustableSpliter(nw.GetNewId(), x - 30, y - 30, 0, adjastable));
                    adjastable = 1 / 2;
                    break;
                case 7:
                    Point clicked = new Point(x, y);
                    {
                        //PictureBox rpb1 = null, rpb2 = null;
                        //Point temp2;
                        foreach (Pipe p in nw.GetListPipes())
                        {
                            if (RemoveLine(p.pipePoints[0], p.pipePoints[1], clicked, 3))
                            {
                                nw.Remove(p.ID());
                                // nw.Remove(p.GetFirstId());
                                // nw.Remove(p.GetSecondId());
                                /* foreach (PictureBox x in pictureBoxes)
                                 {
                                     temp2 = x.Location;
                                     temp2.X += 30;
                                     temp2.Y += 10;
                                     if (p.pipePoints[0] == temp2)
                                     {
                                         x.Visible = false;
                                         rpb1 = x;
                                     }
                                     if (p.pipePoints[1] == temp2)
                                     {
                                         x.Visible = false;
                                         rpb2 = x;
                                     }
                                 }
                                 pictureBoxes.Remove(rpb1);
                                 pictureBoxes.Remove(rpb2);
                             }*/
                            }
                        }
                    }
                    DrawAllPipes();
                    flag = 0;
                    break;
            }
        }


        private bool RemoveLine(Point p1, Point p2, Point p, int width)
        {
            bool isOnLine = false;
            using (GraphicsPath path = new GraphicsPath())
            {
                using (Pen pen = new Pen(Brushes.Black, width))
                {
                    path.AddLine(p1, p2);
                    isOnLine = path.IsOutlineVisible(p, pen);
                }
            }
            return isOnLine;
        }

        private void buttonSink_Click(object sender, EventArgs e)
        {
            flag = 2;
            lblSelectedComponent.Text = "Sink";

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
                lblSelectedComponent.Text = e.ClickedItem.Text;
            }
            else if (item.Text == "Adjustable Splitter")
            {
                flag = 6;
                lblSelectedComponent.Text = "Adjustable Splitter";
                TrackBar trackform = new TrackBar();
                trackform.ShowDialog();
                int myflow = trackform.MyFlow;
                adjastable = myflow;




            }
        }
        private void buttonMerger_Click(object sender, EventArgs e)
        {
            flag = 4;
            lblSelectedComponent.Text = "Merger";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Do you want to save your network before loading?", "Save?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    btsaveas.PerformClick();
                    nw.Reset();
                    panel2.Controls.Clear();
                    Graphics g = panel2.CreateGraphics();
                    g.Clear(Color.Silver);
                }
                else if (dialog == DialogResult.No)
                {
                    nw.Reset();
                    panel2.Controls.Clear();
                    Graphics g = panel2.CreateGraphics();
                    g.Clear(Color.Silver);
                }
                btsave.Enabled = false;
            }
            else
            {
                MessageBox.Show("The panel is already empty");
            }
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
            tbcapacity.Enabled = true;
        }
        private void DrawAllPipes()
        {
            Graphics g = panel2.CreateGraphics();
            g.Clear(Color.Silver);

            List<Pipe> pipeList = nw.GetListPipes();
            foreach (Pipe p in pipeList)
            {
                Component firstItem = (Component)nw.GetItemFromId(p.GetFirstId());
                Component secondItem = (Component)nw.GetItemFromId(p.GetSecondId());

                p.pipePoints[0] = new Point(Convert.ToInt32(firstItem.x) + 40, Convert.ToInt32(firstItem.y) + 20);
                p.pipePoints[p.pipePoints.Count() - 1] = new Point(Convert.ToInt32(secondItem.x) + 40, Convert.ToInt32(secondItem.y) + 20);

                Pen pen;
                if (firstItem.GiveCurrFlow() > p.GetMaxFlow())
                {
                    pen = new Pen(Color.Red, 3);
                }
                else
                {
                    pen = new Pen(Color.Black, 3);
                }

                g.DrawLines(pen, p.pipePoints.ToArray());
                Font Myfont = new Font("Times New Roman", 15);
                g.DrawString(Convert.ToString("Flow is " + p.GetCurrFlow()), Myfont, Brushes.Black, Convert.ToInt32((firstItem.x + secondItem.x) / 2), Convert.ToInt32((firstItem.y + secondItem.y) / 2));
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Do you want to save your network before loading?", "Save?", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    btsaveas.PerformClick();
                    OpenFileDialog loadDialog = new OpenFileDialog();
                    if (loadDialog.ShowDialog() == DialogResult.OK)
                    {
                        loadDialog.Title = "Load Network from a file";
                        path = loadDialog.FileName;
                        nw = Network.Load(loadDialog.FileName);
                        btsave.Enabled = true;


                    }
                }
                else if (dialog == DialogResult.No)
                {
                    OpenFileDialog loadDialog = new OpenFileDialog();
                    if (loadDialog.ShowDialog() == DialogResult.OK)
                    {
                        loadDialog.Title = "Load Network from a file";
                        path = loadDialog.FileName;
                        nw = Network.Load(loadDialog.FileName);
                        btsave.Enabled = true;

                    }
                }

            }
            else
            {
                OpenFileDialog loadDialog = new OpenFileDialog();
                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    loadDialog.Title = "Load Network from a file";
                    path = loadDialog.FileName;
                    nw = Network.Load(loadDialog.FileName);
                    btsave.Enabled = true;

                }
            }

        }

        private void btsaveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save Network";
            dialog.DefaultExt = ".XML";
            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileName != null)
            {
                Network.Save(nw, dialog.FileName);
                path = dialog.FileName;
                btsave.Enabled = true;

            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            Network.Save(nw, path);
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            flag = 7;
        }


    }

}
