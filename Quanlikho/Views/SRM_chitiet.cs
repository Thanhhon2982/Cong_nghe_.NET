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
using Quanlikho.Controller;
namespace Quanlikho.Views
{
    public partial class SRM_chitiet : Form
    {
        ChitietController controller;
        HHController HHController;
        PhieunhapController PhieunhapController;
        List<chitiet> chitiets;
        List<hang> ds_HangHoa;
        List<phieunhap> ds_phieunhap;
        chitiet currentchitiet;
        public SRM_chitiet()
        {
            InitializeComponent();
            controller = new ChitietController();
            chitiets = new List<chitiet>();
            currentchitiet = new chitiet();
            ds_HangHoa = new List<hang>();
            HHController = new HHController();
            ds_HangHoa = HHController.load();

            ds_phieunhap = new List<phieunhap>();
            PhieunhapController = new PhieunhapController();
            ds_phieunhap = PhieunhapController.load();
             
            DGV_CTPN.ColumnCount = 5;
            DGV_CTPN.Columns[0].Name = "ID";
            DGV_CTPN.Columns[1].Name = "Mã phiếu nhập";
            DGV_CTPN.Columns[2].Name = "Mã mặt hàng";
            DGV_CTPN.Columns[3].Name = "Số lượng";
            DGV_CTPN.Columns[4].Name = "Đơn giá";
            txt_ID.Enabled = false;
            txt_ID.Text = "0";

        }
        private void loadData()
        {
            chitiets.Clear();
            chitiets = controller.load();
            DGV_CTPN.Rows.Clear();

            foreach (chitiet k in chitiets)

            {
                String[] row = { k.getId().ToString(), k.getMaphieunhap(), k.getMamathang(),k.getSoluong().ToString(),k.getDongia().ToString() };
                DGV_CTPN.Rows.Add(row);
            }
            foreach (phieunhap k in ds_phieunhap)
            {
                cbb_MPN.Items.Add(k.getMaphieunhap());

            }
            foreach (hang k in ds_HangHoa)
            {
                cbb_MMH.Items.Add(k.getMamathang());

            }
            
        }
        public void clear() //Xóa trắng ở text box
        {
            txt_ID.Text = "0";
            txt_DG.Clear();
            txt_SL.Clear();
            cbb_MMH.Text = "";
            cbb_MPN.Text = "";
            txt_tim.Clear();
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_SL.Text) && !string.IsNullOrWhiteSpace(txt_DG.Text) && !string.IsNullOrWhiteSpace(cbb_MMH.Text) && !string.IsNullOrWhiteSpace(cbb_MPN.Text))
            {
                currentchitiet = new chitiet(Convert.ToInt32(txt_ID.Text), cbb_MPN.Text, cbb_MMH.Text, Convert.ToInt32(txt_SL.Text), Convert.ToInt32(txt_DG.Text));

                bool testSuccessfully = controller.isExist(currentchitiet);

                if (testSuccessfully)
                {
                    MessageBox.Show("Đã có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool addedSuccessfully = controller.insert(currentchitiet);

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
            currentchitiet = new chitiet(Convert.ToInt32(txt_ID.Text),cbb_MPN.Text,cbb_MMH.Text,Convert.ToInt32(txt_SL.Text), Convert.ToInt32(txt_DG.Text));
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool deletedSuccessfully = controller.delete(currentchitiet);

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
            currentchitiet = new chitiet(Convert.ToInt32(txt_ID.Text), cbb_MPN.Text, cbb_MMH.Text, Convert.ToInt32(txt_SL.Text), Convert.ToInt32(txt_DG.Text));
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool updatedSuccessfully = controller.update(currentchitiet);
                
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

        private void button_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == "")
            {
                // Hiển thị một thông báo lỗi.
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Thực hiện các bước tìm kiếm.
            chitiets.Clear();
            chitiets = controller.search(txt_tim.Text);
            DGV_CTPN.Rows.Clear();

            foreach (chitiet k in chitiets)

            {
                String[] row = { k.getId().ToString(), k.getMaphieunhap(), k.getMamathang(), k.getSoluong().ToString(), k.getDongia().ToString() };
                DGV_CTPN.Rows.Add(row);
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

        private void SRM_chitiet_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void DGV_CTPN_Click(object sender, EventArgs e)
        {
            if (DGV_CTPN.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = DGV_CTPN.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            txt_ID.Text = row.Cells[0].Value.ToString();
            cbb_MPN.Text = row.Cells[1].Value.ToString();
            cbb_MMH.Text = row.Cells[2].Value.ToString();
            txt_SL.Text = row.Cells[3].Value.ToString();
            txt_DG.Text = row.Cells[4].Value.ToString();
        }

        private void SRM_chitiet_Click(object sender, EventArgs e)
        {
            ds_phieunhap.Clear();
            ds_HangHoa.Clear();
            loadData();
        }

        private void DGV_CTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
