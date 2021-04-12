using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ShopQuanAo2.DTO
{
    public class Customer
    {
        int maKH;
        string tenKH, diaChi, sDT;
        public Customer() { }

        public Customer(DataRow row)
        {
            this.MaKH = (int)row[0];
            this.TenKH = row[1].ToString();
            this.DiaChi = row[2].ToString();
            this.SDT = row[3].ToString();
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }



        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
    }
}
