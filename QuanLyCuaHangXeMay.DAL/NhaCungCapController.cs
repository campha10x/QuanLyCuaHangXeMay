using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay.DAL
{
    public class NhaCungCapDAL:SqlDataProvider
    {
        public List<NhaCungCap> NhaCungCap_GetByTop(string Top, string Where, string Order)
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            using (SqlCommand dbCmd = new SqlCommand("sp_NhaCungCap_getByTop", GetConection()))
            {
                NhaCungCap obj = new NhaCungCap();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.NhaCungCapIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool NhaCungCap_Insert(NhaCungCap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhaCungCap_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhaCC", data.MaNhaCC);
                    dbCmd.Parameters.Add("@TenNhaCC", data.TenNhaCC);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@Email", data.Email);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool NhaCungCap_Update(NhaCungCap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhaCungCap_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhaCC", data.MaNhaCC);
                    dbCmd.Parameters.Add("@TenNhaCC", data.TenNhaCC);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@Email", data.Email);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool NhaCungCap_Delete(NhaCungCap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhaCungCap_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhaCC", data.MaNhaCC);

                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet Load_NhaCC()
        {
           
                DataSet dt = new DataSet();
                    using (SqlDataAdapter dbCmd = new SqlDataAdapter("SELECT MaNhaCC,TenNhaCC from NhaCungCap", GetConection()))
                   {
                       dbCmd.Fill(dt);
                     
                   }
                    return dt;
        }
        public List<NhaCungCap> NhaCungCap_Search(string Search)
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Search_TenNhaCC", GetConection()))
            {
                NhaCungCap obj = new NhaCungCap();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@TenNhaCC", Search));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.NhaCungCapIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;

        }
        public DataSet PhanTrang_NhaCungCap(int start, int sodong)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                using (SqlCommand dbCmd = new SqlCommand("SELECT * FROM NhaCungCap", GetConection()))
                {
                    adapter.SelectCommand = dbCmd;
                    adapter.Fill(ds, start, sodong, "NhaCungCap");

                }
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
          public int TongSoLuong_NhaCungCap()
          {


              int SoLuong;
              using (SqlCommand dbCmd = new SqlCommand("sp_TongSLNhaCungCap", GetConection()))
              {
                  dbCmd.CommandType = CommandType.StoredProcedure;
                  object result = dbCmd.ExecuteScalar();
                  SoLuong = Convert.ToInt32(result);
                  return SoLuong;
              }
          }


        
    }
}
