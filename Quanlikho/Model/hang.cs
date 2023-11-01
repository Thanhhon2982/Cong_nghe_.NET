using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class hang
    {
        private String mamathang;
        private String tenmathang;
        private String donvitinh;

        public hang()
        {

        }
        public hang(string mamathang, string tenmathang, string donvitinh)
        {
            this.mamathang = mamathang;
            this.tenmathang = tenmathang;
            this.donvitinh = donvitinh;
        }
        public string getMamathang()
        {
            return mamathang;
        }
        public string getTenmathang()
        {
            return tenmathang;
        }
        public string getDonvitinh()
        {
            return donvitinh;
        }
        public void setMamathang(String mamathang)
        {
            this.mamathang = mamathang;
        }
        public void setTenmathang(String tenmathang)
        {
            this.tenmathang = tenmathang;
        }
        public void setDonvitinh(String donvitinh)
        {
            this.donvitinh = donvitinh;
        }
        public String toString()
        {
            return mamathang + tenmathang + donvitinh;
        }
    }
}
