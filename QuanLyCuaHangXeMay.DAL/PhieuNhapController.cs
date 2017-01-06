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
    public class PhieuNhapDAL:SqlDataProvider
    {
        public List<PhieuNhap> PhieuNhap_GetByTop(string Top, string Where, string Order)
        {
            List<PhieuNhap> list = new List<PhieuNhap>();
            using (SqlCommand dbCmd = new SqlCommand("sp_PhieuNhap_getByTop", GetConection()))
            {
                PhieuNhap obj = new PhieuNhap();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.PhieuNhapIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool PhieuNhap_Insert(PhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PhieuNhap_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);
                    dbCmd.Parameters.Add("@NgayNhap", data.NgayNhap);
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                    dbCmd.Parameters.Add("@MaNhaCungCap", data.MaNhaCungCap);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool PhieuNhap_Update(PhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PhieuNhap_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);
                    dbCmd.Parameters.Add("@NgayNhap", data.NgayNhap);
                    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                    dbCmd.Parameters.Add("@MaNhaCungCap", data.MaNhaCungCap);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PhieuNhap_Delete(PhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_PhieuNhap_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);

                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
