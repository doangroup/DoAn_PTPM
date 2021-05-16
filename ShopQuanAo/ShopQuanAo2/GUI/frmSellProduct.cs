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
        StaffDAO saff = new StaffDAO();
        BillDAO bill = new BillDAO();



        private Staff st;

        public Staff ST
        {
            get { return st; }
            set { st = value; staff(ST); }
        }
        void staff(Staff st)
        {

            txtNhanVien.Text = st.MaNV.ToString();
            
        }
        public frmSellProduct(Staff st)
        {
            InitializeComponent();
            ST = st;
        }

       
        public void loadCBO()
        {
            cbKhachHang.Properties.DataSource = ct.loadCustomer();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";

           
        }
        public void enable()
        {
         txtMaHD.Enabled= btnThemKH2.Enabled = btnAddBill.Enabled = txtNgayBan.Enabled = cbKhachHang.Enabled = false;
        }
        public void unenable()
        {
            btnThemKH.Enabled = btnBoQua.Enabled = txtTenKH.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = false;
        }
        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            loadCBO();
            enable();
            txtNgayBan.Text = DateTime.Now.ToString();
        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        private Form checkExit(Type type)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == type)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(txtNhanVien.Text);
            int maKH = int.Parse(cbKhachHang.EditValue.ToString());
            int maHD = int.Parse(txtMaHD.Text);
            try
            {
                bill.addBill(maHD,maKH, maNV, txtNgayBan.DateTime.Date.ToShortDateString()); 
                XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                frmSellProductInfo info = new frmSellProductInfo(txtMaHD.Text);
                info.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadCBO();
                txtMaHD.Enabled = btnThemKH2.Enabled = btnAddBill.Enabled = txtNgayBan.Enabled = cbKhachHang.Enabled = true;
                unenable();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = btnThemKH2.Enabled = btnAddBill.Enabled = txtNgayBan.Enabled = cbKhachHang.Enabled = true;
            unenable();
        }

        private void btnThemKH2_Click(object sender, EventArgs e)
        {
            enable();
            btnThemKH.Enabled = btnBoQua.Enabled = txtTenKH.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = true;

        }
    }
}