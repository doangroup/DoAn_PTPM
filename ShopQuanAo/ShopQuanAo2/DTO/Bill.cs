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

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayBan;
        public Bill(DataRow row)
        {
            this.MaHD = (int)row[0];
            this.MaKH = (int)row[1];
            this.MaNV = (int)row[2];
            this.MaSP = (int)row[3];
            this.NgayBan = (DateTime)row[4];
        }
        public DateTime NgayBan
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
