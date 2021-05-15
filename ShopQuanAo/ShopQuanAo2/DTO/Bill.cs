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
        private int maHD, maKH,maNV;
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
            this.NgayBan = row[3].ToString();
            this.TongTien = (double)row[4];
        }
        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
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
