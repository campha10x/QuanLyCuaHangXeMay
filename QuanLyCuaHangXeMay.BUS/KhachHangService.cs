using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Entity;
using QuanLyCuaHangXeMay.DAL;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.BUS
{
    public class KhachHangService
    {
      
        private static KhachHangDAL cmb = new KhachHangDAL();
        public static List<KhachHang> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            return cmb.KhachHang_GetByTop(Top, Where, Order);
        }
        public static List<KhachHang> KhachHang_Search(string Search)
        {
            return cmb.KhachHang_Search(Search);
        }
        public static bool KhachHang_Insert(KhachHang data)
        {
            return cmb.KhachHang_Insert(data);
        }

        public static bool KhachHang_Update(KhachHang data)
        {
            return cmb.KhachHang_Update(data);
        }
        public static bool KhachHang_Delete(KhachHang data)
        {
            return cmb.KhachHang_Delete(data);

        }
        public static List<KhachHang> Check_ID(string ID)
        {
            return cmb.KhachHang_GetByTop("", "MaKH='" + ID + "'", "");
        }
        public static SqlDataReader Select_TenKH()
        {
            return cmb.Select_TenKH();
        }
        public static DataSet PhanTrang_KhachHang(int start, int sodong)
        {
            return cmb.PhanTrang_KhachHang(start, sodong);
        }
        public static int TongSoLuong_KhachHang()
        {
            return cmb.TongSoLuong_KhachHang();
        }
       
    }
}
