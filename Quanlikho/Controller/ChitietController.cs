using Quanlikho.Model;
using Quanlikho.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho.Controller
{
    internal class ChitietController
    {
        List<chitiet> chitietList;

        public ChitietController()
        {
            chitietList = new List<chitiet>();

        }
        public List<chitiet> load()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from chitietnhap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    String maphieunhap = reader["maphieunhap"].ToString();
                    String mamathang = reader["mamathang"].ToString();
                    int soluong = Convert.ToInt32(reader["soluong"].ToString());
                    int dongia = Convert.ToInt32(reader["dongia"].ToString());
                    chitiet chitiet = new chitiet(id, maphieunhap, mamathang, soluong, dongia);
                    chitietList.Add(chitiet);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return chitietList;
        }
        public chitiet get(string id)
        {

            foreach (chitiet chitiet in chitietList)
            {
                if (chitiet.getId().ToString() == id)
                {
                    return chitiet;
                }
            }
            return null;
        }

        public bool insert(chitiet chitiet)
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO chitietnhap( maphieunhap, mamathang, soluong, dongia)  VALUES (@maphieunhap, @mamathang, @soluong, @dongia)", conn);
                command.Parameters.AddWithValue("@maphieunhap", chitiet.getMaphieunhap());
                command.Parameters.AddWithValue("@mamathang", chitiet.getMamathang());
                command.Parameters.AddWithValue("@soluong", chitiet.getSoluong());
                command.Parameters.AddWithValue("@dongia", chitiet.getDongia());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool update(chitiet chitiet)
        {
            if (chitiet != null && !string.IsNullOrEmpty(chitiet.getId().ToString()) && !string.IsNullOrEmpty(chitiet.getMaphieunhap()) && !string.IsNullOrEmpty(chitiet.getMamathang()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update chitietnhap set maphieunhap = @maphieunhap, mamathang = @mamathang , soluong = @soluong, dongia = @dongia where id = @id", conn);
                    cmd.Parameters.AddWithValue("@maphieunhap", chitiet.getMaphieunhap());
                    cmd.Parameters.AddWithValue("@mamathang", chitiet.getMamathang());
                    cmd.Parameters.AddWithValue("@soluong", chitiet.getSoluong());
                    cmd.Parameters.AddWithValue("@dongia", chitiet.getDongia());
                    cmd.Parameters.AddWithValue("@id", chitiet.getId());
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    conn.Close();
                }
            }
            return false;
        }

        public bool delete(chitiet chitiet)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from chitietnhap where id = @id", conn);
                command.Parameters.AddWithValue("@id", chitiet.getId());
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool delete(String id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                // Delete the kho from the list.
                chitietList.Remove(chitietList.FirstOrDefault(k => k.getId().ToString() == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from chitietnhap where id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Log the exception and handle it appropriately.
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    conn.Close();
                }
            }
            return false;
        }
        public List<chitiet> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return chitietList;
            }

            // Create a list to store the results.
            List<chitiet> results = new List<chitiet>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM chitietnhap where id = @id", conn);
                command.Parameters.AddWithValue("@id", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    String maphieunhap = reader["maphieunhap"].ToString();
                    String mamathang = reader["mamathang"].ToString();
                    int soluong = Convert.ToInt32(reader["soluong"].ToString());
                    int dongia = Convert.ToInt32(reader["dongia"].ToString());
                    chitiet chitiet = new chitiet(id, maphieunhap, mamathang, soluong, dongia);
                    results.Add(chitiet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return results;
        }
        public bool isExist(string id)
        {
            // Create a connection to the database
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Open the connection
                conn.Open();

                // Create a command to check if the id exists in the QLKho table
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM chitietnhap WHERE id = @id", conn);
                // Add a parameter for the id
                command.Parameters.AddWithValue("@id", id);
                // Execute the command and get the result
                int count = (int)command.ExecuteScalar();
                // If the count is greater than zero, the id exists
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
        public bool isExist(chitiet chitiet)
        {
            // Kiểm tra xem đối tượng Kho có hợp lệ hay không
            if (chitiet == null || string.IsNullOrEmpty(chitiet.getId().ToString()))
            {
                return false;
            }

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo một lệnh để kiểm tra xem mã kho của đối tượng Kho có tồn tại trong bảng QLKho hay không
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM chitietnhap WHERE id = @id", conn);
                // Thêm một tham số cho mã kho
                command.Parameters.AddWithValue("@id", chitiet.getId().ToString());
                // Thực thi lệnh và lấy kết quả
                int count = (int)command.ExecuteScalar();
                // Nếu số lượng lớn hơn không, tức là mã kho tồn tại
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
        }

    }
}