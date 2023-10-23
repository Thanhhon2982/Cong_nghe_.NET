using Quanlikho.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlikho.Utils;
namespace Quanlikho.Controller
{
    internal class DBController
    {
        List<Kho> khoList;
     
        public DBController()
        {
            khoList = new List<Kho>();
            
        }
        public List<Kho> load() {
       
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {  
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dskho", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String makho = reader["makho"].ToString();
                    String tenkho = reader["tenkho"].ToString();
                    String diachi = reader["diachi"].ToString();
                    Kho kho = new Kho(makho,tenkho,diachi);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khoList; }
        public Kho get(string id) { return null; }
        public bool insert(Kho kho) { return false; }
        public bool update(Kho kho) { return false; }
        public bool delete(String id) { return false; }
        public bool delete(Kho kho) { return false; }
    }
}
