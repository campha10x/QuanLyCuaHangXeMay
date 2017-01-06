using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class NhanVien
    {
       
        private string _MaNhanVien;

       
        private string _TenNhanVien;


        private string _NgaySinh;

       

      
        private string _GioiTinh;

     
        private string _DiaChi;

      
        private string _DienThoai;

    
        private string _ChucVu;

       
        private string _LuongCoBan;
        private string _Ngayvaolam;

     
        private string _Luong;

        public string Luong
        {
            get { return _Luong; }
            set { _Luong = value; }
        }
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string Ngayvaolam
        {
            get { return _Ngayvaolam; }
            set { _Ngayvaolam = value; }
        }
        public string LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }
        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; }
        }
     
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        public NhanVien NhanVienIDataReader(IDataReader dr)
        {
            NhanVien obj = new NhanVien();
            obj.LuongCoBan = (dr["LuongCoBan"] is DBNull) ? string.Empty : dr["LuongCoBan"].ToString();
            obj.MaNhanVien = (dr["MaNhanVien"] is DBNull) ? string.Empty : dr["MaNhanVien"].ToString();
            obj.TenNhanVien = (dr["TenNhanVien"] is DBNull) ? string.Empty : dr["TenNhanVien"].ToString();
            obj.NgaySinh = (dr["NgaySinh"] is DBNull) ? string.Empty : dr["NgaySinh"].ToString();
            obj.GioiTinh = (dr["GioiTinh"] is DBNull) ? string.Empty : dr["GioiTinh"].ToString();
            obj.DiaChi = (dr["DiaChi"] is DBNull) ? string.Empty : dr["DiaChi"].ToString();
            obj.DienThoai = (dr["DienThoai"] is DBNull) ? string.Empty : dr["DienThoai"].ToString();
            obj.ChucVu = (dr["ChucVu"] is DBNull) ? string.Empty : dr["ChucVu"].ToString();
            obj.Ngayvaolam = (dr["Ngayvaolam"] is DBNull) ? string.Empty : dr["Ngayvaolam"].ToString();
            obj.Luong = (dr["Luong"] is DBNull) ? string.Empty : dr["Luong"].ToString();
            return obj;
        }
    }
}
