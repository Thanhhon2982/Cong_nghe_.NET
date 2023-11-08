using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlikho.Controller;
using Quanlikho.Model;
namespace Quanlikho.Views
{
    public partial class SRM_Phieunhap : Form
    {
        PhieunhapController phieunhapController;
        List<phieunhap> phieunhapList;
        phieunhap currentPN;
        DBController khoController;
        List<Kho> khoList;
        public SRM_Phieunhap()
        {
            InitializeComponent();
            phieunhapController = new PhieunhapController();
            phieunhapList = new List<phieunhap>();
            currentPN = new phieunhap();
            khoList = new List<Kho>();
            khoController = new DBController();
            khoList = khoController.load();

            DGV_PN.ColumnCount = 7;
            DGV_PN.Columns[0].Name = "Mã phiếu nhập";
            DGV_PN.Columns[1].Name = "Ngày phiếu nhập";
            DGV_PN.Columns[2].Name = "Người giao";
            DGV_PN.Columns[3].Name = "Số hóa đơn";
            DGV_PN.Columns[4].Name = "Ngày hóa đơn";
            DGV_PN.Columns[5].Name = "Đơn vị phát hành hóa đơn";
            DGV_PN.Columns[6].Name = "Mã kho";

        }
        private void loadData()
        {
            phieunhapList.Clear();
            phieunhapList = phieunhapController.load();
            DGV_PN.Rows.Clear();

            foreach (phieunhap k in phieunhapList)

            {
                String[] row = { k.getMaphieunhap().ToString(), k.getNgaynhapphieu().ToString(), k.getNguoigiao(), k.getSohoadon().ToString(), k.getNgayhoadon().ToString(),k.getDonviphathanh().ToString(),k.getMakho().ToString() };
                DGV_PN.Rows.Add(row);
            }
            foreach (Kho k in khoList)
            {
                cbb_mk.Items.Add(k.getMakho());

            }
        }
        public void clear() //Xóa trắng ở text box
        {
            txt_sp.Clear();
            txt_ngayhd.Clear();
            txt_dvphhd.Clear();
            txt_ngay.Clear();
            txt_nguoigiao.Clear();
            txt_sohd.Clear();
            txt_tim.Clear();
            cbb_mk.Items.Clear();
            cbb_mk.Text = "";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_sp.Text) && !string.IsNullOrWhiteSpace(txt_ngay.Text) && !string.IsNullOrWhiteSpace(txt_nguoigiao.Text) && !string.IsNullOrWhiteSpace(txt_sohd.Text) && !string.IsNullOrWhiteSpace(txt_ngayhd.Text) && !string.IsNullOrWhiteSpace(txt_dvphhd.Text) && !string.IsNullOrWhiteSpace(cbb_mk.Text))
            {
                currentPN = new phieunhap(txt_sp.Text,Convert.ToDateTime(txt_ngay.Text),txt_nguoigiao.Text,txt_sohd.Text,Convert.ToDateTime(txt_ngayhd.Text),txt_dvphhd.Text,cbb_mk.Text);

                bool checkTrung = phieunhapController.isExist(currentPN);

                if (checkTrung)
                {
                    MessageBox.Show("Đã có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool CheckThem = phieunhapController.insert(currentPN);

                    if (CheckThem)
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
            currentPN = new phieunhap(txt_sp.Text, Convert.ToDateTime(txt_ngay.Text), txt_nguoigiao.Text, txt_sohd.Text, Convert.ToDateTime(txt_ngayhd.Text), txt_dvphhd.Text, cbb_mk.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool CheckXoa = phieunhapController.delete(currentPN);

                if (CheckXoa)
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
            currentPN = new phieunhap(txt_sp.Text, Convert.ToDateTime(txt_ngay.Text), txt_nguoigiao.Text, txt_sohd.Text, Convert.ToDateTime(txt_ngayhd.Text), txt_dvphhd.Text, cbb_mk.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool CheckSua = phieunhapController.update(currentPN);

                if (CheckSua)
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

        private void button_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
            {
                // Hiển thị một thông báo lỗi.
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Thực hiện các bước tìm kiếm.
            phieunhapList.Clear();
            phieunhapList = phieunhapController.search(txt_tim.Text);
            DGV_PN.Rows.Clear();

            foreach (phieunhap k in phieunhapList)

            {
                String[] row = { k.getMaphieunhap().ToString(), k.getNgaynhapphieu().ToString(), k.getNguoigiao(), k.getSohoadon().ToString(), k.getNgayhoadon().ToString(), k.getDonviphathanh().ToString(), k.getMakho().ToString() };
                DGV_PN.Rows.Add(row);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear();
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

        private void DGV_PN_Click(object sender, EventArgs e)
        {
            if (DGV_PN.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = DGV_PN.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_sp.Text = row.Cells[0].Value.ToString();
            txt_ngay.Text = row.Cells[1].Value.ToString();
            txt_nguoigiao.Text = row.Cells[2].Value.ToString();
            txt_sohd.Text = row.Cells[3].Value.ToString();
            txt_ngayhd.Text = row.Cells[4].Value.ToString();
            txt_dvphhd.Text = row.Cells[5].Value.ToString();
            cbb_mk.Text = row.Cells[6].Value.ToString();
        }

        private void SRM_Phieunhap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void SRM_Phieunhap_Click(object sender, EventArgs e)
        {
            khoList.Clear();
            loadData();
        }
    }
}
