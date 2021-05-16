using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DTO;
using System.Data;
namespace ShopQuanAo2.DAO
{
    public class BillCustomerDAO
    {
        DataProvider dp = new DataProvider();
        public DataTable loadBillCustomer(int maHD)
        {
            
            string sqlCTHD = "exec HoaDonKH " + maHD;
            DataTable data = dp.ExcuteQuery(sqlCTHD);
            
            return data;
        }
    }
}
