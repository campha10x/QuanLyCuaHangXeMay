using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class KhachHang
    {
        private string _MaKH;

      
        private string _TenKH;

       
        private string _DiaChi;

      
        private string _DienThoai;

      
        private string _Email;
        private string _NgaySinh;
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        public KhachHang KhachHangIDataReader(IDataReader dr)
        {
            KhachHang obj = new KhachHang();
            obj.DiaChi = (dr["DiaChi"] is DBNull) ? string.Empty : dr["DiaChi"].ToString();
            obj.DienThoai = (dr["DienThoai"] is DBNull) ? string.Empty : dr["DienThoai"].ToString();
            obj.Email = (dr["Email"] is DBNull) ? string.Empty : dr["Email"].ToString();
            obj.TenKH = (dr["TenKH"] is DBNull) ? string.Empty : dr["TenKH"].ToString();
            obj.MaKH = (dr["MaKH"] is DBNull) ? string.Empty : dr["MaKH"].ToString();
            obj.NgaySinh = (dr["NgaySinh"] is DBNull) ? string.Empty : dr["NgaySinh"].ToString();
            obj.TinhTrang = (dr["TinhTrang"] is DBNull) ? string.Empty : dr["TinhTrang"].ToString();
            return obj;
        }
    }
}
