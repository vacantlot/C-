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
    public partial class FrmOrderFoods_chs : Form
    {
        public FrmOrderFoods_chs()
        {
            InitializeComponent();
        }

        private void FrmOrderFoods_chs_Load(object sender, EventArgs e)
        {
            string[] str = { "麻婆豆腐", "回锅肉", "酥肉", "锅盔", "鱼香肉丝", "夫妻肺片", "干锅", "土豆烧牛肉" , "麻婆豆腐", "回锅肉", "酥肉", "锅盔", "鱼香肉丝", "夫妻肺片", "干锅", "土豆烧牛肉" };


            for (int i = 0; i < str.Length; i++)
            {
                lb_Meun.Items.Add(str[i]);
            }
           
                
            
        }
    }
}
