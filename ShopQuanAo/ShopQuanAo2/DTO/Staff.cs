using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopQuanAo2.DTO
{
   public class Staff
    {
        private int maNV, loaiTK;

        public int LoaiTK
        {
            get { return loaiTK; }
            set { loaiTK = value; }
        }
        private string tenDN, matKhau;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public Staff(DataRow row) 
        {
            this.MaNV = (int)row[0];
            this.TenNV = row[1].ToString();
            this.GioiTinh = row[2].ToString();
            this.DiaChi = row[3].ToString();
            this.SDT = row[4].ToString();
            this.NgaySinh = row[5].ToString();
            this.TenDN = row[6].ToString();
            this.MatKhau = row[7].ToString();
            this.LoaiTK = (int)row[8];
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
