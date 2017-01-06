using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyCuaHangXeMay.Entity
{
    public class ChiTietPhieuXuat
    {
        private string _MaPX;


        private string _MaXe;

      
      
        private string _SLXuat;

       
        private string _DonGiaXuat;

     
        private string _Thue;
        private string _Thanhtien;

        public string Thanhtien
        {
            get { return _Thanhtien; }
            set { _Thanhtien = value; }
        }

        public string Thue
        {
            get { return _Thue; }
            set { _Thue = value; }
        }
        public string MaPX
        {
            get { return _MaPX; }
            set { _MaPX = value; }
        }
        public string DonGiaXuat
        {
            get { return _DonGiaXuat; }
            set { _DonGiaXuat = value; }
        }
        public string SLXuat
        {
            get { return _SLXuat; }
            set { _SLXuat = value; }
        }
        public string MaXe
        {
            get { return _MaXe; }
            set { _MaXe = value; }
        }

        public ChiTietPhieuXuat ChiTietPhieuXuatIDataReader(IDataReader dr)
        {
            ChiTietPhieuXuat obj = new ChiTietPhieuXuat();
            obj.Thue = (dr["Thue"] is DBNull) ? string.Empty : dr["Thue"].ToString();
            obj.MaPX = (dr["MaPhieuXuat"] is DBNull) ? string.Empty : dr["MaPhieuXuat"].ToString();
            obj.DonGiaXuat = (dr["DonGiaXuat"] is DBNull) ? string.Empty : dr["DonGiaXuat"].ToString();
            obj.SLXuat = (dr["SLXuat"] is DBNull) ? string.Empty : dr["SLXuat"].ToString();
            obj.MaXe = (dr["MaXe"] is DBNull) ? string.Empty : dr["MaXe"].ToString();
            obj.Thanhtien = (dr["Thanhtien"] is DBNull) ? string.Empty : dr["Thanhtien"].ToString();
            return obj;
        }
    }
}
