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
    internal class HHController
    {
        List<hang> hangList;

        public HHController()
        {
            hangList = new List<hang>();

        }
        public List<hang> load()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from hanghoa", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mamathang = reader["mamathang"].ToString();
                    String tenmathang = reader["tenmathang"].ToString();
                    String donvitinh = reader["donvitinh"].ToString();
                    hang hang = new hang(mamathang, tenmathang, donvitinh);
                    hangList.Add(hang);
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
            return hangList;
        }
        public hang get(string mamathang)
        {

            foreach (hang hang in hangList)
            {
                if (hang.getMamathang().Trim().Equals(mamathang.Trim()))
                {
                    return hang;
                }
            }
            return new hang("","","");
        }

        public bool insert(hang hang)
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO hanghoa  VALUES (@mamathang, @tenmathang, @donvitinh)", conn);
                command.Parameters.AddWithValue("@mamathang", hang.getMamathang());
                command.Parameters.AddWithValue("@tenmathang", hang.getTenmathang());
                command.Parameters.AddWithValue("@donvitinh", hang.getDonvitinh());
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
        public bool update(hang hang)
        {
            if (hang != null && !string.IsNullOrEmpty(hang.getMamathang()) && !string.IsNullOrEmpty(hang.getTenmathang()) && !string.IsNullOrEmpty(hang.getDonvitinh()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update hanghoa set tenmathang = @tenmathang, donvitinh = @donvitinh where mamathang = @mamathang", conn);
                    cmd.Parameters.AddWithValue("@tenmathang", hang.getTenmathang());
                    cmd.Parameters.AddWithValue("@donvitinh", hang.getDonvitinh());
                    cmd.Parameters.AddWithValue("@mamathang", hang.getMamathang());
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

        public bool delete(hang hang)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from hanghoa where mamathang = @mamathang", conn);
                command.Parameters.AddWithValue("@mamathang", hang.getMamathang());
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
        public bool delete(String mamathang)
        {
            if (!string.IsNullOrEmpty(mamathang))
            {
                // Delete the kho from the list.
                hangList.Remove(hangList.FirstOrDefault(k => k.getMamathang() == mamathang));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from hanghoa where mamathang = @mamathang", conn);
                    cmd.Parameters.AddWithValue("@mamathang", mamathang);
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
        public List<hang> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return hangList;
            }

            // Create a list to store the results.
            List<hang> results = new List<hang>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();                
                SqlCommand command = new SqlCommand("SELECT * FROM hanghoa where mamathang = @mamathang", conn);
                command.Parameters.AddWithValue("@mamathang", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String mamathang = reader["mamathang"].ToString();
                    String tenmathang = reader["tenmathang"].ToString();
                    String donvitinh = reader["donvitinh"].ToString();
                    hang hang = new hang(mamathang, tenmathang, donvitinh);
                    results.Add(hang);
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
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM hanghoa WHERE mamathang = @mamathang", conn);
                // Add a parameter for the id
                command.Parameters.AddWithValue("@mamathang", id);
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
        public bool isExist(hang hang)
        {
            // Kiểm tra xem đối tượng Kho có hợp lệ hay không
            if (hang == null || string.IsNullOrEmpty(hang.getMamathang()))
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
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM hanghoa WHERE mamathang = @mamathang", conn);
                // Thêm một tham số cho mã kho
                command.Parameters.AddWithValue("@mamathang", hang.getMamathang());
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
