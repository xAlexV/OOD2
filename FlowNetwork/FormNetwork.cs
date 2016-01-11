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
        private Network nw;
        public FormNetwork()
        {
            InitializeComponent();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            nw.Reset();
            this.panel2.Controls.Clear();
        }
    }
}
