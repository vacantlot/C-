using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp150604215
{  
    public partial class FrmIntegrated_chs : Form
    {
        public FrmIntegrated_chs()
        {
            InitializeComponent();
        }

        private void FrmIntegrated_chs_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.TextAlign = ContentAlignment.BottomCenter;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前时间: " + DateTime.Now.ToString();
        }
    }
}
