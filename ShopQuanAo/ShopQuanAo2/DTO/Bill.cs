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
        private int maHD, maKH,maNV, tinhTrang;
        private double tongTien;
        private string ngayBan, ngayGiao;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
        public string NgayGiao { get => ngayGiao; set => ngayGiao = value; }

        public Bill(DataRow row)
        {
            this.MaHD = (int)row[0];
            this.MaKH = (int)row[1];
            this.MaNV = (int)row[2];
            this.TinhTrang = (int)row[3];
            this.NgayBan = row[4].ToString();
            this.NgayGiao = row[5].ToString();
            this.TongTien = (double)row[6];
        }
       
    }
}
