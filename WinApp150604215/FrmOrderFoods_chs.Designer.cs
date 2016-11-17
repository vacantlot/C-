namespace WinApp150604215
{
    partial class FrmOrderFoods_chs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Meun = new System.Windows.Forms.ListBox();
            this.lb_OrderedMeun = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(78, 43);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(29, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "菜单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择的菜";
            // 
            // lb_Meun
            // 
            this.lb_Meun.ColumnWidth = 10;
            this.lb_Meun.FormattingEnabled = true;
            this.lb_Meun.ItemHeight = 12;
            this.lb_Meun.Location = new System.Drawing.Point(12, 83);
            this.lb_Meun.Name = "lb_Meun";
            this.lb_Meun.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Meun.Size = new System.Drawing.Size(146, 256);
            this.lb_Meun.Sorted = true;
            this.lb_Meun.TabIndex = 2;
            this.lb_Meun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Meun_MouseMove);
            // 
            // lb_OrderedMeun
            // 
            this.lb_OrderedMeun.FormattingEnabled = true;
            this.lb_OrderedMeun.ItemHeight = 12;
            this.lb_OrderedMeun.Location = new System.Drawing.Point(287, 83);
            this.lb_OrderedMeun.Name = "lb_OrderedMeun";
            this.lb_OrderedMeun.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_OrderedMeun.Size = new System.Drawing.Size(146, 256);
            this.lb_OrderedMeun.Sorted = true;
            this.lb_OrderedMeun.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "添加所有";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "取消选择";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "取消所有";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmOrderFoods_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_OrderedMeun);
            this.Controls.Add(this.lb_Meun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab1);
            this.Name = "FrmOrderFoods_chs";
            this.Text = "电子菜单";
            this.Load += new System.EventHandler(this.FrmOrderFoods_chs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Meun;
        private System.Windows.Forms.ListBox lb_OrderedMeun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}