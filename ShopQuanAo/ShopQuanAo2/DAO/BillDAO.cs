using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DTO;
using System.Data;
namespace ShopQuanAo2.DAO
{
   public class BillDAO
    {
        DataProvider dp = new DataProvider();


       
        public List<Bill> loadBill()
        {
            List<Bill> lstBill = new List<Bill>();
            string sqlBill = "select * from HoaDon where TinhTrang = 0";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                Bill bill = new Bill(item);
                lstBill.Add(bill);
            }
            return lstBill;
        }
        public List<Bill> loadBillF()
        {
            List<Bill> lstBill = new List<Bill>();
            string sqlBill = "select * from HoaDon";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                Bill bill = new Bill(item);
                lstBill.Add(bill);
            }
            return lstBill;
        }
        public string loadBillLastID()
        {
            string maHD = "";
            string sqlBill = "select max(MaHD) from HoaDon";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            if (dt.Rows.Count > 0)
            {
                maHD = dt.Rows[0][0].ToString();
            }
            return maHD;
        }
        public DataTable loadTotal(int maHD)
        {
            
            string sqlBill = "select TongTien from HoaDon where MaHD = " + maHD;
            DataTable dt = dp.ExcuteQuery(sqlBill);
            
            return dt;
        }
        
        
        public List<Bill> findBill(int maHD)
        {
            List<Bill> lstBill = new List<Bill>();
            string sqlBill = "select * from HoaDon where MaHD = " + maHD;
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                Bill bill = new Bill(item);
                lstBill.Add(bill);
            }
            return lstBill;
        }
        public bool deleteBill(int maHD)
        {

            string sqlDelete = "delete from HoaDon where MaHD = " + maHD;
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
        public bool addBill(int maKH, int maNV,string ngayBan)
        {

            string sqlAdd = "set Dateformat DMY insert into HoaDon  values (" + maKH + "," + maNV + ",0,'" + ngayBan + "',null,0)";
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
        public bool repairStatusBill(int maHD)
        {
            string sqlAdd = "update HoaDon set TinhTrang = 1 where MaHD = " + maHD;
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
        public bool repairBill(int maHD, int maKH, int maNV,string ngayBan)
        {
            string sqlAdd = "update HoaDon set MaKH = " + maKH + ",MaNV = " + maNV + ",NgayBan = '" + ngayBan + "',TongTien = 0 where MaHD = " + maHD;
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
        public bool checkPrimarykey(int maHD)
        {
            string sqlCheck = "select * from HoaDon where MaHD = " + maHD;
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
