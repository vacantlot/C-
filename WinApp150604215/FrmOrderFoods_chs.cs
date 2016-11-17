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
        PictureBox picturebox = new PictureBox();
        public string itemName;
        public FrmOrderFoods_chs()
        {
            InitializeComponent();
        }

        private void FrmOrderFoods_chs_Load(object sender, EventArgs e)
        {
            string[] str = { "麻婆豆腐", "回锅肉", "酥肉", "锅盔", "毛血旺", "夫妻肺片", "干锅", "土豆烧牛肉" , "水煮肉片" };
            for (int i = 0; i < str.Length; i++)
            {
                lb_Meun.Items.Add(str[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_Meun.SelectedItems.Count; i++)
            {
                if (!lb_OrderedMeun.Items.Contains(lb_Meun.SelectedItems[i]))
                {
                    lb_OrderedMeun.Items.Add(lb_Meun.SelectedItems[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_OrderedMeun.Items.Clear();
            lb_OrderedMeun.Items.AddRange(lb_Meun.Items);
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            while (!(lb_OrderedMeun.SelectedItems.Count == 0))
            {
                lb_OrderedMeun.Items.Remove(lb_OrderedMeun.SelectedItem);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb_OrderedMeun.Items.Clear();
        }

        private void lb_Meun_MouseMove(object sender, MouseEventArgs e)
        {
           int AIndex = ((ListBox)sender).IndexFromPoint(e.Location);
            if (AIndex < 0) return;
            itemName = ((ListBox)sender).Items[AIndex].ToString();
            FrmShowPicture frmpicture = new FrmShowPicture(this);
            
            frmpicture.Show();                                               
        }
        
    }
}
