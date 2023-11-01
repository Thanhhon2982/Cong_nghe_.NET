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

       
        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_kho sRM_Kho = new SRM_kho();
            sRM_Kho.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRM_Hang sRM_Hang = new SRM_Hang();
            sRM_Hang.ShowDialog();
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            SRM_PNK sRM_PNK = new SRM_PNK();
            sRM_PNK.ShowDialog();
        }
    }
}
