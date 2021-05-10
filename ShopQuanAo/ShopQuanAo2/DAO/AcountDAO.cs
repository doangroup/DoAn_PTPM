using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ShopQuanAo2.DTO;
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
        public Acount getAcountByUsername(string ten)
        {
            DataTable data = dp.ExcuteQuery("select * from TaiKhoan where TenDN = '" + ten + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Acount(item);
            }
            return null;
        }
        
        public DataTable loadAccount()
        {
            return dp.ExcuteQuery("select TenDN, LoaiTK from TaiKhoan");
        }
        public DataTable loadTypeAccount()
        {
            return dp.ExcuteQuery("select LoaiTK from TaiKhoan");
        }
        public List<Acount> findAccount(string tenTK)
        {
            List<Acount> lstAccount = new List<Acount>();
            string sql = "select * from TaiKhoan where TenDN = N'" + tenTK + "'";
            DataTable dt = dp.ExcuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Acount acc = new Acount(item);
                lstAccount.Add(acc);
            }
            return lstAccount;
        }

        public bool deleteAccount(string tenDN)
        {

            string sqlDelete = "delete from TaiKhoan where TenDN = N'" + tenDN + "'";
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
        public bool addAccount(string tenDN,string matKhau, int loaiTK)
        {

            string sqlAdd = "insert into TaiKhoan values (N'" + tenDN + "','" + matKhau + "',"+loaiTK+")";
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
        public bool repairAccount(string tenDN, string password, int type)
        {
            string sqlAdd = "update TaiKhoan set MatKhau = '" + password + "', LoaiTK = " + type + " where TenDN = '" + tenDN + "'";
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
        public bool repairPassAccount(string tenDN, string password)
        {
            string sqlAdd = "update TaiKhoan set MatKhau = '" + password + "' where TenDN = '" + tenDN + "'";
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
        public bool checkPassword(string userName,string passWord)
        {
            string sqlCheck = "select * from TaiKhoan where TenDN = '" + userName + "' and MatKhau = '" + passWord + "'";
            DataTable rs = dp.ExcuteQuery(sqlCheck);
            if (rs.Rows.Count > 0)
            {
                return true;
                // nếu = true thì đối mật khẩu
            }
            else
            {
                return false;
                //sai mật khẩu cũ
            }
        }
    }
}
