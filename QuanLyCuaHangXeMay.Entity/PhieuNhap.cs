using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class PhieuNhap
    {
        private string _MaPN;


        private string _NgayNhap;



        private string _MaNhanVien;


        private string _MaNhaCungCap;

       
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }
        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        public string MaNhaCungCap
        {
            get { return _MaNhaCungCap; }
            set { _MaNhaCungCap = value; }
        }
        public PhieuNhap PhieuNhapIDataReader(IDataReader dr)
        {
            PhieuNhap obj = new PhieuNhap();
            obj.MaNhaCungCap = (dr["MaNhaCungCap"] is DBNull) ? string.Empty : dr["MaNhaCungCap"].ToString();
            obj.MaNhanVien = (dr["MaNhanVien"] is DBNull) ? string.Empty : dr["MaNhanVien"].ToString();
            obj.NgayNhap = (dr["NgayNhap"] is DBNull) ? string.Empty : dr["NgayNhap"].ToString();
            obj.MaPN = (dr["MaPN"] is DBNull) ? string.Empty : dr["MaPN"].ToString();
            return obj;
        }
    }
}
