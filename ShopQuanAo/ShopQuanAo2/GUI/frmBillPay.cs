using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.GUI
{
    public partial class frmBillPay : DevExpress.XtraEditors.XtraForm
    {
        public frmBillPay()
        {
            InitializeComponent();
        }

        private void frmBillPay_Load(object sender, EventArgs e)
        {

        }
        public void prinBill(BillPay bp,List<BillPay> lstbillpay)

        {
            rpBill rpBill = new rpBill();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpBill.Parameters)
            {
                p.Visible = false;
                //for (int i = 0; i < lstbillpay.Count; i++)
                //{

                //   lstbillpay= rpBill.initData(lstbillpay[i].NgayBan, lstbillpay[i].MaHD, lstbillpay[i].TenNV, lstbillpay[i].TenSP, lstbillpay[i].SoLuong, lstbillpay[i].DonGia, lstbillpay[i].ThanhTien, lstbillpay[i].TongTien, lstbillpay[i].TenKH);
                //}
                rpBill.initData(bp.NgayBan,bp.MaHD,bp.TenNV, bp.TenSP,bp.SoLuong,bp.DonGia,bp.ThanhTien,bp.TongTien,bp.TenKH,lstbillpay);
                documentViewer1.DocumentSource = rpBill;
                rpBill.CreateDocument();
            }
        }
    }
}