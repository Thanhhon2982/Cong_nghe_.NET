namespace Quanlikho
{
    partial class SRM_kho
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
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_diachi = new System.Windows.Forms.TextBox();
            this.text_tenkho = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.text_makho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.DGV_Xem = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Xem)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(499, 310);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(101, 42);
            this.button_sua.TabIndex = 6;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(342, 310);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(101, 42);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Địa chỉ:";
            // 
            // text_diachi
            // 
            this.text_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_diachi.Location = new System.Drawing.Point(244, 264);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.Size = new System.Drawing.Size(281, 30);
            this.text_diachi.TabIndex = 3;
            // 
            // text_tenkho
            // 
            this.text_tenkho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenkho.Location = new System.Drawing.Point(244, 219);
            this.text_tenkho.Name = "text_tenkho";
            this.text_tenkho.Size = new System.Drawing.Size(281, 30);
            this.text_tenkho.TabIndex = 2;
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(181, 310);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(101, 42);
            this.button_them.TabIndex = 4;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // text_makho
            // 
            this.text_makho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_makho.Location = new System.Drawing.Point(244, 176);
            this.text_makho.Name = "text_makho";
            this.text_makho.Size = new System.Drawing.Size(281, 30);
            this.text_makho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên kho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã kho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 67);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quản lí kho";
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(567, 179);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(101, 42);
            this.button_load.TabIndex = 23;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.Location = new System.Drawing.Point(567, 101);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(121, 32);
            this.button_timkiem.TabIndex = 24;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(181, 109);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(344, 28);
            this.txttim.TabIndex = 25;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(567, 248);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(101, 42);
            this.button_clear.TabIndex = 27;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // DGV_Xem
            // 
            this.DGV_Xem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Xem.Location = new System.Drawing.Point(12, 382);
            this.DGV_Xem.Name = "DGV_Xem";
            this.DGV_Xem.RowHeadersWidth = 51;
            this.DGV_Xem.RowTemplate.Height = 24;
            this.DGV_Xem.Size = new System.Drawing.Size(763, 264);
            this.DGV_Xem.TabIndex = 28;
            this.DGV_Xem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Xem_CellContentClick);
            this.DGV_Xem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Xem_CellContentClick);
            // 
            // SRM_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 658);
            this.Controls.Add(this.DGV_Xem);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_diachi);
            this.Controls.Add(this.text_tenkho);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.text_makho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SRM_kho";
            this.Text = "SRM_kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Xem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_diachi;
        private System.Windows.Forms.TextBox text_tenkho;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox text_makho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridView DGV_Xem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

