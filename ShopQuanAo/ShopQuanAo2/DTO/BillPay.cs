using System.Data;
namespace ShopQuanAo2.DTO
{
    public class BillPay
    {
        private int maHD, soLuong;
        private decimal donGia;
        private double thanhTien;
        private double tongTien;
        private string ngayBan, tenNV, tenSP;
        private string tenKH;
        public BillPay() { }
        public BillPay(DataRow row)
        {
            this.NgayBan = row[0].ToString();
            this.maHD = (int)row[1];
            this.TenNV = row[2].ToString();
            this.TenSP = row[3].ToString();
            this.SoLuong = (int)row[4];
            this.DonGia = (decimal)row[5];
            this.ThanhTien = (double)row[6];
            this.TongTien = (double)row[7];
            this.TenKH = row[8].ToString();
        }
        public int MaHD { get => maHD; set => maHD = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }

        public double TongTien { get => tongTien; set => tongTien = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
    }
}
