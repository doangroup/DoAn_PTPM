using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ShopQuanAo2.DTO
{
    public class Product
    {
        int maSP, maDM, soLuong;
        decimal donGia;
        public Product(DataRow row)
        {
            this.MaSP = (int)row[0];
            this.MaDM = (int)row[1];
            this.TenSP = row[2].ToString();
            this.SoLuong = (int)row[3];
            this.DonGia = (decimal)row[4];
            this.GhiChu = row[5].ToString();

        }
        public Product(int masp, int madm, int soluong, int dongia, string tensp, string ghichu)
        {
            this.MaSP = masp;
            this.MaDM = madm;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TenSP = tensp;
            this.GhiChu = ghichu;
        }
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int MaDM
        {
            get { return maDM; }
            set { maDM = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        string tenSP, ghiChu;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public Product() { }

    }
}
