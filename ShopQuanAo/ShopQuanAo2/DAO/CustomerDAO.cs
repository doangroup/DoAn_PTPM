using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DAO
{
   public class CustomerDAO
    {
        DataProvider dp = new DataProvider();
        public List<Customer> loadCustomer()
        {
            List<Customer> lstCustomer = new List<Customer>();
            string sql = "select * from KhachHang";
            DataTable dt = dp.ExcuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Customer ct = new Customer(item);
                lstCustomer.Add(ct);
            }
            return lstCustomer;
        }

        public List<Customer> findCustomer(string tenKH)
        {
            List<Customer> lstCustomer = new List<Customer>();
            string sql = "select * from KhachHang where TenKH = N'" + tenKH + "'";
            DataTable dt = dp.ExcuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Customer ct = new Customer(item);
                lstCustomer.Add(ct);
            }
            return lstCustomer;
        }

        public List<Customer> findBillByCustomer(string tenKH)
        {
            List<Customer> lstCustomer = new List<Customer>();
            string sql = "exec findKHByHD N'" + tenKH + "'";
            DataTable dt = dp.ExcuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Customer ct = new Customer(item);
                lstCustomer.Add(ct);
            }
            return lstCustomer;
        }
        public bool deleteCustomer(int maKH)
        {

            string sqlDelete = "delete from KhachHang where MaKH = " + maKH;
            int rs = dp.ExcuteNonQuery(sqlDelete);
            if (rs > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool addCustomer(string tenKH, string diaChi, string sDT)
        {

            string sqlAdd = "insert into KhachHang values (N'" + tenKH + "',N'" + diaChi+ "','" + sDT + "','1')";
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool repairCustomer(int maKH, string tenKH, string diaChi, string sDT)
        {
            string sqlAdd = "update KhachHang set TenKH = N'" + tenKH + "', DiaChi = N'" + diaChi + "',SDT = '" + sDT + "' where MaKH = " + maKH;
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool checkPrimarykey(int maKH)
        {
            string sqlCheck = "select * from KhachHang where MaKH = " + maKH;
            DataTable rs = dp.ExcuteQuery(sqlCheck);
            if (rs.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
