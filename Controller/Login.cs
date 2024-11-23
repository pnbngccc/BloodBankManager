using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{
    internal class Login
    {
        private string connectionString = "server=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        public bool LoginController(string username, string password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM NhanVienTbl WHERE TenDangNhap = @username AND MatKhau = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = (int)command.ExecuteScalar();
                return result > 0; // Trả về true nếu có ít nhất 1 bản ghi khớp
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public string GetRole(string TenDangNhap, string MatKhau)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT Role FROM NhanVienTbl WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                string result = (string)cmd.ExecuteScalar();
                return result; // Trả về vai trò của người dùng
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                return null; // Trả về null nếu có lỗi
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Trả về null nếu có lỗi chung
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
