using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DTO
{
    public class BillInfo
    {
        private int maHD, soLuong, tinhTrang, maCTHD;

        public int MaCTHD
        {
            get { return maCTHD; }
            set { maCTHD = value; }
        }
       

        public BillInfo(DataRow row)
        {
            this.MaCTHD = (int)row[0];
            this.MaHD = (int)row[1];
            this.SoLuong = (int)row[2];
            this.ThanhTien = (double)row[3];
            this.TinhTrang = (int)row[4];
        }
        public BillInfo()
        { }
        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        private double thanhTien;

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
