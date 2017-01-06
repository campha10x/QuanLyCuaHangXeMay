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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace QuanLyCuaHangXeMay.Report
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //using (SqlCommand dbCmd = new SqlCommand("sp_Get_SoLuongHang", GetConection()))
            //{
            //    dbCmd.CommandType = CommandType.StoredProcedure;
            //    dbCmd.Parameters.Add("@MaXe", data);
            //    object result = dbCmd.ExecuteScalar();
            //    SoLuong = Convert.ToInt32(result);
            //    return SoLuong;
            //}
          

            //dptDoanhThu cryRpt = new dptDoanhThu();
            //cryRpt.Load(@"D:\BAI TAP C# WINFORM\QuanLyCuaHangXeMay\QuanLyCuaHangXeMay\Report\dptDoanhThu.rpt");

            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //ParameterFieldDefinition crParameterFieldDefinition;
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //crParameterDiscreteValue.Value = tienmua;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["@TienMua"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;
            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            //crParameterDiscreteValue.Value = tienban;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["@TienBan"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;
            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();

          //  crystalReportViewer1.ReportSource = rpt;






            //int tienmua = 0, tienban = 0, doanhthu;

            dptDoanhThu rpt = new dptDoanhThu();
            SqlConnection conn = new SqlConnection("Data Source=.\\SQL2008;Initial Catalog=QUANLYCUAHANGXEMAY;User ID=sa;Password=123456");
            conn.Open();

            //SqlCommand dbCmd = new SqlCommand("SELECT SUM(ThanhTien)as SoTienBan from PhieuXuat,ChiTietPhieuXuat where YEAR(NgayXuat)=" + textBox1.Text + " and MONTH(NgayXuat)=" + textBox2.Text + "", conn);
            //object obj = dbCmd.ExecuteScalar();
            //if (obj != DBNull.Value)
            //    tienban = Convert.ToInt32(obj);

            //SqlCommand dbCmd1 = new SqlCommand("SELECT SUM(ThanhTien)as SoTienMua from PhieuNhap,ChiTietPhieuNhap where YEAR(NgayNhap)=" + textBox1.Text + " and MONTH(NgayNhap)=" + textBox2.Text + "", conn);
            //object obj1 = dbCmd1.ExecuteScalar();
            //if (obj1 != DBNull.Value)
            //    tienmua = Convert.ToInt32(obj1);

            //doanhthu = tienban - tienmua;


            //ReportDocument myDataReport = new ReportDocument();
            //myDataReport.Load(@"D:\BAI TAP C# WINFORM\QuanLyCuaHangXeMay\QuanLyCuaHangXeMay\Report\dptDoanhThu.rpt");

            //myDataReport.SetParameterValue("TienMua", tienmua);
            //myDataReport.SetParameterValue("TienBan", tienban);
            //myDataReport.SetParameterValue("DoanhThu", doanhthu);


            SqlDataAdapter dap = new SqlDataAdapter("SELECT DISTINCT ChiTietPhieuXuat.MaPhieuXuat,NgayXuat,Xe.MaXe,Xe.TenXe,ChiTietPhieuXuat.SLXuat AS Soluong,CONVERT(DECIMAL(18,0),(ChiTietPhieuXuat.SLXuat*(ChiTietPhieuNhap.DonGiaNhap+(ChiTietPhieuNhap.Thue*0.01*ChiTietPhieuNhap.DonGiaNhap)))) AS GiaNhap,CONVERT(DECIMAL(18,0),(ChiTietPhieuXuat.SLXuat*(DonGiaXuat+(ChiTietPhieuXuat.DonGiaXuat*ChiTietPhieuXuat.Thue*0.01)))) as GiaBan,CONVERT(DECIMAL(18,0),(ChiTietPhieuXuat.SLXuat*(DonGiaXuat+(ChiTietPhieuXuat.DonGiaXuat*ChiTietPhieuXuat.Thue*0.01))-(ChiTietPhieuXuat.SLXuat*(ChiTietPhieuNhap.DonGiaNhap+(ChiTietPhieuNhap.Thue*0.01*ChiTietPhieuNhap.DonGiaNhap)))))as TienLai FROM dbo.ChiTietPhieuNhap,dbo.ChiTietPhieuXuat,dbo.PhieuXuat,dbo.PhieuNhap,Xe where ChiTietPhieuXuat.MaXe=ChiTietPhieuNhap.MaXe and ChiTietPhieuXuat.MaXe=Xe.MaXe  and YEAR(NgayXuat)=" + textBox1.Text + " and MONTH(NgayXuat)=" + textBox2.Text + "", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
          // crystalReportViewer1.ReportSource = myDataReport;

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
//            SELECT ChiTietPhieuXuat.MaPhieuXuat,NgayXuat,Xe.MaXe,Xe.TenXe,ChiTietPhieuXuat.SLXuat AS Soluong,(ChiTietPhieuXuat.SLXuat*(ChiTietPhieuNhap.DonGiaNhap+(ChiTietPhieuNhap.Thue*0.01*ChiTietPhieuNhap.DonGiaNhap)))as GiaNhap,(ChiTietPhieuXuat.SLXuat*(DonGiaXuat+(ChiTietPhieuXuat.DonGiaXuat*ChiTietPhieuXuat.Thue*0.01))) as GiaBan,(ChiTietPhieuXuat.SLXuat*(DonGiaXuat+(ChiTietPhieuXuat.DonGiaXuat*ChiTietPhieuXuat.Thue*0.01))-(ChiTietPhieuXuat.SLXuat*(ChiTietPhieuNhap.DonGiaNhap+(ChiTietPhieuNhap.Thue*0.01*ChiTietPhieuNhap.DonGiaNhap))))
//FROM dbo.ChiTietPhieuNhap,dbo.ChiTietPhieuXuat,dbo.PhieuXuat,dbo.PhieuNhap,Xe
//where ChiTietPhieuXuat.MaXe=ChiTietPhieuNhap.MaXe and ChiTietPhieuXuat.MaXe=Xe.MaXe

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
