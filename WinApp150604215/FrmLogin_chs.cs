using System;
using System.Windows.Forms;

namespace WinApp150604215
{
    public partial class FrmLogin_chs : Form
    {
        private FrmMain_chs frmMain;
        public FrmLogin_chs()
        {
            InitializeComponent();
        }
        public FrmLogin_chs(FrmMain_chs frmMian)
        {
            InitializeComponent();
            frmMain = frmMian;             //将传过来的FormMain全部赋值给frmMain，这样就可以在这FrmLogin中调用FormMain了
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (userNameTextBox.Text == "" && passWordTextBox.Text == "")
            {
                MessageBox.Show("请输入账号！");
                userNameTextBox.Focus();
            }
            if (userNameTextBox.Text != "f" && passWordTextBox.Text != "")
            {
                MessageBox.Show("账号错误！\n 请重新输入…");
                userNameTextBox.Clear();
                userNameTextBox.Focus();
            }
            if (userNameTextBox.Text == "f" && passWordTextBox.Text == "")
            {
                MessageBox.Show("请输入密码！");
                passWordTextBox.Focus();
            }
            
           else  if (passWordTextBox.Text != "f" && userNameTextBox.Text == "f")
            {
                MessageBox.Show("密码错误！");
                passWordTextBox.SelectAll();
                passWordTextBox.Focus();
            }

            if (userNameTextBox.Text == "f" && passWordTextBox.Text == "f")
            {
                MessageBox.Show("登录成功！");
                this.Close();
                frmMain.showShiYanOrder();             
            }


        }

       
    }
}
