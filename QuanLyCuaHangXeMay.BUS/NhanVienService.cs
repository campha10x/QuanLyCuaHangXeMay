using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.BUS
{
    public class NhanVienService
    {
        private static NhanVienDAL cmb = new NhanVienDAL();
        public static List<NhanVien> NhanVien_GetByTop(string Top,string Where,string Order)
        {
            return cmb.NhanVien_GetByTop(Top, Where, Order);
        }
        public static bool NhanVien_Insert(NhanVien data)
        {
            return cmb.NhanVien_Insert(data);
        }
        
        public static bool NhanVien_Update(NhanVien data)
        {
            return cmb.NhanVien_Update(data);
        }
        public static bool NhanVien_Delete(NhanVien data)
        {
            return cmb.NhanVien_Delete(data);
        }
        public static List<NhanVien> Check_ID(string ID)
        {
            return cmb.NhanVien_GetByTop("", "MaNhanVien='" + ID + "'","");
        }

        public static List<NhanVien> NhanVien_Search(string Search)
        {
            return cmb.NhanVien_Search(Search);
        }

    }
}
