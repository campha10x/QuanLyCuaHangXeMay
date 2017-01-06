using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyCuaHangXeMay.Report
{
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            rptTonKho rpt = new rptTonKho();
            SqlConnection conn = new SqlConnection("Data Source=.\\SQL2008;Initial Catalog=QUANLYCUAHANGXEMAY;User ID=sa;Password=123456");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Xe     ", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
