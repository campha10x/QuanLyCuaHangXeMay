using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class Users
    {
        private string _User;


        private string _MatKhauCu;

        private string _Quyen;

       
        private string _MatKhauMoi;
        private string _MaNhanVien;
        public string MatKhauMoi
        {
            get { return _MatKhauMoi; }
            set { _MatKhauMoi = value; }
        }
        public string MatKhauCu
        {
            get { return _MatKhauCu; }
            set { _MatKhauCu = value; }
        }
      

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }
        public Users UsersIDataReader(IDataReader dr)
        {
            Users obj = new Users();
            obj.MaNhanVien = (dr["MaNhanVien"] is DBNull) ? string.Empty : dr["MaNhanVien"].ToString();
            obj.User = (dr["User"] is DBNull) ? string.Empty : dr["User"].ToString();
            obj.MatKhauMoi = (dr["MatKhauMoi"] is DBNull) ? string.Empty : dr["MatKhauMoi"].ToString();
            obj.MatKhauCu = (dr["MatKhauCu"] is DBNull) ? string.Empty : dr["MatKhauCu"].ToString();
            obj.Quyen = (dr["Quyen"] is DBNull) ? string.Empty : dr["Quyen"].ToString();
            return obj;
        }
    }
}
