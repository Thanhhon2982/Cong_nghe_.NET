using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Kho
    {
        private String makho;
        private String tenkho;
        private String diachi;
        public Kho() { }
        public Kho(String makho, String tenkho,string diachi)
        {
            this.makho = makho;
            this.tenkho = tenkho;
            this.diachi = diachi;
        }
        
        public string getMakho() { return makho; }
        public string getTenkho() {  return tenkho; }
        public string getDiachi() {  return diachi; }

        public void setMakho(string makho) {  this.makho = makho; }
        public void setTenkho(string tenkho) { this.tenkho = tenkho;}
       public void setDiachi(string diachi) {  this.diachi = diachi;}

        public String toString()
        {
            return makho + tenkho + diachi;
        }

    }
}
