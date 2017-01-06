using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class MatHang
    {
        private string _MaXe;

        public string MaXe
        {
            get { return _MaXe; }
            set { _MaXe = value; }
        }



        private string _TenHangXe;

        public string TenHangXe
        {
            get { return _TenHangXe; }
            set { _TenHangXe = value; }
        }




        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }



        private string _ThongTinBaoHanh;

        public string ThongTinBaoHanh
        {
            get { return _ThongTinBaoHanh; }
            set { _ThongTinBaoHanh = value; }
        }



        private string _TenXe;

        public string TenXe
        {
            get { return _TenXe; }
            set { _TenXe = value; }
        }



        private string _NhaSX;

        public string NhaSX
        {
            get { return _NhaSX; }
            set { _NhaSX = value; }
        }



        private string _DonGia;

        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private string _TinhTrang;

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
     
        public MatHang MatHangIDataReader(IDataReader dr)
        {
            MatHang obj = new MatHang();
            obj.MaXe = (dr["MaXe"] is DBNull) ? string.Empty : dr["MaXe"].ToString();
            obj.TenHangXe = (dr["TenHangXe"] is DBNull) ? string.Empty : dr["TenHangXe"].ToString();
            obj.SoLuong = (dr["SoLuong"] is DBNull) ? string.Empty : dr["SoLuong"].ToString();
            obj.ThongTinBaoHanh = (dr["ThongTinBaoHanh"] is DBNull) ? string.Empty : dr["ThongTinBaoHanh"].ToString();
            obj.TenXe = (dr["TenXe"] is DBNull) ? string.Empty : dr["TenXe"].ToString();
            obj.NhaSX = (dr["NhaSX"] is DBNull) ? string.Empty : dr["NhaSX"].ToString();
            obj.DonGia = (dr["DonGia"] is DBNull) ? string.Empty : dr["DonGia"].ToString();
            obj.TinhTrang = (dr["TinhTrang"] is DBNull) ? string.Empty : dr["TinhTrang"].ToString();
            return obj;
        }
    }
}
