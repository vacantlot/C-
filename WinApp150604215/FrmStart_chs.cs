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
    
    public partial class FrmStart_chs : Form
    {
        public FrmStart_chs()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Enabled = true;
            timer1.Interval = 5000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {     
            FrmMain_chs frmMain = new FrmMain_chs();
            Hide();
            frmMain.Show();
            timer1.Enabled = false;
        }
    }
}
