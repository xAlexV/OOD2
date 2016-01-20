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
    public partial class TrackBar : Form
    {
        public int trackflow;
        public TrackBar()
        {
             
            InitializeComponent();
        }

        public int MyFlow
        {
            get { return trackflow; }
        }

        private void btconfirm_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            trackflow = trackBar1.Value;
        }

        


    }
}
