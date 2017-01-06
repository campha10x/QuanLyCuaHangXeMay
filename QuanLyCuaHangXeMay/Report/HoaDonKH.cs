using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay
{//
    public partial class HoaDonKH : Form
    {
        public static string mahd;
        public static SqlConnection conn = new SqlConnection("Data Source=.\\SQL2008;Initial Catalog=QUANLYCUAHANGXEMAY;User ID=sa;Password=123456");
        public HoaDonKH()
        {
            InitializeComponent();
        }

        private void HoaDonKH_Load(object sender, EventArgs e)
        {

            Report.rptHoaDonKhachHang rpt = new Report.rptHoaDonKhachHang();

            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT KhachHang.MaKH, KhachHang.TenKH, KhachHang.DiaChi, KhachHang.DienThoai, KhachHang.Email, KhachHang.NgaySinh, ChiTietPhieuXuat.SLXuat, ChiTietPhieuXuat.Thue, ChiTietPhieuXuat.ThanhTien, Xe.TenXe, ChiTietPhieuXuat.DonGiaXuat FROM KhachHang INNER JOIN PhieuXuat ON KhachHang.MaKH = PhieuXuat.MaKhachHang INNER JOIN ChiTietPhieuXuat ON PhieuXuat.MaPhieuXuat = ChiTietPhieuXuat.MaPhieuXuat INNER JOIN Xe ON ChiTietPhieuXuat.MaXe = Xe.MaXe", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rptHoaDonKHrpt2_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void HoaDonKH_Load_1(object sender, EventArgs e)
        {
            Report.rptHoaDonKhachHang rpt = new Report.rptHoaDonKhachHang();

            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT DISTINCT PhieuXuat.MaPhieuXuat,MaKH,TenKH,DiaChi,DienThoai,Email,NgaySinh,TenXe,SLXuat,Thue,DonGiaXuat,ThanhTien FROM dbo.PhieuXuat,dbo.ChiTietPhieuXuat,dbo.KhachHang,Xe WHERE PhieuXuat.MaPhieuXuat=ChiTietPhieuXuat.MaPhieuXuat and PhieuXuat.MaPhieuXuat='"+mahd+"' and Xe.MaXe=ChiTietPhieuXuat.MaXe and KhachHang.MaKH=PhieuXuat.MaKhachHang ", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer2.ReportSource = rpt;
            conn.Close();
        }

      
    }
}
