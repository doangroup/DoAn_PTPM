using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopQuanAo2.DTO
{
   public class Staff
    {
        private int maNV;
        public Staff(DataRow row) 
        {
            this.MaNV = (int)row[0];
            this.TenNV = row[1].ToString();
            this.GioiTinh = row[2].ToString();
            this.DiaChi = row[3].ToString();
            this.SDT = row[4].ToString();
            this.NgaySinh = row[5].ToString();
        }
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string tenNV, gioiTinh, diaChi, ngaySinh,sDT;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

       public string NgaySinh
       {
           get { return ngaySinh; }
           set { ngaySinh = value; }
       }
    }
}
