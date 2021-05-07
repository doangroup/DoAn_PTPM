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
            string sqlBill = "select * from HoaDon";
            DataTable dt = dp.ExcuteQuery(sqlBill);
            foreach (DataRow item in dt.Rows)
            {
                Bill bill = new Bill(item);
                lstBill.Add(bill);
            }
            return lstBill;
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
        public bool addBill(int maHD, int maKH, int maNV, int maSP,string ngayBan)
        {

            string sqlAdd = "insert into HoaDon values (" + maHD + "," + maKH + "," + maNV + "," + maSP + "," + ngayBan + ")";
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
        public bool repairBill(int maHD, int maKH, int maNV, int maSP, string ngayBan)
        {
            string sqlAdd = "update HoaDon set MaKH = " + maKH + ",MaNV = " + maNV + ",MaSP = " + maSP + ",NgayBan = " + ngayBan + " where MaHD = " + maHD;
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
