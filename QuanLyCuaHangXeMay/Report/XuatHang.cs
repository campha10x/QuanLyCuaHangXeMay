using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.Report
{
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptXuatHang rpt = new rptXuatHang();
            SqlConnection conn = new SqlConnection("Data Source=.\\SQL2008;Initial Catalog=QUANLYCUAHANGXEMAY;User ID=sa;Password=123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT        Xe.MaXe, Xe.TenHangXe, Xe.TenXe, Xe.NhaSX, PhieuXuat.MaPhieuXuat, CONVERT(VARCHAR, PhieuXuat.NgayXuat, 103) AS NgayXuat, ChiTietPhieuXuat.SLXuat, ChiTietPhieuXuat.DonGiaXuat,   ChiTietPhieuXuat.Thue, ChiTietPhieuXuat.ThanhTien FROM ChiTietPhieuXuat INNER JOIN  PhieuXuat ON ChiTietPhieuXuat.MaPhieuXuat = PhieuXuat.MaPhieuXuat INNER JOIN Xe ON ChiTietPhieuXuat.MaXe = Xe.MaXe WHERE  (YEAR(PhieuXuat.NgayXuat) = '"+textBox1.Text+"')", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
