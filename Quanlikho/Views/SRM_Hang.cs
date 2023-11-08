using Quanlikho.Controller;
using Quanlikho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho.Views
{
    public partial class SRM_Hang : Form
    {
        HHController controller;
        List<hang> hang;
        hang currenthang;

        public SRM_Hang()
        {
            InitializeComponent();
            controller = new HHController();
            hang = new List<hang>();
            currenthang = new hang();
            DGV_HangHoa.ColumnCount = 3;
            DGV_HangHoa.Columns[0].Name = "Mã hàng hóa";
            DGV_HangHoa.Columns[1].Name = "Tên hàng hóa";
            DGV_HangHoa.Columns[2].Name = "Đơn vị tính";
        }

        private void loadData()
        {
            hang.Clear();
            hang = controller.load();
            DGV_HangHoa.Rows.Clear();

            foreach (hang k in hang)

            {
                String[] row = { k.getMamathang(), k.getTenmathang(), k.getDonvitinh() };
                DGV_HangHoa.Rows.Add(row);
            }
        }

        private void SRM_Hang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
            {
                // Hiển thị một thông báo lỗi.
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Thực hiện các bước tìm kiếm.
            hang.Clear();
            hang = controller.search(txt_tim.Text);
            DGV_HangHoa.Rows.Clear();

            foreach (hang k in hang)

            {
                String[] row = { k.getMamathang(), k.getTenmathang(), k.getDonvitinh() };
                DGV_HangHoa.Rows.Add(row);
            }

        }
        public void clear() //Xóa trắng ở text box
        {
            txt_mahang.Clear();
            txt_tenhang.Clear();
            txt_dvt.Clear();
            txt_tim.Clear();
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_mahang.Text) && !string.IsNullOrWhiteSpace(txt_tenhang.Text) && !string.IsNullOrWhiteSpace(txt_dvt.Text))
            {
                currenthang = new hang(txt_mahang.Text, txt_tenhang.Text, txt_dvt.Text);

                bool testSuccessfully = controller.isExist(currenthang);

                if (testSuccessfully)
                {
                    MessageBox.Show("Đã có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool addedSuccessfully = controller.insert(currenthang);

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

            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            currenthang = new hang(txt_mahang.Text, txt_tenhang.Text, txt_dvt.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool deletedSuccessfully = controller.delete(currenthang);

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

        private void button_sua_Click(object sender, EventArgs e)
        {
            currenthang = new hang(txt_mahang.Text, txt_tenhang.Text, txt_dvt.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool updatedSuccessfully = controller.update(currenthang);

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

        private void DGV_HangHoa_Click(object sender, EventArgs e)
        {
            if (DGV_HangHoa.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = DGV_HangHoa.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_mahang.Text = row.Cells[0].Value.ToString();
            txt_tenhang.Text = row.Cells[1].Value.ToString();
            txt_dvt.Text = row.Cells[2].Value.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_dvt.Clear();
            txt_mahang.Clear();
            txt_tenhang.Clear();
            txt_tim.Clear();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
        }

        private void SRM_Hang_Click(object sender, EventArgs e)
        {
            loadData(); 
        }
    }
}
