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
        //public List<Bill> findBill(string )
        //{
        //    List<Category> lstCategory = new List<Category>();
        //    string sqlCategory = "select * from DanhMuc where TenDM = N'" + tendm + "'";
        //    DataTable dt = dp.ExcuteQuery(sqlCategory);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        Category cate = new Category(item);
        //        lstCategory.Add(cate);
        //    }
        //    return lstCategory;
        //}
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
        public bool addBill(int maHD, int maKH, int maNV, int maSP,DateTime ngayBan)
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
        public bool repairBill(int maHD, int maKH, int maNV, int maSP, DateTime ngayBan)
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
    }
}
