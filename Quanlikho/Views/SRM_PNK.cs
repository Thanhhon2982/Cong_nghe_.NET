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
    public partial class SRM_PNK : Form
    {
        DBController khoController;//kho controller
        HHController hanghoaController;// HangHoaController
        List<Kho> ds_kho;//danh sach kho
        List<hang> ds_HangHoa;//danh sach hang hoa
        public SRM_PNK()
        {
            InitializeComponent();
        }

        private void SRM_PNK_Load(object sender, EventArgs e)
        {
            ds_kho = new List<Kho>(); //chứa danh sách kho
            khoController = new DBController();//Kho controller
            ds_kho = khoController.load();
            ds_HangHoa = new List<hang>();
            hanghoaController = new HHController();
            ds_HangHoa = hanghoaController.load();


            foreach (Kho k in ds_kho)
            {
                cbb_mk.Items.Add(k.getMakho());

            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "ID";
            comboboxColumn.HeaderText = "Mã hàng";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 90;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (hang k in ds_HangHoa)
            {
                comboboxColumn.Items.Add(k.getMamathang());
            }
            dgv_hh.Columns.Clear();
            dgv_hh.Columns.Add(comboboxColumn);//Ma hang
            //tên hàng
            DataGridViewTextBoxColumn colTenHang = new DataGridViewTextBoxColumn();
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.HeaderText = "Tên hàng";
            dgv_hh.Columns.Add(colTenHang);
            // Đơn vị tính
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "DVT";
            colDVT.HeaderText = "Đơn vị tính";
            dgv_hh.Columns.Add(colDVT);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            dgv_hh.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            dgv_hh.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            dgv_hh.Columns.Add(colThanhTien);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_hh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //column index 0 là mặt hàng
            if (e.ColumnIndex == 0)
            {
                String id = dgv_hh.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dgv_hh.Rows[e.RowIndex].Cells[1].Value = hanghoaController.get(id).getTenmathang();
                dgv_hh.Rows[e.RowIndex].Cells[2].Value = hanghoaController.get(id).getDonvitinh();

            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(dgv_hh.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int dg = int.Parse(dgv_hh.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                dgv_hh.Rows[e.RowIndex].Cells[5].Value = sl * dg;

            }
        }
    }
}
