using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class PhieuXuat
    {
        private string _MaPhieuXuat;

        
        private string _NgayXuat;


        private string _MaNhanVien;


        private string _MaKhachHang;

      
        public string MaPhieuXuat
        {
            get { return _MaPhieuXuat; }
            set { _MaPhieuXuat = value; }
        }
        public string NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }
        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        public string MaKhachHang
        {
            get { return _MaKhachHang; }
            set { _MaKhachHang = value; }
        }
        public PhieuXuat PhieuXuatIDataReader(IDataReader dr)
        {
            PhieuXuat obj = new PhieuXuat();
            obj.MaKhachHang = (dr["MaKhachHang"] is DBNull) ? string.Empty : dr["MaKhachHang"].ToString();
            obj.MaPhieuXuat = (dr["MaPhieuXuat"] is DBNull) ? string.Empty : dr["MaPhieuXuat"].ToString();
            obj.MaNhanVien = (dr["MaNhanVien"] is DBNull) ? string.Empty : dr["MaNhanVien"].ToString();
            obj.NgayXuat = (dr["NgayXuat"] is DBNull) ? string.Empty : dr["NgayXuat"].ToString();
            return obj;
        }
    }
}
