using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Entity;
using QuanLyCuaHangXeMay.DAL;
namespace QuanLyCuaHangXeMay.BUS
{
   public class ChiTietPhieuNhapService
    {
        private static ChiTietPhieuNhapDAL cmb = new ChiTietPhieuNhapDAL();
        public static List<ChiTietPhieuNhap> ChiTietPhieuNhap_GetByTop(string Top, string Where, string Order)
        {
            return cmb.ChiTietPhieuNhap_GetByTop(Top, Where, Order);
        }
        public static bool ChiTietPhieuNhap_Insert(ChiTietPhieuNhap data)
        {
            return cmb.ChiTietPhieuNhap_Insert(data);
        }

        public static bool ChiTietPhieuNhap_Update(ChiTietPhieuNhap data)
        {
            return cmb.ChiTietPhieuNhap_Update(data);
        }
        public static bool ChiTietPhieuNhap_Delete(ChiTietPhieuNhap data)
        {
            return cmb.ChiTietPhieuNhap_Delete(data);
        }
    }
}
