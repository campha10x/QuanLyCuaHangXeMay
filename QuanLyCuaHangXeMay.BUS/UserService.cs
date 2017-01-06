using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay.BUS
{
    public class UserService
    {
        private static UserDAL cmb = new UserDAL();
        public static List<Users> Check_Login(string TaiKhoan,string MatKhau)
        {
            return cmb.Users_GetByTop("", "[User]='" + TaiKhoan + "'AND [MatKhauMoi]='" + MatKhau + "'","");
        }
        public static List<Users> Check_Password(string MatKhau)
        {
            return cmb.Users_GetByTop("", "[MatKhauMoi]='" + MatKhau + "'", "");
        }
        public static string Get_MaNV(string User)
        {
            return cmb.Get_MaNV(User);
        }
        public static string Get_Quyen(string User)
        {
            return cmb.Get_Quyen(User);
        }
        public static bool User_Update(Users data)
        {
            return cmb.User_Update(data);
        }
      
    }
}
