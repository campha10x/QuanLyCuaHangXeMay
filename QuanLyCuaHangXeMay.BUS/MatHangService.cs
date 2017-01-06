using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
using System.Data;
namespace QuanLyCuaHangXeMay.BUS
{
    public class MatHangService
    {
        private static MatHangDAL cmb = new MatHangDAL();
        public static List<MatHang> MatHang_GetByTop(string Top, string Where, string Order)
        {
            return cmb.MatHang_GetByTop(Top, Where, Order);
        }
        public static bool MatHang_Insert(MatHang data)
        {
            return cmb.MatHang_Insert(data);
        }

        public static bool MatHang_Update(MatHang data)
        {
            return cmb.MatHang_Update(data);
        }
        public static bool MatHang_Delete(MatHang data)
        {
            return cmb.MatHang_Delete(data);
        }
        public static DataSet Load_Xe()
        {
            return cmb.Load_Xe();
        }
        public static List<MatHang> Check_ID(string ID)
        {
            return cmb.MatHang_GetByTop("", "MaXe='" + ID + "'", "");
        }

        public static List<MatHang> MatHang_Search(string Search)
        {
            return cmb.MatHang_Search(Search);
        }
        public static int Get_SoLuong(string MaHang)
        {
            return cmb.Get_SoLuong(MaHang);
        }
         public  static DataSet PhanTrang_Xe(int start,int sodong)
        {
            return cmb.PhanTrang_Xe(start, sodong);
        }
         public static int TongSoLuong_Xe()
         {
             return cmb.TongSoLuong_Xe();
         }

    }
}
