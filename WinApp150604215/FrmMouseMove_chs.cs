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
    public partial class FrmMouseMove_chs : Form
    {
        private int location;
        public FrmMouseMove_chs()
        {
            InitializeComponent();
        }

        private void mouseMove_chs_Load(object sender, EventArgs e)
        {
            location = 0;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void FrmMouseMove_chs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (e.Clicks == 2))
            {
                if (location == 1)
                {
                    location = 3;
                    label3.Location = label1.Location;
                }
                else
                if (location == 2)
                {
                    location = 4;
                    label3.Location = label2.Location;
                }
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (location == 3)
            {
                label1.Visible = false;
                label3.Visible = true;
            }
            else
            {
                location = 2;
                label1.Visible = false;
                label2.Visible = true;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            if (location == 4)
            {
                label2.Visible = false;
                label3.Visible = true;
            }
            else
            {
                location = 1;
                label1.Visible = true;
                label2.Visible = false;
            }
        }


    }
}
