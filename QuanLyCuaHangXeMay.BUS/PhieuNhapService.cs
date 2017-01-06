using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay.BUS
{
    public class PhieuNhapService
    {
        private static PhieuNhapDAL cmb = new PhieuNhapDAL();
        public static List<PhieuNhap> PhieuNhap_GetByTop(string Top, string Where, string Order)
        {
            return cmb.PhieuNhap_GetByTop(Top, Where, Order);
        }
        public static bool PhieuNhap_Insert(PhieuNhap data)
        {
            return cmb.PhieuNhap_Insert(data);
        }

        public static bool PhieuNhap_Update(PhieuNhap data)
        {
            return cmb.PhieuNhap_Update(data);
        }
        public static bool PhieuNhap_Delete(PhieuNhap data)
        {
            return cmb.PhieuNhap_Delete(data);
        }
    }
}
