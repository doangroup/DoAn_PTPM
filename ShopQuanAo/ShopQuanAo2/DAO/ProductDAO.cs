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
    }
}
