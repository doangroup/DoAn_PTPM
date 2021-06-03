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
        //public DataTable loadPriceByProductID(int maSP)
        //{
        //    DataTable donGia = dp.ExcuteQuery("select DonGia from SanPham where MaSP = " + maSP);
        //    return donGia;
        //}
        public List<Product> loadProductByCategoryID(int maDM)
        {
            List<Product> lstProduct = new List<Product>();
            string sqlProduct = "select MaSP, MaDM, TenSP, SoLuong, DonGia, GhiChu from SanPham where MaDM = " + maDM;
            DataTable dt = dp.ExcuteQuery(sqlProduct);
            foreach (DataRow item in dt.Rows)
            {
                Product pd = new Product(item);
                lstProduct.Add(pd);
            }
            return lstProduct;
        }
        public decimal loadPriceByProductID(int maSP)
        {
            List<Product> sanPham = new List<Product>();
            string sqlSanPham = "select * from SanPham where MaSP = " + maSP;
            DataTable data = dp.ExcuteQuery(sqlSanPham);
            foreach (DataRow item in data.Rows)
            {
                Product sp = new Product(item);
                sanPham.Add(sp);
            }
            decimal gia = 0;
            for(int i=0;i<sanPham.Count;i++)
            {
                gia = sanPham[i].DonGia;
            }
            return gia;
        }
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
            string sqlProduct = "select MaSP, MaDM, TenSP, SoLuong, DonGia, GhiChu from SanPham where TenSP = N'" + tenSP + "'";
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
        public bool addProduct(int maDM, string tenSP, int soLuong, double donGia, string ghiChu)
        {

            string sqlAdd = "insert into SanPham values (" + maDM + ",N'" + tenSP + "'," + soLuong + "," + donGia + ",'',N'" + ghiChu + "')";
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
        public bool repairProduct(int maSP, int maDM, string tenSP, int soLuong, double donGia, string ghiChu)
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
