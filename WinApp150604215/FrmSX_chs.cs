using System;
using System.Collections;
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
    public partial class FrmSX_chs : Form
    {
        char[] arr_chs = new char[] { '猴', '鸡', '狗', '猪', '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊' };
        ArrayList arrlist = new ArrayList();
        public FrmSX_chs()
        {
            InitializeComponent();
        }

        private void FrmSX_chs_Load(object sender, EventArgs e)
        {
            //int temp = 1936;
            for (int i = 1936; i <= 2046; i++)
            {
                arrlist.Add(i.ToString());    
            }
            cmbYear.DataSource = arrlist;
            cmbYear.SelectedIndex = 80;
            txt1.ReadOnly = true;        
        }      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            char SX = arr_chs[(cmbYear.SelectedIndex+4) % 12];
            if (rdb1.Text == SX.ToString()) rdb1.Checked = true;
            if (rdb2.Text == SX.ToString()) rdb2.Checked = true;
            if (rdb3.Text == SX.ToString()) rdb3.Checked = true;
            if (rdb4.Text == SX.ToString()) rdb4.Checked = true;
            if (rdb5.Text == SX.ToString()) rdb5.Checked = true;
            if (rdb6.Text == SX.ToString()) rdb6.Checked = true;
            if (rdb7.Text == SX.ToString()) rdb7.Checked = true;
            if (rdb8.Text == SX.ToString()) rdb8.Checked = true;
            if (rdb9.Text == SX.ToString()) rdb9.Checked = true;
            if (rdb10.Text == SX.ToString()) rdb10.Checked = true;
            if (rdb11.Text == SX.ToString()) rdb11.Checked = true;
            if (rdb12.Text == SX.ToString()) rdb12.Checked = true;
        }
       

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt1.Refresh();
        }

        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            foreach (CheckBox CKB in this.groupBox2.Controls)
            {
                if (CKB.Checked)
                {
                    txt1.Text = CKB.Text + "、" +txt1.Text;
                }
            }
            if (txt1.Text == "")
            {
                txt1.Text = "一个也不喜欢？";
            }
            else
            {
                this.txt1.Text = txt1.Text.Substring(0, txt1.Text.Length - 1); // 处理“、”  ——当选好又清空时，再选时会多出个“、” 
            }
        }
    }
}
