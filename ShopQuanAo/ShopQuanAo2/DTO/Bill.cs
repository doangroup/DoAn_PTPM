using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopQuanAo2.DTO
{
    public class Bill
    {

        public Bill()
        { }
        private int maHD, maKH, maSP, maNV;
        private double tongTien;

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string ngayBan;
        public Bill(DataRow row)
        {
            this.MaHD = (int)row[0];
            this.MaKH = (int)row[1];
            this.MaNV = (int)row[2];
            this.MaSP = (int)row[3];
            this.NgayBan = row[4].ToString();
            this.TongTien = (double)row[5];
        }
        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
    }
}
