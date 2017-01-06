using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangXeMay.Entity;
using QuanLyCuaHangXeMay.DAL;
using System.Data;
namespace QuanLyCuaHangXeMay.BUS
{
   public class NhaCungCapService
    {
       private static NhaCungCapDAL cmb = new NhaCungCapDAL();
       public static List<NhaCungCap> NhaCungCap_GetByTop(string Top, string Where, string Order)
        {
            return cmb.NhaCungCap_GetByTop(Top, Where, Order);
        }
       public static bool NhaCungCap_Insert(NhaCungCap data)
        {
            return cmb.NhaCungCap_Insert(data);
        }

       public static bool NhaCungCap_Update(NhaCungCap data)
        {
            return cmb.NhaCungCap_Update(data);
        }
       public static bool NhaCungCap_Delete(NhaCungCap data)
        {
            return cmb.NhaCungCap_Delete(data);
        }
       public static List<NhaCungCap> Check_ID(string ID)
       {
           return cmb.NhaCungCap_GetByTop("", "MaNhaCC='" + ID + "'", "");
       }
          public static DataSet Load_NhaCC()
       {
           return cmb.Load_NhaCC();
       }

          public static List<NhaCungCap> NhaCungCap_Search(string Search)
          {
              return cmb.NhaCungCap_Search(Search);
          }
          public static DataSet PhanTrang_NhaCungCap(int start, int sodong)
          {
              return cmb.PhanTrang_NhaCungCap(start, sodong);
          }
          public static int TongSoLuong_NhaCungCap()
          {
              return cmb.TongSoLuong_NhaCungCap();
          }
    }
}
