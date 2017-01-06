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
    public class ChiTietPhieuXuatDAL:SqlDataProvider
    {
        public List<ChiTietPhieuXuat> ChiTietPhieuXuat_GetByTop(string Top, string Where, string Order)
        {
            List<ChiTietPhieuXuat> list = new List<ChiTietPhieuXuat>();
            using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuXuat_getByTop", GetConection()))
            {
                ChiTietPhieuXuat obj = new ChiTietPhieuXuat();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.ChiTietPhieuXuatIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool ChiTietPhieuXuat_Insert(ChiTietPhieuXuat data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuXuat_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPhieuXuat", data.MaPX);
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);
                    dbCmd.Parameters.Add("@SLXuat", data.SLXuat);
                    dbCmd.Parameters.Add("@DonGiaXuat", data.DonGiaXuat);
                    dbCmd.Parameters.Add("@Thue", data.Thue);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool ChiTietPhieuXuat_Update(ChiTietPhieuXuat data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuXuat_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPhieuXuat", data.MaPX);
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);
                    dbCmd.Parameters.Add("@SLXuat", data.SLXuat);
                    dbCmd.Parameters.Add("@DonGiaXuat", data.DonGiaXuat);
                    dbCmd.Parameters.Add("@Thue", data.Thue);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ChiTietPhieuXuat_Delete(ChiTietPhieuXuat data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuXuat_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPhieuXuat", data.MaPX);
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
