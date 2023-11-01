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
    internal class PhieunhapController
    {
        List<phieunhap> phieunhapList;

        public PhieunhapController()
        {
            phieunhapList = new List<phieunhap>();

        }
        public List<phieunhap> load()
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from phieunhapnhap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maphieunhap = reader["maphieunhap"].ToString();
                    DateTime ngaynhapphieu = Convert.ToDateTime(reader["ngaynhapphieu"].ToString());
                    String nguoigiao = reader["nguoigiao"].ToString();
                    String sohoadon = reader["sohoadon"].ToString();
                    DateTime ngayhoadon = Convert.ToDateTime(reader["ngayhoadon"].ToString());
                    String donviphathanh = reader["donviphathanh"].ToString();
                    String makho = reader["makho"].ToString();
                    phieunhap phieunhap = new phieunhap(maphieunhap ,ngaynhapphieu, nguoigiao, sohoadon, ngayhoadon, donviphathanh, makho);
                    phieunhapList.Add(phieunhap);
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
            return phieunhapList;
        }
        public phieunhap get(string id)
        {

            foreach (phieunhap phieunhap in phieunhapList)
            {
                if (phieunhap.getMaphieunhap().ToString() == id)
                {
                    return phieunhap;
                }
            }
            return null;
        }

        public bool insert(phieunhap phieunhap)
        {

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO phieunhap( maphieunhap, ngaynhapphieu, nguoigiao, sohoadon,ngayhoadon,donviphathanh,makho)  VALUES ( @maphieunhap, @ngaynhapphieu, @nguoigiao, @sohoadon,@ngayhoadon,@donviphathanh,@makho)", conn);
                command.Parameters.AddWithValue("@maphieunhap", phieunhap.getMaphieunhap());
                command.Parameters.AddWithValue("@ngaynhapphieu", phieunhap.getNgaynhapphieu());
                command.Parameters.AddWithValue("@nguoigiao", phieunhap.getNguoigiao());
                command.Parameters.AddWithValue("@sohoadon", phieunhap.getSohoadon());
                command.Parameters.AddWithValue("@ngayhoadon", phieunhap.getNgayhoadon());
                command.Parameters.AddWithValue("@donviphathanh", phieunhap.getDonviphathanh());
                command.Parameters.AddWithValue("@makho", phieunhap.getMakho());
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
        public bool update(phieunhap phieunhap)
        {
            if (phieunhap != null && !string.IsNullOrEmpty(phieunhap.getMaphieunhap().ToString()) && !string.IsNullOrEmpty(phieunhap.getNgaynhapphieu().ToString()) && !string.IsNullOrEmpty(phieunhap.getNguoigiao().ToString()) && !string.IsNullOrEmpty(phieunhap.getSohoadon().ToString()) && !string.IsNullOrEmpty(phieunhap.getNgayhoadon().ToString()) && !string.IsNullOrEmpty(phieunhap.getDonviphathanh()) && !string.IsNullOrEmpty(phieunhap.getMakho()))
            {
                // Update the kho in the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update phieunhapnhap set  ngaynhapphieu = @ngaynhapphieu, nguoigiao = @nguoigiao ,sohoadon = @sohoadon ,ngayhoadon=@ngayhoadon, donviphathanh = @donviphathanh ,makho = @makho where maphieunhap = @maphieunhap ", conn);
                    cmd.Parameters.AddWithValue("@ngaynhapphieu", phieunhap.getNgaynhapphieu());
                    cmd.Parameters.AddWithValue("@nguoigiao", phieunhap.getNguoigiao());
                    cmd.Parameters.AddWithValue("@sohoadon", phieunhap.getSohoadon());
                    cmd.Parameters.AddWithValue("@ngayhoadon", phieunhap.getNgayhoadon());
                    cmd.Parameters.AddWithValue("@donviphathanh", phieunhap.getDonviphathanh());
                    cmd.Parameters.AddWithValue("@makho", phieunhap.getMakho());
                    cmd.Parameters.AddWithValue("@maphieunhap", phieunhap.getMaphieunhap());
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

        public bool delete(phieunhap phieunhap)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from phieunhapnhap where maphieunhap = @maphieunhap", conn);
                command.Parameters.AddWithValue("@maphieunhap", phieunhap.getMaphieunhap());
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
                phieunhapList.Remove(phieunhapList.FirstOrDefault(k => k.getMaphieunhap().ToString() == id));

                // Delete the kho from the database.
                SqlConnection conn = DatabaseHelper.getConnection();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from phieunhapnhap where maphieunhap = @maphieunhap", conn);
                    cmd.Parameters.AddWithValue("@maphieunhap", id);
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
        public List<phieunhap> search(String keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return phieunhapList;
            }

            // Create a list to store the results.
            List<phieunhap> results = new List<phieunhap>();

            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM phieunhapnhap where maphieunhap = @maphieunhap", conn);
                command.Parameters.AddWithValue("@maphieunhap", keyword);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maphieunhap = reader["maphieunhap"].ToString();
                    DateTime ngaynhapphieu = Convert.ToDateTime(reader["ngaynhapphieu"].ToString());
                    String nguoigiao = reader["nguoigiao"].ToString();
                    String sohoadon = reader["sohoadon"].ToString();
                    DateTime ngayhoadon = Convert.ToDateTime(reader["ngayhoadon"].ToString());
                    String donviphathanh = reader["donviphathanh"].ToString();
                    String makho = reader["makho"].ToString();
                    phieunhap phieunhap = new phieunhap(maphieunhap, ngaynhapphieu, nguoigiao, sohoadon, ngayhoadon, donviphathanh, makho);
                    phieunhapList.Add(phieunhap);
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
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM phieunhapnhap WHERE maphieunhap = @maphieunhap", conn);
                // Add a parameter for the id
                command.Parameters.AddWithValue("@maphieunhap", id);
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
        public bool isExist(phieunhap phieunhap)
        {
            // Kiểm tra xem đối tượng Kho có hợp lệ hay không
            if (phieunhap == null || string.IsNullOrEmpty(phieunhap.getMaphieunhap().ToString()))
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
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM phieunhapnhap WHERE maphieunhap = @maphieunhap", conn);
                // Thêm một tham số cho mã kho
                command.Parameters.AddWithValue("@maphieunhap", phieunhap.getMaphieunhap().ToString());
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
