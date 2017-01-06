using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay.DAL
{
    public class SqlDataProvider
    {
        public static SqlConnection connection;
        public SqlDataProvider()
        {
            if(connection==null)
            {
                connection = new SqlConnection("Data Source=.\\SQL2008;Initial Catalog=QUANLYCUAHANGXEMAY;User ID=sa;Password=123456");
            }
        }
        public static SqlConnection GetConection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
                return connection;
        }
    }
}
