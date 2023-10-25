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
                    khoList.Add(kho);                 
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return khoList;
        }
        public Kho get(string Makho) {

            foreach (Kho kho in khoList)
            {
                if (kho.getMakho() == Makho)
                {
                    return kho;
                }
            }
            return null;
        }

        public bool insert(string makho, string tenkho, string diachi) {

            Kho newKho = new Kho(makho, tenkho, diachi);
            khoList.Add(newKho);
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO dskho (makho, tenkho, diachi) VALUES (@makho, @tenkho, @diachi)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    command.Parameters.AddWithValue("@tenkho", tenkho);
                    command.Parameters.AddWithValue("@diachi", diachi);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(string makho, string tenkho, string diachi) {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE dskho SET tenkho = @tenkho, diachi = @diachi WHERE makho = @makho";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@tenkho", tenkho);
                    command.Parameters.AddWithValue("@diachi", diachi);
                    command.Parameters.AddWithValue("@makho", makho);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(String makho) {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM dskho WHERE makho = @makho";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        
    }
}
