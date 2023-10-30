using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class chitiet
    {
        private int id;
        private string maphieunhap;
        private string mamathang;
        private int soluong;
        private int dongia;

        public chitiet()
        {

        }
        public chitiet(int id, string maphieunhap, string mamathang, int soluong, int dongia)
        {
            this.id = id;
            this.maphieunhap = maphieunhap;
            this.mamathang = mamathang;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        public int getId() { return id; }
        public string getMaphieunhap() {  return maphieunhap; }
        public string getMamathang() {  return mamathang; }
        public int getSoluong() { return soluong; }
        public int getDongia() {  return dongia; }

        public void setId(int id) { this.id = id;}
        public void setMaphieunhap(string maphieunhap) { this.maphieunhap= maphieunhap; }
        public void setMamathang(string mamathang) {  this.mamathang= mamathang;}
        public void setSoluong(int soluong) {  this.soluong= soluong;}
        public void setDongia(int dongia) {  this.dongia= dongia;}
        public String toString()
        {
            return id + maphieunhap + mamathang + soluong + dongia;
        }
    }
}
