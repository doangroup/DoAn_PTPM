using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ShopQuanAo2.DTO
{
    public class Category
    {
        private int maDM;
        private string tenDM;
        public Category() { }
        public Category(int madm, string tendm)
        {
            this.MaDM = madm;
            this.TenDM = tendm;
        }
        public Category(DataRow row)
        {
            this.MaDM = (int)row[0];
            this.TenDM = row[1].ToString();
        }

        public string TenDM
        {
            get { return tenDM; }
            set { tenDM = value; }
        }

        public int MaDM
        {
            get { return maDM; }
            set { maDM = value; }
        }
    }
}
