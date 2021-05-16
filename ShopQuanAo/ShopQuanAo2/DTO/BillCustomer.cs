using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ShopQuanAo2.DTO
{
    public class BillCustomer
    {
        private int soLuong;
        private string tenKH, tenNV, tenSP, ngayBan;
        private double giaBan, tongTien;
        public BillCustomer()
        { }
        public BillCustomer(DataRow row)
        {
            this.TenKH = row[0].ToString();
            this.TenNV = row[1].ToString();
            this.TenSP = row[2].ToString();
            this.NgayBan = row[3].ToString();
            this.SoLuong = (int)row[4];
            this.GiaBan = (double)row[5];
            this.TongTien = (double)row[6];
        }
        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
