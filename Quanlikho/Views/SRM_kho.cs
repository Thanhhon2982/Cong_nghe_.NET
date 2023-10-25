using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Collections;
using Quanlikho.Model;
using Quanlikho.Controller;
using Quanlikho.Utils;

namespace Quanlikho
{
    public partial class SRM_kho : Form
    {
        
            DBController controller;
            List<Kho> dsKho;
            Kho currentKho;
            List<Kho> dskho2;

        public SRM_kho()
        {
            InitializeComponent();
            dskho2 = new List<Kho>();
            controller = new DBController();
            dsKho = new List<Kho>();
            currentKho = new Kho();
            DGV_Xem.ColumnCount = 3;
            DGV_Xem.Columns[0].Name = "Mã kho";
            DGV_Xem.Columns[1].Name = "Tên kho";
            DGV_Xem.Columns[2].Name = "Địa chỉ";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_makho.Text) && !string.IsNullOrWhiteSpace(text_tenkho.Text) && !string.IsNullOrWhiteSpace(text_diachi.Text))
            {
                currentKho = new Kho(text_makho.Text,text_tenkho.Text,text_diachi.Text);


                bool addedSuccessfully = controller.insert(currentKho);

                if (addedSuccessfully)
                {
                    MessageBox.Show("Đã thêm thành công!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
                
            }
            button_load_Click(sender, e);
        }


        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (DGV_Xem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Xem.SelectedRows)
                {  

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa kho " + text_tenkho.Text + " với mã kho là " + text_makho.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool deletedSuccessfully = controller.delete(text_makho.Text);

                        if (deletedSuccessfully)
                        {
                            MessageBox.Show("Đã xóa !!");
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đối tượng muốn xóa!");
            }
            button_load_Click(sender, e);

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (DGV_Xem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Xem.SelectedRows)
                {
                    currentKho = new Kho(text_makho.Text, text_tenkho.Text, text_diachi.Text);

                    bool updatedSuccessfully = controller.update(currentKho);

                    if (updatedSuccessfully)
                    {
                        MessageBox.Show("Đã sửa thành công!");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy đối tượng muốn sửa!");
            }
            button_load_Click(sender,e);


        }
       
        private void button_load_Click(object sender, EventArgs e)
        {
            dsKho.Clear();
            dsKho = controller.load();
            DGV_Xem.Rows.Clear();

            foreach (Kho k in dsKho)

            {
                String[] row = { k.getMakho(), k.getTenkho(), k.getDiachi() };
                DGV_Xem.Rows.Add(row);
            }

        }

        public void clear()
        {
            text_makho.Clear();
            text_tenkho.Clear();
            text_diachi.Clear();
            txttim.Clear();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string maKhoToSearch = txttim.Text;
            if (!string.IsNullOrEmpty(maKhoToSearch))
            {
                dskho2 = dsKho.Where(k => k.getMakho() == maKhoToSearch).ToList();
            }
            else
            {
                dskho2 = dsKho;
            }
            DGV_Xem.Rows.Clear();
            foreach (Kho kho in dskho2)
            {
                String[] row = { kho.getMakho(), kho.getTenkho(), kho.getDiachi() };
                DGV_Xem.Rows.Add(row);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear();    
        }

        private void DGV_Xem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Xem.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = DGV_Xem.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            text_makho.Text = row.Cells[0].Value.ToString();
            text_tenkho.Text = row.Cells[1].Value.ToString();
            text_diachi.Text = row.Cells[2].Value.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
            }
            
        }
    }
}
