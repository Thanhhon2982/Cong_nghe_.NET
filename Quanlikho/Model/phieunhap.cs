using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class phieunhap
    {
        private string maphieunhap;
        private DateTime ngaynhapphieu;
        private string nguoigiao;
        private string sohoadon;
        private DateTime ngayhoadon;
        private string donviphathanh;
        private string makho;
        public phieunhap() { }
        public phieunhap(string maphieunhap, DateTime ngaynhapphieu, string nguoigiao, string sohoadon, DateTime ngayhoadon, string donviphathanh, string makho)
        {
            this.maphieunhap = maphieunhap;
            this.ngaynhapphieu = ngaynhapphieu;
            this.nguoigiao = nguoigiao;
            this.sohoadon = sohoadon;
            this.ngayhoadon = ngayhoadon;
            this.donviphathanh = donviphathanh;
            this.makho = makho;
        }
    }
}
