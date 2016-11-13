namespace WinApp150604215
{
    partial class FrmMain_chs
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查一ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShiYan_chs3_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShiYan_chs3_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShiYan_chs3_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.检查一ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(753, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重启ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.系统SToolStripMenuItem.Text = "系统&S";
            // 
            // 重启ToolStripMenuItem
            // 
            this.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem";
            this.重启ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.重启ToolStripMenuItem.Text = "重启&R";
            this.重启ToolStripMenuItem.Click += new System.EventHandler(this.重启ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 检查一ToolStripMenuItem
            // 
            this.检查一ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShiYan_chs3_2,
            this.ShiYan_chs3_3,
            this.ShiYan_chs3_4});
            this.检查一ToolStripMenuItem.Name = "检查一ToolStripMenuItem";
            this.检查一ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.检查一ToolStripMenuItem.Text = "实验";
            // 
            // ShiYan_chs3_2
            // 
            this.ShiYan_chs3_2.Name = "ShiYan_chs3_2";
            this.ShiYan_chs3_2.Size = new System.Drawing.Size(211, 30);
            this.ShiYan_chs3_2.Text = "登录&L";
            this.ShiYan_chs3_2.Click += new System.EventHandler(this.tsmiYl3_2_Click);
            // 
            // ShiYan_chs3_3
            // 
            this.ShiYan_chs3_3.Name = "ShiYan_chs3_3";
            this.ShiYan_chs3_3.Size = new System.Drawing.Size(211, 30);
            this.ShiYan_chs3_3.Text = "实验3-3";
            this.ShiYan_chs3_3.Click += new System.EventHandler(this.ShiYan_chs3_3_Click);
            // 
            // ShiYan_chs3_4
            // 
            this.ShiYan_chs3_4.Name = "ShiYan_chs3_4";
            this.ShiYan_chs3_4.Size = new System.Drawing.Size(211, 30);
            this.ShiYan_chs3_4.Text = "实验3-4";
            this.ShiYan_chs3_4.Click += new System.EventHandler(this.ShiYan_chs3_4_Click);
            // 
            // FrmMain_chs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 567);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain_chs";
            this.Text = "可视化程序设计";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 检查一ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShiYan_chs3_2;
        private System.Windows.Forms.ToolStripMenuItem ShiYan_chs3_3;
        private System.Windows.Forms.ToolStripMenuItem ShiYan_chs3_4;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}