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
    public class KhachHangDAL:SqlDataProvider
    {
        public List<KhachHang> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            List<KhachHang> list = new List<KhachHang>();
            using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_getByTop", GetConection()))
            {
                KhachHang obj = new KhachHang();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.KhachHangIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool KhachHang_Insert(KhachHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaKH", data.MaKH);
                    dbCmd.Parameters.Add("@TenKH", data.TenKH);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@Email", data.Email);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                   dbCmd.Parameters.Add("@NgaySinh", data.NgaySinh);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KhachHang_Update(KhachHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaKH", data.MaKH);
                    dbCmd.Parameters.Add("@TenKH", data.TenKH);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                    dbCmd.Parameters.Add("@Email", data.Email);
                    dbCmd.Parameters.Add("@NgaySinh", data.NgaySinh);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KhachHang_Delete(KhachHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaKH", data.MaKH);

                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public SqlDataReader Select_TenKH()
        {
            SqlDataReader reader;
            using (SqlCommand dbCmd = new SqlCommand("sp_Select_TenKH", GetConection()))
            {
                dbCmd.CommandType = CommandType.Text;
                reader = dbCmd.ExecuteReader();
            }
            return reader;
        }
        public List<KhachHang> KhachHang_Search(string Search)
        {
            List<KhachHang> list = new List<KhachHang>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Search_TenKH", GetConection()))
            {
                KhachHang obj = new KhachHang();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@TenKH",Search));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.KhachHangIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public DataSet PhanTrang_KhachHang(int start, int sodong)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                using (SqlCommand dbCmd = new SqlCommand("SELECT * FROM KhachHang", GetConection()))
                {
                    adapter.SelectCommand = dbCmd;
                    adapter.Fill(ds, start, sodong, "KhachHang");

                }
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public int TongSoLuong_KhachHang()
        {


            int SoLuong;
            using (SqlCommand dbCmd = new SqlCommand("sp_TongSLKhachHang", GetConection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                object result = dbCmd.ExecuteScalar();
                SoLuong = Convert.ToInt32(result);
                return SoLuong;
            }


        }
    }
}
