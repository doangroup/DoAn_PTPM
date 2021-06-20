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
using ShopQuanAo2.DAO;
using DevExpress.XtraReports.UI;
namespace ShopQuanAo2.GUI
{
    public partial class frmStatistical : DevExpress.XtraEditors.XtraForm
    {
        public frmStatistical()
        {
            InitializeComponent();
        }
        BillStaticalDAO bill = new BillStaticalDAO();
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = bill.loadBillStatical();
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = bill.loadBillStatical();
        }
        BillStaticalDAO billstatical = new BillStaticalDAO();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (txtTu.Text.Equals("") && txtDen.Text.Equals(""))
            {
                BillStatical billStatical = new BillStatical();
                frmBillStatical rpBillPay = new frmBillStatical();
                rpBillPay.prinBill(billStatical, billstatical.loadReportBill2());
                rpBillPay.ShowDialog();
            }
            else
            {
                BillStatical billStatical = new BillStatical();
                frmBillStatical rpBillPay = new frmBillStatical();
                rpBillPay.prinBill(billStatical, billstatical.loadReportBill(txtTu.DateTime.ToShortDateString(), txtDen.DateTime.ToShortDateString()));
                rpBillPay.ShowDialog();
            }
        }
        
    }
}