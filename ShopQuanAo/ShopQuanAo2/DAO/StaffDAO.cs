using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DTO;
using System.Data;
using System.Data.SqlClient;
namespace ShopQuanAo2.DAO
{
   public class StaffDAO
    {
       DataProvider dp = new DataProvider();
       public StaffDAO() { }

       public List<Staff> loadStaff()
       {
           List<Staff> lstStaff = new List<Staff>();
           string sqlStaff = "select * from NhanVien";
           DataTable dt = dp.ExcuteQuery(sqlStaff);
           foreach (DataRow item in dt.Rows)
           {
               Staff st = new Staff(item);
               lstStaff.Add(st);
           }
           return lstStaff;
       }
       public List<Staff> findStaff(string tenNV)
       {
           List<Staff> lstStaff = new List<Staff>();
           string sqlStaff = "select * from NhanVien where TenNV = '" + tenNV + "'";
           DataTable dt = dp.ExcuteQuery(sqlStaff);
           foreach (DataRow item in dt.Rows)
           {
               Staff st = new Staff(item);
               lstStaff.Add(st);
           }
           return lstStaff;
       }
       public bool deleteStaff(int maNV)
       {
           try
           {
               string sqlDelete = "delete from NhanVien where MaNV = " + maNV;
               int rs = dp.ExcuteNonQuery(sqlDelete);
               return rs > 0 ? true : false;
           }
           catch(Exception e)
           {
               e.Message.ToString();
               return false;
           }
       }
    }

}
