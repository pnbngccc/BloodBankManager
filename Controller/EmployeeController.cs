using BloodBankManagement.Model;
using BloodBankManagement.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{
    internal class EmployeeController : IController
    {
        readonly string connectionString = "server=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> employees = new List<IModel>();

        public List<IModel> Items => employees;

        public bool Create(IModel model)
        {
            if (model is EmployeeModel employee)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO NhanVienTbl (MaNhanVien, TenDangNhap, MatKhau, Role) VALUES (@MaNhanVien, @TenDangNhap, @MatKhau, @Role)", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                    cmd.Parameters.AddWithValue("@TenDangNhap", employee.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", employee.MatKhau);
                    cmd.Parameters.AddWithValue("@Role", employee.Role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is EmployeeModel employee)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public bool Load()
        {
            employees.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVienTbl ORDER BY MaNhanVien ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel
                    {
                        MaNhanVien = reader.GetInt32(0),
                        TenDangNhap = reader.GetString(1),
                        MatKhau = reader.GetString(2),
                        Role = reader.GetString(3)
                    };
                    employees.Add(employee);
                }
                return true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Load(object id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien", conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel
                    {
                        MaNhanVien = reader.GetInt32(0),
                        TenDangNhap = reader.GetString(1),
                        MatKhau = reader.GetString(2),
                        Role = reader.GetString(3)
                    };
                    employees.Clear();
                    employees.Add(employee);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public IModel Read(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVienTbl WHERE MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new EmployeeModel
                        {
                            MaNhanVien = reader.GetInt32(0),
                            TenDangNhap = reader.GetString(1),
                            MatKhau = reader.GetString(2),
                            Role = reader.GetString(3)
                        };
                    }
                    return null;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is EmployeeModel employee)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE NhanVienTbl SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, Role = @Role WHERE MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                    cmd.Parameters.AddWithValue("@TenDangNhap", employee.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", employee.MatKhau);
                    cmd.Parameters.AddWithValue("@Role", employee.Role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }
    }
}
