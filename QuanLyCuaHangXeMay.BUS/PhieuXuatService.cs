using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay.BUS
{
    public class PhieuXuatService
    {
        private static PhieuXuatDAL cmb = new PhieuXuatDAL();
        public static List<PhieuXuat> PhieuXuat_GetByTop(string Top, string Where, string Order)
        {
            return cmb.PhieuXuat_GetByTop(Top, Where, Order);
        }
        public static bool PhieuXuat_Insert(PhieuXuat data)
        {
            return cmb.PhieuXuat_Insert(data);
        }
        public static List<PhieuXuat> PhieuXuat_Search(string Search)
        {
            return cmb.PhieuXuat_Search(Search);
        }
        public static bool PhieuXuat_Update(PhieuXuat data)
        {
            return cmb.PhieuXuat_Update(data);
        }
    }
}
