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

        public bool insert(Kho kho) {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dskho  VALUES (@maKho, @tenKho, @diaChi)", conn);
                command.Parameters.AddWithValue("@maKho", kho.getMakho());
                command.Parameters.AddWithValue("@tenKho", kho.getTenkho());
                command.Parameters.AddWithValue("@diaChi", kho.getDiachi());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool update(Kho kho) {
            if (kho != null && !string.IsNullOrEmpty(kho.getMakho()) && !string.IsNullOrEmpty(kho.getTenkho()) && !string.IsNullOrEmpty(kho.getDiachi()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update dskho set tenkho = @tenKho, diachi = @diaChi where makho = @maKho", conn);
                    cmd.Parameters.AddWithValue("@tenKho", kho.getTenkho());
                    cmd.Parameters.AddWithValue("@diaChi", kho.getDiachi());
                    cmd.Parameters.AddWithValue("@maKho", kho.getMakho());
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
        
        public bool delete(Kho kho) {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from dskho where makho = @maKho", conn);
                command.Parameters.AddWithValue("@maKho", kho.getMakho());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
        public bool delete(String makho)
        {
            if (!string.IsNullOrEmpty(makho))
            {
                // Delete the kho from the list.
                khoList.Remove(khoList.FirstOrDefault(k => k.getMakho() == makho));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from dskho where makho = @makho", conn);
                    cmd.Parameters.AddWithValue("@makho", makho);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
        public List<Kho> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return khoList;
            }

            // Create a list to store the results.
            List<Kho> results = new List<Kho>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM dskho where makho = @makho", conn);
                command.Parameters.AddWithValue("@makho", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String makho = reader["makho"].ToString();
                    String tenkho = reader["tenkho"].ToString();
                    String diachi = reader["diachi"].ToString();
                    Kho kho = new Kho(makho,tenkho,diachi);
                    results.Add(kho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return results;
        }
        public bool isExit(Kho kho)
        {
            return false;
        }
        public bool isExit(String id)
        {
            return false;
        }

    }
}
