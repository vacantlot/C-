﻿using System;
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
    
    public partial class FrmDoubleColorBall_chs : Form
    {
        private Timer timer1;
        int[] Num = new int[7]; 
        public FrmDoubleColorBall_chs()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoubleColorBall(Num);
            RedBall1.Text = Num[0].ToString("00");                
            RedBall2.Text = Num[1].ToString("00");
            RedBall3.Text = Num[2].ToString("00");
            RedBall4.Text = Num[3].ToString("00");
            RedBall5.Text = Num[4].ToString("00");
            RedBall6.Text = Num[5].ToString("00");
            BlueBall1.Text = Num[6].ToString("00");
        }

        private void startORstopbutton_Click(object sender, EventArgs e)
        {
            
            if (startORstopbutton.Text == "开始")
            {
                startORstopbutton.Text = "停止";
                timer1.Enabled = true;
            }
            else if (startORstopbutton.Text == "停止")
            {
                startORstopbutton.Text = "开始";
                timer1.Enabled = false;
            }
        }
     
        private void DoubleColorBall(int[] _Num)
        {           
            Random random = new Random();
            int i = 0;
            while (true)
            {
                int temp = random.Next(1, 34);
                _Num[i] = temp;
                for (int j = 0; j < i; j++)
                {
                    if (_Num[j] == temp)
                    {
                        i -= 1;
                        break;
                    }
                }
                i++;
                if (i == 7) break;
            }
            _Num[6] = random.Next(1, 17);
        }
       
        private void FrmDoubleColorBall_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;        
        }
    }
}
