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
        public string getMaphieunhap() {  return maphieunhap; }
        public DateTime getNgaynhapphieu() {  return ngaynhapphieu; }
        public string getNguoigiao() { return nguoigiao; }
        public string getSohoadon() {  return sohoadon; }
        public DateTime getNgayhoadon() { return ngayhoadon; }
        public string getDonviphathanh() { return donviphathanh; }
        public string getMakho() {  return makho; }
        public void setMaphieunhap(string maphieunhap)
        {
            this.maphieunhap = maphieunhap;
        }
        public void setNgaynhapphieu(DateTime ngaynhapphieu)
        {
            this.ngaynhapphieu = ngaynhapphieu;
        }
        public void setNguoigiao(string nguoigiao)
        {
            this.nguoigiao = nguoigiao;
        }
        public void setSohoadon(string sohoadon)
        {
            this.sohoadon = sohoadon;
        }
        public void setNgayhoadon(DateTime ngayhoadon)
        {
            this.ngayhoadon = ngayhoadon;
        }
        public void setDonviphathanh(string donviphathanh)
        {
            this.donviphathanh = donviphathanh;
        }
        public void setMakho(string makho)
        {
            this.makho = makho;
        }
        public string toString()
        {
            return maphieunhap + ngaynhapphieu + nguoigiao + sohoadon + ngayhoadon + donviphathanh + makho;
        }
    }
}
