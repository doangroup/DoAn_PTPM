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
using DevExpress.XtraReports.UI;
namespace ShopQuanAo2.GUI
{
    public partial class frmBillStatical : DevExpress.XtraEditors.XtraForm
    {
        public frmBillStatical()
        {
            InitializeComponent();
        }
        public void prinBill(BillStatical bp, List<BillStatical> lstbillpay)
        {
            rpBillStatical rpBillStatical = new rpBillStatical();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in rpBillStatical.Parameters)
            {
                p.Visible = false;
                rpBillStatical.initData(bp.TenNV, bp.TenKH, bp.NgayBan, bp.TongTien, lstbillpay);
                documentViewer1.DocumentSource = rpBillStatical;
                rpBillStatical.CreateDocument();
            }
        }
    }
}