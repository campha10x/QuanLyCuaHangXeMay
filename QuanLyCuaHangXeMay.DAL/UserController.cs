using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay.DAL
{
    public class UserDAL:SqlDataProvider
    {
       public List<Users> Users_GetByTop(string Top,string Where,string Order)
       {
        List<Users> list = new List<Users>();
        using(SqlCommand dbCmd=new SqlCommand("sp_Users_getByTop",GetConection()))
        {
            Users obj=new Users();
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
            dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
            dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
            SqlDataReader dr = dbCmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    list.Add(obj.UsersIDataReader(dr));
                }
            }
            dr.Close();
            obj = null;

        }
             return list;
        }
       public string Get_MaNV(string data)
       {
         
               string MaNV;
               using (SqlCommand dbCmd = new SqlCommand("sp_Get_MaNV", GetConection()))
               {
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@User", data);
                   object result= dbCmd.ExecuteScalar();
                   MaNV = result.ToString();
                   return MaNV;
               }   
       }
       public string Get_Quyen(string data)
       {

           string Quyen;
           using (SqlCommand dbCmd = new SqlCommand("sp_Get_Quyen", GetConection()))
           {
               dbCmd.CommandType = CommandType.StoredProcedure;
               dbCmd.Parameters.Add("@User", data);
               object result = dbCmd.ExecuteScalar();
               Quyen = result.ToString();
               return Quyen;
           }
       }
       public bool User_Update(Users data)
       {
           try
           {
               using (SqlCommand dbCmd = new SqlCommand("sp_Users_Update", GetConection()))
               {
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@User", data.User);
                   dbCmd.Parameters.Add("@MatKhauCu", data.MatKhauCu);
                   dbCmd.Parameters.Add("@MatKhauMoi", data.MatKhauMoi);
                 //  dbCmd.Parameters.Add("@Quyen", data.Quyen);
               //    dbCmd.Parameters.Add("@MaNhanVien", data.MaNhanVien);
                   dbCmd.ExecuteNonQuery();

               }
               return true;
           }
           catch(Exception e)
           {
               return false;
           }
       }
    }
}
