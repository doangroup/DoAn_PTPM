using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ShopQuanAo2.DAO
{
    public class AcountDAO
    {
        DataProvider dp = new DataProvider();
        public AcountDAO()
        {

        }
        public bool login(string userName, string passWord)
        {

            string sqlAcount = "select TenDN, MatKhau, LoaiTK from TaiKhoan where TenDN = '" + userName + "' and MatKhau = '" + passWord + "'";
            DataTable dt = dp.ExcuteQuery(sqlAcount);
            if (dt.Rows.Count > 0)
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
