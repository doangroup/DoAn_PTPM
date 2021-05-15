using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.GUI
{
    public partial class frmSellProductInfo : DevExpress.XtraEditors.XtraForm
    {
        ProductDAO pd = new ProductDAO();
        BillInfoDAO info = new BillInfoDAO();

        private Bill bill;

        public Bill Bill
        {
            get { return bill; }
            set { bill = value; bill2(Bill)}
        }

        
        void bill2(Bill bill)
        {

            txtMaHD.Text = bill.MaHD.ToString();

        }
        public frmSellProductInfo(Bill bill)
        {
            InitializeComponent();
            bill = Bill;
        }

        private void frmSellProductInfo_Load(object sender, EventArgs e)
        {
            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";

            txtGia.Enabled = false;
        }
    }
}