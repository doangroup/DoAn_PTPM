using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.GUI
{
    public partial class rpBill : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBill()
        {
            InitializeComponent();
        }
        public void initData(string ngayBan,int maHD ,string tenNV,string tenSP,int soLuong,decimal donGia,double thanhTien, double tongTien, string tenKH,List<BillPay> lstBillPay)
        {
            pNgay.Value = ngayBan;
            pMaHD.Value = maHD;
            pNhanVien.Value = tenNV;
            pTenSP.Value = tenSP;
            pSoLuong.Value = soLuong;
            pGiaBan.Value = donGia;
            pThanhTien.Value = thanhTien;
            pTongTien.Value = tongTien;
            pKhachHang.Value = tenKH;
            objectDataSource3.DataSource = lstBillPay;
        }
    }
}
