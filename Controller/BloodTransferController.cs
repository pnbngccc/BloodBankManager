using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BloodBankManagement.Controller
{
    internal class BloodTransferController : IController
    {
        readonly string connectionString = "server=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> bloodtransfers = new List<IModel>();

        public List<IModel> Items => bloodtransfers;

        public bool Create(IModel model)
        {
            if (model is BloodTransferModel bloodtransfer)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ChuyenGiaoMauTbl (MaChuyenGiao, HoVaTenNguoiNhan, NhomMau) VALUES (@MaChuyenGiao, @HoVaTenNguoiNhan, @NhomMau)", conn);
                    cmd.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                    cmd.Parameters.AddWithValue("@HoVaTenNguoiNhan", bloodtransfer.HoVaTenNguoiNhan);
                    cmd.Parameters.AddWithValue("@NhomMau", bloodtransfer.NhomMau);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
            if (id is BloodTransferModel bloodtransfer)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao", conn);
                    cmd.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
            if (model is BloodTransferModel bloodtransfer)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao", conn);
                    cmd.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
            bloodtransfers.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChuyenGiaoMauTbl ORDER BY MaChuyenGiao ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BloodTransferModel bloodtransfer = new BloodTransferModel
                    {
                        MaChuyenGiao = reader.GetInt32(0),
                        HoVaTenNguoiNhan = reader.GetString(1),
                        NhomMau = reader.GetString(2)
                    };
                    bloodtransfers.Add(bloodtransfer);
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao", conn);
                cmd.Parameters.AddWithValue("@MaChuyenGiao", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    BloodTransferModel bloodtransfer = new BloodTransferModel
                    {
                        MaChuyenGiao = reader.GetInt32(0),
                        HoVaTenNguoiNhan = reader.GetString(1),
                        NhomMau = reader.GetString(2)
                    };
                    bloodtransfers.Clear();
                    bloodtransfers.Add(bloodtransfer);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public IModel Read(IModel id)
        {
            if (id is BloodTransferModel bloodtransfer)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ChuyenGiaoMauTbl WHERE MaChuyenGiao = @MaChuyenGiao", conn);
                    cmd.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new BloodTransferModel
                        {
                            MaChuyenGiao = reader.GetInt32(0),
                            HoVaTenNguoiNhan = reader.GetString(1),
                            NhomMau = reader.GetString(2)
                        };
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
            if (model is BloodTransferModel bloodtransfer)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ChuyenGiaoMauTbl SET HoVaTenNguoiNhan = @HoVaTenNguoiNhan, NhomMau = @NhomMau WHERE MaChuyenGiao = @MaChuyenGiao", conn);
                    cmd.Parameters.AddWithValue("@MaChuyenGiao", bloodtransfer.MaChuyenGiao);
                    cmd.Parameters.AddWithValue("@HoVaTenNguoiNhan", bloodtransfer.HoVaTenNguoiNhan);
                    cmd.Parameters.AddWithValue("@NhomMau", bloodtransfer.NhomMau);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
