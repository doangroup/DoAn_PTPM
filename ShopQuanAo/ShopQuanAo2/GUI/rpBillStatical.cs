using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ShopQuanAo2.DTO;
using System.Collections.Generic;

namespace ShopQuanAo2.GUI
{
    public partial class rpBillStatical : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBillStatical()
        {
            InitializeComponent();
        }
        public void initData(string tenNV, string tenKH, string ngayBan, double tongTien, List<BillStatical> lstBillPay)
        {
            pTenNV.Value = tenNV;
            pTenKH.Value = tenKH;
            pNgayBan.Value = ngayBan;
            pTongTien.Value = tongTien;
            objectDataSource1.DataSource = lstBillPay;
        }
    }
}
