using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DAO;
using ShopQuanAo2.DTO;
using System.Data;
namespace ShopQuanAo2.DAO
{
    public class CategoryDAO
    {
        DataProvider dp = new DataProvider();

        public List<Category> loadCategory()
        {
            List<Category> lstCategory = new List<Category>();
            string sqlCategory = "select * from DanhMuc";
            DataTable dt = dp.ExcuteQuery(sqlCategory);
            foreach (DataRow item in dt.Rows)
            {
                Category cate = new Category(item);
                lstCategory.Add(cate);
            }
            return lstCategory;
        }
        public List<Category> findCategory(string tendm)
        {
            List<Category> lstCategory = new List<Category>();
            string sqlCategory = "select * from DanhMuc where TenDM = '" + tendm + "'";
            DataTable dt = dp.ExcuteQuery(sqlCategory);
            foreach (DataRow item in dt.Rows)
            {
                Category cate = new Category(item);
                lstCategory.Add(cate);
            }
            return lstCategory;
        }
    }
}
