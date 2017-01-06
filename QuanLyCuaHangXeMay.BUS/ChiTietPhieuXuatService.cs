using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Entity;
using QuanLyCuaHangXeMay.DAL;
namespace QuanLyCuaHangXeMay.BUS
{
    public class ChiTietPhieuXuatService
    {
        private static ChiTietPhieuXuatDAL cmb = new ChiTietPhieuXuatDAL();
        public static List<ChiTietPhieuXuat> ChiTietPhieuXuat_GetByTop(string Top, string Where, string Order)
        {
            return cmb.ChiTietPhieuXuat_GetByTop(Top, Where, Order);
        }
        public static List<ChiTietPhieuXuat> ChiTietPhieuXuat_Search(string Top, string Where, string Order)
        {
            return cmb.ChiTietPhieuXuat_GetByTop(Top, Where, Order);
        }
        public static bool ChiTietPhieuXuat_Insert(ChiTietPhieuXuat data)
        {
            return cmb.ChiTietPhieuXuat_Insert(data);
        }

        public static bool ChiTietPhieuXuat_Update(ChiTietPhieuXuat data)
        {
            return cmb.ChiTietPhieuXuat_Update(data);
        }
        public static bool ChiTietPhieuXuat_Delete(ChiTietPhieuXuat data)
        {
            return cmb.ChiTietPhieuXuat_Delete(data);
        }
    }
}
