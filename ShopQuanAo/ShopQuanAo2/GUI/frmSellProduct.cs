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
    public partial class frmSellProduct : DevExpress.XtraEditors.XtraForm
    {
        CustomerDAO ct = new CustomerDAO();
        ProductDAO pd = new ProductDAO();
        private Staff st;

        public Staff ST
        {
            get { return st; }
            set { st = value; staff(ST); }
        }
        void staff(Staff st)
        {
            cbNhanVien.Properties.DisplayMember = st.MaNV.ToString();
            cbNhanVien.Properties.ValueMember = st.TenNV;
        }
        public frmSellProduct()
        {
            InitializeComponent();
        }

       
        public void loadCBO()
        {
            cbKhachHang.Properties.DataSource = ct.loadCustomer();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";

            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";
        }
        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            loadCBO();
        }

      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddCusmer ct = new frmAddCusmer();
            ct.ShowDialog();
        }
    }
}