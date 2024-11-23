using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement.Controller
{

    internal class BloodController : IController
    {
        readonly string connectionString = "server=BAONGOC\\DULICH;Initial Catalog=BloodBankManagement;User ID=sa;Password=123456";
        List<IModel> bloods = new List<IModel>();

        public List<IModel> Items => bloods;

        public bool Create(IModel model)
        {
            if (model is BloodModel blood)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO MauTbl (NhomMau, SoLuongMau) VALUES (@NhomMau, @SoLuongMau)", conn);
                    cmd.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                    cmd.Parameters.AddWithValue("@SoLuongMau", blood.SoLuongMau);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
            if (id is BloodModel blood)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM MauTbl WHERE NhomMau = @NhomMau", conn);
                    cmd.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
            if (model is BloodModel blood)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MauTbl WHERE NhomMau = @NhomMau", conn);
                    cmd.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
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

        public bool Load()
        {
            bloods.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MauTbl ORDER BY NhomMau ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BloodModel blood = new BloodModel
                    {
                        NhomMau = reader.GetString(0),
                        SoLuongMau = reader.GetInt32(1)
                    };
                    bloods.Add(blood);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM MauTbl WHERE NhomMau = @NhomMau", conn);
                cmd.Parameters.AddWithValue("@NhomMau", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    BloodModel blood = new BloodModel
                    {
                        NhomMau = reader.GetString(0),
                        SoLuongMau = reader.GetInt32(1)
                    };
                    bloods.Clear();
                    bloods.Add(blood);
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
            if (id is BloodModel blood)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MauTbl WHERE NhomMau = @NhomMau", conn);
                    cmd.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new BloodModel
                        {
                            NhomMau = reader.GetString(0),
                            SoLuongMau = reader.GetInt32(1)
                        };
                    }
                    return null;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
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
            if (model is BloodModel blood)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE MauTbl SET SoLuongMau = @SoLuongMau WHERE NhomMau = @NhomMau", conn);
                    cmd.Parameters.AddWithValue("@NhomMau", blood.NhomMau);
                    cmd.Parameters.AddWithValue("@SoLuongMau", blood.SoLuongMau);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
