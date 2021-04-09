using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DAO
{
    public class ProductDAO
    {
        DataProvider dp = new DataProvider();
        public List<Product> loadProduct()
        {
            List<Product> lstProduct = new List<Product>();
            string sqlProduct = "select MaSP, MaDM, TenSP, SoLuong, DonGia, GhiChu from SanPham";
            DataTable dt = dp.ExcuteQuery(sqlProduct);
            foreach (DataRow item in dt.Rows)
            {
                Product pd = new Product(item);
                lstProduct.Add(pd);
            }
            return lstProduct;
        }

        public List<Product> findProduct(string tenSP)
        {
            List<Product> lstProduct = new List<Product>();
            string sqlProduct = "select * from SanPham where TenSP = '" + tenSP + "'";
            DataTable dt = dp.ExcuteQuery(sqlProduct);
            foreach (DataRow item in dt.Rows)
            {
                Product pd = new Product(item);
                lstProduct.Add(pd);
            }
            return lstProduct;
        }

        public bool deleteProduct(int maSP)
        {

            string sqlDelete = "delete from SanPham where MaSP = " + maSP;
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
        public bool addProduct(int maSP, int maDM, string tenSP, int soLuong, int donGia, string ghiChu)
        {

            string sqlAdd = "insert into SanPham values (" + maSP + "," + maDM + ",N'" + tenSP + "'," + soLuong + "," + donGia + ",'',N'" + ghiChu + "')";
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
        public bool repairProduct(int maSP, int maDM, string tenSP, int soLuong, int donGia, string ghiChu)
        {
            string sqlAdd = "update SanPham set MaDM = " + maDM + ", TenSP = N'" + tenSP + "',SoLuong = " + soLuong + ", DonGia = " + donGia + ",GhiChu = N'" + ghiChu + "' where MaSP = " + maSP;
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
        public bool checkPrimarykey(int masp)
        {
            string sqlCheck = "select * from SanPham where MaSP = " + masp;
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
