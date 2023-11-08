using Quanlikho.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_kho sRM_Kho = new SRM_kho();
            sRM_Kho.ShowDialog();
            this.Close();
        }

        private void hangHoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SRM_Hang sRM_Hang = new SRM_Hang();
            sRM_Hang.ShowDialog();
            this.Close();
        }

        private void phieuNhapKhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SRM_PNK sRM_PNK = new SRM_PNK();
            sRM_PNK.ShowDialog();
            this.Close();
        }

        private void chiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_chitiet chitiet = new SRM_chitiet();
            chitiet.ShowDialog();
            this.Close();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_Phieunhap sRM_Phieunhap = new SRM_Phieunhap();
            sRM_Phieunhap.ShowDialog();
            this.Close();
        }
    }
}
