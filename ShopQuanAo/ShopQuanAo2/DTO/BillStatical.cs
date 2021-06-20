using System.Data;

namespace ShopQuanAo2.DTO
{
    public class BillStatical
    {
        private string tenNV, tenKH, ngayBan;
        private double tongTien;
        public BillStatical() { }
        public BillStatical(DataRow row)
        {
            this.TenNV = row[0].ToString();
            this.TenKH = row[1].ToString();
            this.NgayBan = row[2].ToString();
            this.TongTien = (double)row[3];
        }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
    }
}
