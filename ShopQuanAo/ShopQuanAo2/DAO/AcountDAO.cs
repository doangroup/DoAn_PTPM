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
        public List<Acount> loadAccount()
        {
            List<Acount> lstAccount = new List<Acount>();
            string sql = "select * from TaiKhoan";
            DataTable dt = dp.ExcuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Acount acc = new Acount(item);
                lstAccount.Add(acc);
            }
            return lstAccount;
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
        //public bool addAccount(string tenDN,string  int loaiTK)
        //{

        //    string sqlAdd = "insert into TaiKhoan values (N'"+tenDN+"','"+mat+"')";
        //    int rs = dp.ExcuteNonQuery(sqlAdd);
        //    if (rs > 0)
        //    {
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool repairAccount(string tenDN, string )
        //{
        //    string sqlAdd = "update SanPham set MaDM = " + maDM + ", TenSP = N'" + tenSP + "',SoLuong = " + soLuong + ", DonGia = " + donGia + ",GhiChu = N'" + ghiChu + "' where MaSP = " + maSP;
        //    int rs = dp.ExcuteNonQuery(sqlAdd);
        //    if (rs > 0)
        //    {
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool checkPrimarykey(int masp)
        //{
        //    string sqlCheck = "select * from SanPham where MaSP = " + masp;
        //    DataTable rs = dp.ExcuteQuery(sqlCheck);
        //    if (rs.Rows.Count > 0)
        //    {
        //        return true;

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
