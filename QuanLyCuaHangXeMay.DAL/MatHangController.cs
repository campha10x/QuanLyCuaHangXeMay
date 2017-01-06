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
    public class MatHangDAL:SqlDataProvider
    {
        public List<MatHang> MatHang_GetByTop(string Top, string Where, string Order)
        {
            List<MatHang> list = new List<MatHang>();
            using (SqlCommand dbCmd = new SqlCommand("sp_MatHang_getByTop", GetConection()))
            {
                MatHang obj = new MatHang();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.MatHangIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool MatHang_Insert(MatHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_MatHang_Insert", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);
                    dbCmd.Parameters.Add("@TenXe", data.TenXe);
                    dbCmd.Parameters.Add("@TenHangXe", data.TenHangXe);
                    dbCmd.Parameters.Add("@SoLuong", data.SoLuong);
                    dbCmd.Parameters.Add("@ThongTinBaoHanh", data.ThongTinBaoHanh);
                    dbCmd.Parameters.Add("@NhaSX", data.NhaSX);
                    dbCmd.Parameters.Add("@DonGia", data.DonGia);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MatHang_Update(MatHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_MatHang_Update", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);
                    dbCmd.Parameters.Add("@TenXe", data.TenXe);
                    dbCmd.Parameters.Add("@TenHangXe", data.TenHangXe);
                    dbCmd.Parameters.Add("@SoLuong", data.SoLuong);
                    dbCmd.Parameters.Add("@ThongTinBaoHanh", data.ThongTinBaoHanh);
                    dbCmd.Parameters.Add("@NhaSX", data.NhaSX);
                    dbCmd.Parameters.Add("@DonGia", data.DonGia);
                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MatHang_Delete(MatHang data)
        {
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_MatHang_Delete", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add("@MaXe", data.MaXe);

                    dbCmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet Load_Xe()
        {

            DataSet dt = new DataSet();
            using (SqlDataAdapter dbCmd = new SqlDataAdapter("SELECT MaXe,TenXe from Xe", GetConection()))
            {
                dbCmd.Fill(dt);

            }
            return dt;
        }
        public List<MatHang> MatHang_Search(string Search)
        {
            List<MatHang> list = new List<MatHang>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Search_TenXe", GetConection()))
            {
                MatHang obj = new MatHang();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@TenXe", Search));
                SqlDataReader dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.MatHangIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public int Get_SoLuong(string data)
        {

            int SoLuong;
            using (SqlCommand dbCmd = new SqlCommand("sp_Get_SoLuongHang", GetConection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add("@MaXe", data);
                object result = dbCmd.ExecuteScalar();
                SoLuong =Convert.ToInt32(result);
                return SoLuong;
            }
        }
        public  DataSet PhanTrang_Xe(int start,int sodong)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                using (SqlCommand dbCmd = new SqlCommand("SELECT MaXe,TenHangXe,Convert(decimal(18,0),DonGia) AS DonGia,ThongTinBaoHanh,TenXe,NhaSX,SoLuong,TinhTrang FROM Xe", GetConection()))
                {
                    adapter.SelectCommand = dbCmd;
                    adapter.Fill(ds, start, sodong, "Xe");
                    
                }
                return ds;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public int TongSoLuong_Xe()
        {
            

                int SoLuong;
                using (SqlCommand dbCmd = new SqlCommand("sp_TongSLXe", GetConection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    object result = dbCmd.ExecuteScalar();
                    SoLuong = Convert.ToInt32(result);
                    return SoLuong;
                }
            
            
        }
    }
}
