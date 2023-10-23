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
        

        public SRM_kho()
        {
            InitializeComponent();
            
            controller = new DBController();
            dsKho = new List<Kho>();
            currentKho = new Kho();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            //if ((string.IsNullOrEmpty(text_makho.Text)) || (string.IsNullOrEmpty(text_tenkho.Text)) || (string.IsNullOrEmpty(text_diachi.Text)))
            //{
            //    MessageBox.Show("Vui lòng điền đủ thông tin");
            //}   
            //else
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("insert into dskho values (N'"+text_makho.Text+"',N'"+text_tenkho.Text+"', N'"+text_diachi.Text+"') ", conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Lưu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //    text_makho.Clear();
            //    text_tenkho.Clear();
            //    text_diachi.Clear();
            //    text_makho.Focus();
            //    conn.Close();
            //    button_load_Click(sender, e);
                
            //}
        }

        private void lst_xem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    SqlCommand cmd = new SqlCommand("Delete from dskho where makho = '" + text_makho.Text + "' ", conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    text_makho.Clear();
            //    text_tenkho.Clear();
            //    text_diachi.Clear();
            //    text_makho.Focus();
            //}
            //conn.Close();
            //button_load_Click(sender, e);
                
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    SqlCommand cmd = new SqlCommand("update dskho set tenkho = N'" + text_tenkho.Text + "', diachi = N'" + text_diachi.Text + "' where makho = '" + text_makho.Text + "' ", conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    text_makho.Clear();
            //    text_tenkho.Clear();
            //    text_diachi.Clear();
            //    text_makho.Focus();
            //}
            //conn.Close();
            //button_load_Click(sender, e);
            

        }
       
        private void button_load_Click(object sender, EventArgs e)
        {
           dsKho = controller.load();
            
        }

 

        private void lst_xem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            text_makho.Text = lst_xem.SelectedItems[0].SubItems[0].Text;
            text_tenkho.Text = lst_xem.SelectedItems[0].SubItems[1].Text;
            text_diachi.Text = lst_xem.SelectedItems[0].SubItems[2].Text;

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            //lst_xem.Items.Clear();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from dskho where diachi like N'%" + txttim.Text + "%' or makho like N'%" + txttim.Text + "%' or tenkho like N'%" + txttim.Text + "%'", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    ListViewItem lv = new ListViewItem(reader.GetString(0).ToString());
            //    lv.SubItems.Add(reader.GetString(1));
            //    lv.SubItems.Add(reader.GetString(2));
            //    lst_xem.Items.Add(lv);
            //}
            //conn.Close();
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_makho.Clear();
            text_tenkho.Clear();
            text_diachi.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
