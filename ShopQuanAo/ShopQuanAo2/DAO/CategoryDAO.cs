using ShopQuanAo2.DTO;
using System.Collections.Generic;
using System.Data;
namespace ShopQuanAo2.DAO
{
    public class CategoryDAO
    {
        private DataProvider dp = new DataProvider();

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
        public string loadCategoryLastID()
        {
            string madm = "";
            string sqlCategory = "select max(MaDM) from DanhMuc";
            DataTable dt = dp.ExcuteQuery(sqlCategory);
            if (dt.Rows.Count > 0)
            {
                madm = dt.Rows[0][0].ToString();
            }
            return madm;
        }
        public List<Category> findCategory(string tendm)
        {
            List<Category> lstCategory = new List<Category>();
            string sqlCategory = "select * from DanhMuc where TenDM = N'" + tendm + "'";
            DataTable dt = dp.ExcuteQuery(sqlCategory);
            foreach (DataRow item in dt.Rows)
            {
                Category cate = new Category(item);
                lstCategory.Add(cate);
            }
            return lstCategory;
        }
        public bool deleteCategory(int maDM)
        {

            string sqlDelete = "delete from DanhMuc where MaDM = " + maDM;
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
        public bool addCategory(string tenDM)
        {

            string sqlAdd = "insert into DanhMuc values (N'" + tenDM + "')";
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
        public bool repairCategory(int maDM, string tenDM)
        {
            string sqlAdd = "update DanhMuc set TenDM = N'" + tenDM + "' where MaDM = " + maDM;
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
        public bool checkPrimarykey(int maDM)
        {
            string sqlCheck = "select * from DanhMuc where MaDM = " + maDM;
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
