using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo2.DTO;
using System.Data;

namespace ShopQuanAo2.DAO
{
   public class BillStaticalDAO
    {
        DataProvider dp = new DataProvider();
        public DataTable loadBillStatical()
        {
            return dp.ExcuteQuery("exec LoadHDThongKe");
        }
        public List<BillStatical> loadReportBill(string ngayBD, string ngayKT)
        {
            List<BillStatical> lstBillStatical = new List<BillStatical>();
            string sqlBill = "set dateformat DMY exec ThongKeHDTheoNgay '" + ngayBD + "','" + ngayKT + "'";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                BillStatical billPay = new BillStatical(item);
                lstBillStatical.Add(billPay);
            }
            return lstBillStatical;
        }
        public List<BillStatical> loadReportBill2()
        {
            List<BillStatical> lstBillStatical = new List<BillStatical>();
            string sqlBill = "set dateformat DMY exec ThongKeHDTheoNgay2";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                BillStatical billPay = new BillStatical(item);
                lstBillStatical.Add(billPay);
            }
            return lstBillStatical;
        }
    }
}
