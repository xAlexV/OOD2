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
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        public FormNetwork()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        bool drag = false;
        bool clicked = false;
        Point mouseDown;
        int flag = 0;


        private void AddPictureBox(string imagePath)
        {
            if (flag !=0)
            {
                var pb = new PictureBox();
                pb.Name = "picturebox" + pictureBoxes.Count;
                pb.Location = mouseDown;
                pb.Size = new Size(40, 40);
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
            drag = true;
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
           
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            mouseDown = new Point(x, y);
            switch(flag)
            { 
                case 1:
                AddPictureBox(@"../../../images/pump.png");
                break;
                case 2:
                AddPictureBox(@"../../../images/sink.png");
                break;
                case 3:
                AddPictureBox(@"../../../images/splitter.png");
                break;
                case 4:
                AddPictureBox(@"../../../images/merger.png");
                break;
        }
        }

        private void buttonSink_Click(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void buttonSplitter_Click(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void buttonMerger_Click(object sender, EventArgs e)
        {
            flag = 4;
        }
    }
}
