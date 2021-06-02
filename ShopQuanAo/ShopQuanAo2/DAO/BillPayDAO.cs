using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DAO
{
    public class BillPayDAO
    {
        DataProvider dp = new DataProvider();
        public List<BillPay> loadBillPay(int maHD)
        {
            List<BillPay> lstBillPay = new List<BillPay>();
            string sqlBill = "exec ThanhToan " + maHD;
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                BillPay billPay = new BillPay(item);
                lstBillPay.Add(billPay);

            }
            return lstBillPay;
        }
        public DataTable loadBillPay3(int maHD)
        {
            DataSet ds = new DataSet();
            string sqlBill = "exec ThanhToan " + maHD;
            SqlDataAdapter da = new SqlDataAdapter(sqlBill,dp.sql);
            da.Fill(ds, "dsKhoa");
            
            return ds.Tables["dsKhoa"];
        }
        public DataTable loadBillPay2(int maHD)
        {

            string sqlBill = "exec ThanhToan " + maHD;
     
            return dp.ExcuteQuery(sqlBill);
        }
    }
}
