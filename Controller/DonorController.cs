using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BloodBankManagement.Model;

namespace BloodBankManagement.Controller
{
    internal class DonorController : IController
    {
        private readonly string connectionString = "server=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        private List<IModel> donors = new List<IModel>();

        public List<IModel> Items => donors;

        public bool Create(IModel model)
        {
            if (model is DonorModel donor)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "INSERT INTO NguoiHienTbl (MaNguoiHien, HoVaTen, Tuoi, GioiTinh, SoDienThoai, DiaChi, NhomMau) " +
                                   "VALUES (@MaNguoiHien, @HoVaTen, @Tuoi, @GioiTinh, @SoDienThoai, @DiaChi, @NhomMau)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);
                    cmd.Parameters.AddWithValue("@HoVaTen", donor.HoVaTen);
                    cmd.Parameters.AddWithValue("@Tuoi", donor.Tuoi);
                    cmd.Parameters.AddWithValue("@GioiTinh", donor.GioiTinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", donor.SoDienThoai);
                    cmd.Parameters.AddWithValue("@DiaChi", donor.DiaChi);
                    cmd.Parameters.AddWithValue("@NhomMau", donor.NhomMau);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public bool Delete(IModel model)
        {
            if (model is DonorModel donor)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "DELETE FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
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
            if (model is DonorModel donor)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        public bool Load(object id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiHien", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DonorModel donor = new DonorModel
                    {
                        MaNguoiHien = reader.GetInt32(0),
                        HoVaTen = reader.GetString(1),
                        Tuoi = reader.GetInt32(2),
                        GioiTinh = reader.GetString(3),
                        SoDienThoai = reader.GetString(4),
                        DiaChi = reader.GetString(5),
                        NhomMau = reader.GetString(6)
                    };
                    donors.Clear();
                    donors.Add(donor);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Load()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            donors.Clear();

            try
            {
                conn.Open();
                string query = "SELECT * FROM NguoiHienTbl ORDER BY MaNguoiHien ASC";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DonorModel donor = new DonorModel
                    {
                        MaNguoiHien = reader.GetInt32(0),
                        HoVaTen = reader.GetString(1),
                        Tuoi = reader.GetInt32(2),
                        GioiTinh = reader.GetString(3),
                        SoDienThoai = reader.GetString(4),
                        DiaChi = reader.GetString(5),
                        NhomMau = reader.GetString(6)
                    };
                    donors.Add(donor);
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public IModel Read(IModel model)
        {
            if (model is DonorModel donor)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NguoiHienTbl WHERE MaNguoiHien = @MaNguoiHien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new DonorModel
                        {
                            MaNguoiHien = reader.GetInt32(0),
                            HoVaTen = reader.GetString(1),
                            Tuoi = reader.GetInt32(2),
                            GioiTinh = reader.GetString(3),
                            SoDienThoai = reader.GetString(4),
                            DiaChi = reader.GetString(5),
                            NhomMau = reader.GetString(6)
                        };
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
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
            if (model is DonorModel donor)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "UPDATE NguoiHienTbl SET HoVaTen = @HoVaTen, Tuoi = @Tuoi, GioiTinh = @GioiTinh, " +
                                   "SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, NhomMau = @NhomMau " +
                                   "WHERE MaNguoiHien = @MaNguoiHien";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaNguoiHien", donor.MaNguoiHien);
                    cmd.Parameters.AddWithValue("@HoVaTen", donor.HoVaTen);
                    cmd.Parameters.AddWithValue("@Tuoi", donor.Tuoi);
                    cmd.Parameters.AddWithValue("@GioiTinh", donor.GioiTinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", donor.SoDienThoai);
                    cmd.Parameters.AddWithValue("@DiaChi", donor.DiaChi);
                    cmd.Parameters.AddWithValue("@NhomMau", donor.NhomMau);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
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
