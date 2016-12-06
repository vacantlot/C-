using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmUpdate_chs : Form
    {
  
        public FrmUpdate_chs()
        {
            InitializeComponent();
        }

        private void FrmUpdate_chs_Load(object sender, EventArgs e)
        {
            btn_next_Click(sender, e);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                //DataBase db = new DataBase();
                //db.Open();
                // fillInfo(db.ReadOneUser().Split('\t'));
                string conn = ConfigurationManager.ConnectionStrings["constr"].ConnectionString
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fillInfo(string[] userInfo)
        {
            txt_name.Text = userInfo[0];
            txt_xuehao.Text = userInfo[1];
            txt_major.Text = userInfo[2];
            if (userInfo[4].ToString() == "True")
            {
                rdB_boy.Checked = true;
            }
            else
            {
                rdB_girl.Checked = true;
            }
            this.pictureBox1.Image = Image.FromFile(@"..\..\Resources\images\" + userInfo[5].ToString() + ".bmp");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
