using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
   public  class ChiTietPhieuNhap
    {
        private string _MaPN;

    
        private string _MaHang;

       
        private string _SLNhap;

     
        private string _DonGiaNhap;

       
        private string _Thue;
        private string _ThanhTien;

        public string ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        public string SLNhap
        {
            get { return _SLNhap; }
            set { _SLNhap = value; }
        }
        public string Thue
        {
            get { return _Thue; }
            set { _Thue = value; }
        }
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }
        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }
        public string DonGiaNhap
        {
            get { return _DonGiaNhap; }
            set { _DonGiaNhap = value; }
        }
       public ChiTietPhieuNhap ChiTietPhieuNhapIDataReader(IDataReader dr)
        {
            ChiTietPhieuNhap obj = new ChiTietPhieuNhap();
          obj.DonGiaNhap = (dr["DonGiaNhap"] is DBNull) ? string.Empty : dr["DonGiaNhap"].ToString();
          obj.Thue = (dr["Thue"] is DBNull) ? string.Empty : dr["Thue"].ToString();
          obj.SLNhap = (dr["SLNhap"] is DBNull) ? string.Empty : dr["SLNhap"].ToString();
          obj.MaHang = (dr["MaXe"] is DBNull) ? string.Empty : dr["MaXe"].ToString();
          obj.MaPN = (dr["MaPN"] is DBNull) ? string.Empty : dr["MaPN"].ToString();
          obj.ThanhTien = (dr["ThanhTien"] is DBNull) ? string.Empty : dr["ThanhTien"].ToString();
          return obj;
        }
       }
}
