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
    public class NhanVienDAL:SqlDataProvider
    {
        public List<NhanVien> NhanVien_GetByTop(string Top,string Where,string Order)
        {
             List<NhanVien> list=new List<NhanVien>();
          using(SqlCommand dbCmd=new SqlCommand("sp_NhanVien_getByTop",GetConection()))
            {
                NhanVien obj = new NhanVien();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
              if(dr.HasRows)
              {
                  while(dr.Read())
                  {
                      list.Add(obj.NhanVienIDataReader(dr));
                  }
              }
              dr.Close();
              obj = null;
            }
          return list;
        }
        public bool NhanVien_Insert(NhanVien data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                    dbCmd.Parameters.Add("@TenNhanVien", data.TenNhanVien);
                    dbCmd.Parameters.Add("@NgaySinh", data.NgaySinh);
                    dbCmd.Parameters.Add("@GioiTinh", data.GioiTinh);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                    dbCmd.Parameters.Add("@ChucVu", data.ChucVu);
                    dbCmd.Parameters.Add("@LuongCoBan", data.LuongCoBan);
                    dbCmd.Parameters.Add("@Ngayvaolam", data.Ngayvaolam);
                    dbCmd.Parameters.Add("@Luong", data.Luong);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool NhanVien_Update(NhanVien data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                    dbCmd.Parameters.Add("@TenNhanVien", data.TenNhanVien);
                    dbCmd.Parameters.Add("@NgaySinh", data.NgaySinh);
                    dbCmd.Parameters.Add("@GioiTinh", data.GioiTinh);
                    dbCmd.Parameters.Add("@DiaChi", data.DiaChi);
                    dbCmd.Parameters.Add("@DienThoai", data.DienThoai);
                    dbCmd.Parameters.Add("@ChucVu", data.ChucVu);
                    dbCmd.Parameters.Add("@LuongCoBan", data.LuongCoBan);
                    dbCmd.Parameters.Add("@Ngayvaolam", data.Ngayvaolam);
                    dbCmd.Parameters.Add("@Luong", data.Luong);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool NhanVien_Delete(NhanVien data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                  
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NhanVien> NhanVien_Search(string Search)
        {
            List<NhanVien> list = new List<NhanVien>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Search_TenNV", GetConection()))
            {
                NhanVien obj = new NhanVien();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@TenNV", Search));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.NhanVienIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        
       
    }
}
