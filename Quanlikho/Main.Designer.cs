namespace Quanlikho
{
    partial class Main
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xemToolStripMenuItem,
            this.nhậpXuấtKhoToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.cấuHìnhToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.xemToolStripMenuItem.Text = "Danh mục";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // nhậpXuấtKhoToolStripMenuItem
            // 
            this.nhậpXuấtKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoToolStripMenuItem1,
            this.hàngHóaToolStripMenuItem,
            this.phiếuNhậpKhoToolStripMenuItem});
            this.nhậpXuấtKhoToolStripMenuItem.Name = "nhậpXuấtKhoToolStripMenuItem";
            this.nhậpXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.nhậpXuấtKhoToolStripMenuItem.Text = "Nhập/Xuất kho";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // khoToolStripMenuItem1
            // 
            this.khoToolStripMenuItem1.Name = "khoToolStripMenuItem1";
            this.khoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.khoToolStripMenuItem1.Text = "Kho";
            this.khoToolStripMenuItem1.Click += new System.EventHandler(this.khoToolStripMenuItem1_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // phiếuNhậpKhoToolStripMenuItem
            // 
            this.phiếuNhậpKhoToolStripMenuItem.Name = "phiếuNhậpKhoToolStripMenuItem";
            this.phiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            this.phiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "QLK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
    }
}