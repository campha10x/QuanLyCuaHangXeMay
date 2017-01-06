using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Entity
{
    public class NhaCungCap
    {
        private string _MaNhaCC;

       
        private string _TenNhaCC;

      
        private string _DiaChi;

      
        private string _DienThoai;

      
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string MaNhaCC
        {
            get { return _MaNhaCC; }
            set { _MaNhaCC = value; }
        }
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string TenNhaCC
        {
            get { return _TenNhaCC; }
            set { _TenNhaCC = value; }
        }
        public NhaCungCap NhaCungCapIDataReader(IDataReader dr)
        {
            NhaCungCap obj = new NhaCungCap();
            obj.DiaChi = (dr["DiaChi"] is DBNull) ? string.Empty : dr["DiaChi"].ToString();
            obj.TenNhaCC = (dr["TenNhaCC"] is DBNull) ? string.Empty : dr["TenNhaCC"].ToString();
            obj.MaNhaCC = (dr["MaNhaCC"] is DBNull) ? string.Empty : dr["MaNhaCC"].ToString();
            obj.DienThoai = (dr["DienThoai"] is DBNull) ? string.Empty : dr["DienThoai"].ToString();
            obj.Email = (dr["Email"] is DBNull) ? string.Empty : dr["Email"].ToString();
            return obj;
        }
    }
}
