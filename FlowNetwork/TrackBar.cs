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

        private void btconfirm_Click(object sender, EventArgs e)
        {
            trackflow = trackBar1.Value;
            this.Close();

           
        }


    }
}
