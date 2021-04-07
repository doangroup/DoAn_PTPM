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
            try
            {
                string sqlDelete = "delete from SanPham where MaSP = " + maSP;
                int rs = dp.ExcuteNonQuery(sqlDelete);
                return rs > 0 ? true : false;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
    }
}
