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
        BillInfoDAO info = new BillInfoDAO();

        BillCustomerDAO billct = new BillCustomerDAO();

        BindingSource listBillInfo = new BindingSource();
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
        private void BindingSource()
        {
            txtTongTien.DataBindings.Add(new Binding("Text", dgvInHoaDon.DataSource, "TongTien", true, DataSourceUpdateMode.Never));

        }
       
        public void loadCBO()
        {
            cbKhachHang.Properties.DataSource = ct.loadCustomer();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";
            cbKhachHang.ItemIndex = 0;
            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";
            cbSanPham.ItemIndex = 0;
        }
        
        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            loadCBO();
         
            txtNgayBan.Text = DateTime.Now.ToString();
            
            groupControl2.Enabled = false;
            groupControl1.Enabled = false;


            
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

                groupControl2.Enabled = true;
                groupControl1.Enabled = false;
                groupControl3.Enabled = false;
            
                txtMaHDCTHD.Text = txtMaHD.Text;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemKH2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmAddCustomer act = new frmAddCustomer();
            act.ShowDialog();
        }

        private void groupControl3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Thêm")
            {
                try
                {
                    ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    groupControl1.Enabled = true;
                    groupControl3.Enabled = false;
                    loadCBO();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            groupControl2.Enabled = false;
            groupControl1.Enabled = true;
            groupControl3.Enabled = false;
        }

        private void btnQuayLạiKH_Click(object sender, EventArgs e)
        {
            groupControl3.Enabled = true;
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
        }

        private void cbSanPham_EditValueChanged(object sender, EventArgs e)
        {
            int masp = int.Parse(cbSanPham.EditValue.ToString());
            txtGia.Text = pd.loadPriceByProductID(masp).ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txtSoLuong.Text);
                int gia = int.Parse(txtGia.Text);
                txtThanhTien.Text = (sl * gia).ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Số lượng không được để trống hoặc nhập khác số - " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
        }

        private void groupControl2_CustomButtonClick_1(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Thêm")
            {
                try
                {
                    int mahd = int.Parse(txtMaHDCTHD.Text);
                    int sl = int.Parse(txtSoLuong.Text);
                    int masp = int.Parse(cbSanPham.EditValue.ToString());
                    int thanhtien = int.Parse(txtThanhTien.Text);
                    info.addBillInfo(mahd, masp, sl, thanhtien);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    groupControl1.Enabled = false;
                    groupControl2.Enabled = true;
                    groupControl3.Enabled = false;
                    loadCBO();
                    dgvInHoaDon.DataSource = billct.loadBillCustomer(mahd);
                    //gridView1.Columns["ThanhTien"].Visible = false;

                    var summaryValue = gridView1.Columns["ThanhTien"].SummaryItem.SummaryValue;
                    textEdit1.EditValue = summaryValue;
                    //int tien = dgvInHoaDon.;
                    //double tongtien = 0;
                    //for (int i = 0; i < tien - 1; i++)
                    //{
                    //    thanhtien += float.Parse(dgvInHoaDon.Rows[i].Cells["Giá"].Value.ToString());
                    //}
                    //txttongtien.Text = thanhtien.ToString();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtTuenKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tongtien = int.Parse(textEdit1.Text);
                int tienkhachdua = int.Parse(txtTuenKhachDua.Text);
                txtTienThua.Text = (tienkhachdua - tongtien).ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Tiền khách đưa không được để trống hoặc nhập khác số - " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}