using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.DAL
{
    public class PhieuXuatDAL:SqlDataProvider
    {
        public List<PhieuXuat> PhieuXuat_GetByTop(string Top, string Where, string Order)
        {
            List<PhieuXuat> list = new List<PhieuXuat>();
            using (SqlCommand dbCmd = new SqlCommand("sp_PhieuXuat_getByTop", GetConection()))
            {
                PhieuXuat obj = new PhieuXuat();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.PhieuXuatIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool PhieuXuat_Insert(PhieuXuat data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PhieuXuat_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaKhachHang", data.MaKhachHang);
                    dbCmd.Parameters.Add("@MaPhieuXuat", data.MaPhieuXuat);
                    dbCmd.Parameters.Add("@NgayXuat", data.NgayXuat);
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool PhieuXuat_Update(PhieuXuat data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PhieuXuat_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaKhachHang", data.MaKhachHang);
                    dbCmd.Parameters.Add("@MaPX", data.MaPhieuXuat);
                    dbCmd.Parameters.Add("@NgayXuat", data.NgayXuat);
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
        public List<PhieuXuat> PhieuXuat_Search(string Search)
        {
            List<PhieuXuat> list = new List<PhieuXuat>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Search_MaPhieuXuat", GetConection()))
            {
                PhieuXuat obj = new PhieuXuat();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@MaPhieuXuat", Search));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.PhieuXuatIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
    }
}
