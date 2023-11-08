namespace Quanlikho.Views
{
    partial class SRM_Hang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_tim = new System.Windows.Forms.Button();
            this.DGV_HangHoa = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa:";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahang.Location = new System.Drawing.Point(305, 110);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(308, 30);
            this.txt_mahang.TabIndex = 1;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhang.Location = new System.Drawing.Point(305, 159);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(308, 30);
            this.txt_tenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dvt.Location = new System.Drawing.Point(305, 200);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(308, 30);
            this.txt_dvt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 67);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bảng hàng hóa";
            // 
            // button_tim
            // 
            this.button_tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tim.Location = new System.Drawing.Point(603, 251);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(113, 38);
            this.button_tim.TabIndex = 7;
            this.button_tim.Text = "Tìm";
            this.button_tim.UseVisualStyleBackColor = true;
            this.button_tim.Click += new System.EventHandler(this.button_tim_Click);
            // 
            // DGV_HangHoa
            // 
            this.DGV_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HangHoa.Location = new System.Drawing.Point(27, 306);
            this.DGV_HangHoa.Name = "DGV_HangHoa";
            this.DGV_HangHoa.RowHeadersWidth = 51;
            this.DGV_HangHoa.RowTemplate.Height = 24;
            this.DGV_HangHoa.Size = new System.Drawing.Size(719, 230);
            this.DGV_HangHoa.TabIndex = 8;
            this.DGV_HangHoa.Click += new System.EventHandler(this.DGV_HangHoa_Click);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(37, 563);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(113, 38);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(195, 563);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(113, 38);
            this.button_xoa.TabIndex = 10;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(371, 563);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(113, 38);
            this.button_sua.TabIndex = 11;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(272, 259);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(308, 30);
            this.txt_tim.TabIndex = 12;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(533, 563);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(113, 38);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(684, 563);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(113, 38);
            this.button_close.TabIndex = 14;
            this.button_close.Text = "Thoát";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // SRM_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 674);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.DGV_HangHoa);
            this.Controls.Add(this.button_tim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label1);
            this.Name = "SRM_Hang";
            this.Text = "SRM_Hang";
            this.Load += new System.EventHandler(this.SRM_Hang_Load);
            this.Click += new System.EventHandler(this.SRM_Hang_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_tim;
        private System.Windows.Forms.DataGridView DGV_HangHoa;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_close;
    }
}