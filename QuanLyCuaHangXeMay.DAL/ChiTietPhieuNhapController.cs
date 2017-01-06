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
    public class ChiTietPhieuNhapDAL:SqlDataProvider
    {
        public List<ChiTietPhieuNhap> ChiTietPhieuNhap_GetByTop(string Top, string Where, string Order)
        {
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();
            using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuNhap_getByTop", GetConection()))
            {
                ChiTietPhieuNhap obj = new ChiTietPhieuNhap();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.ChiTietPhieuNhapIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool ChiTietPhieuNhap_Insert(ChiTietPhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuNhap_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);
                    dbCmd.Parameters.Add("@MaXe", data.MaHang);
                    dbCmd.Parameters.Add("@SLNhap", data.SLNhap);
                    dbCmd.Parameters.Add("@DonGiaNhap", data.DonGiaNhap);
                    dbCmd.Parameters.Add("@Thue", data.Thue);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool ChiTietPhieuNhap_Update(ChiTietPhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuNhap_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);
                    dbCmd.Parameters.Add("@MaXe", data.MaHang);
                    dbCmd.Parameters.Add("@SLNhap", data.SLNhap);
                    dbCmd.Parameters.Add("@DonGiaNhap", data.DonGiaNhap);
                    dbCmd.Parameters.Add("@Thue", data.Thue);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool ChiTietPhieuNhap_Delete(ChiTietPhieuNhap data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietPhieuNhap_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaPN", data.MaPN);
                    dbCmd.Parameters.Add("@MaXe", data.MaHang);
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
