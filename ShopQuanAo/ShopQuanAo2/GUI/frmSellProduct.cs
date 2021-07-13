using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
using ShopQuanAo2.DTO;
using System;
using System.Windows.Forms;
namespace ShopQuanAo2.GUI
{
    public partial class frmSellProduct : DevExpress.XtraEditors.XtraForm
    {
        private CustomerDAO ct = new CustomerDAO();
        private ProductDAO pd = new ProductDAO();
        private StaffDAO saff = new StaffDAO();
        private BillDAO bill = new BillDAO();
        private BillInfoDAO info = new BillInfoDAO();
        private BillCustomerDAO billct = new BillCustomerDAO();
        private BindingSource listBillInfo = new BindingSource();
        private BindingSource listBill = new BindingSource();
        private Staff st;

        public Staff ST
        {
            get { return st; }
            set { st = value; staff(ST); }
        }

        private void staff(Staff st)
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
            cbKhachHang.ItemIndex = 0;
            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";
            cbSanPham.ItemIndex = 0;

            dgvHoaDOn.DataSource = listBill;
            listBill.DataSource = bill.loadBill();

        }

        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            loadCBO();

            txtNgayBan.Text = DateTime.Now.ToShortDateString();

            groupCTHD.Enabled = false;
            groupHoaDon.Enabled = false;
            btnThanhToan.Enabled = false;
            BindingSource();



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
            //int maHD = int.Parse(txtMaHD.Text);
            string ngayBan = txtNgayBan.DateTime.Date.ToShortDateString();
            try
            {
                bill.addBill(maKH, maNV, ngayBan);
                XtraMessageBox.Show("Tạo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                groupCTHD.Enabled = true;
                groupHoaDon.Enabled = true;
                groupKH.Enabled = false;
                dgvHoaDOn.DataSource = listBill;
                listBill.DataSource = bill.loadBill();
                txtMaHDCTHD.Text = bill.loadBillLastID();
                int maHD = int.Parse(txtMaHDCTHD.Text);
                dgvInHoaDon.DataSource = billct.loadBillCustomer(maHD);
                var summaryValue = gridView1.Columns["ThanhTien"].SummaryItem.SummaryValue;
                textEdit1.EditValue = summaryValue;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Tạo thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void groupControl3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Thêm")
            {
                try
                {
                    ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    groupHoaDon.Enabled = true;
                    groupKH.Enabled = false;
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
            groupCTHD.Enabled = false;
            groupHoaDon.Enabled = true;
            groupKH.Enabled = false;
            dgvHoaDOn.DataSource = listBill;
            listBill.DataSource = bill.loadBill();
        }

        private void btnQuayLạiKH_Click(object sender, EventArgs e)
        {
            groupKH.Enabled = true;
            groupHoaDon.Enabled = false;
            groupCTHD.Enabled = false;
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
                double gia = double.Parse(txtGia.Text);
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
                    groupHoaDon.Enabled = true;
                    groupCTHD.Enabled = true;
                    groupKH.Enabled = false;
                    loadCBO();
                    dgvInHoaDon.DataSource = billct.loadBillCustomer(mahd);
                    var summaryValue = gridView1.Columns["ThanhTien"].SummaryItem.SummaryValue;
                    textEdit1.EditValue = summaryValue;

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
                int tienthua = int.Parse(txtTienThua.Text);
                
                if (tienthua < 0)
                {
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    btnThanhToan.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Tiền khách đưa không được để trống hoặc nhập khác số - " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BillPayDAO bp = new BillPayDAO();
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            groupHoaDon.Enabled = false;
            groupCTHD.Enabled = false;
            groupKH.Enabled = true;
            btnThanhToan.Enabled = false;
            txtTuenKhachDua.Text = "0";
            txtSoLuong.Text = "0";
            
            int maHD = int.Parse(txtMaHDCTHD.Text);
            bill.repairStatusBill(maHD);
            BillPay billPay2 = new BillPay();
            ////rp.lbNgayBan.Text = string.Format("Tân Phú, Ngày {0} Tháng {1} Năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            frmBillPay rpBillPay = new frmBillPay();
            rpBillPay.prinBill(billPay2, bp.loadBillPay(maHD));
            rpBillPay.ShowDialog();
            XtraMessageBox.Show("Thanh toán thành công! Tổng tiền: " + textEdit1.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnThanhToan.Enabled = false;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            groupHoaDon.Enabled = false;
            groupCTHD.Enabled = false;
            groupKH.Enabled = true;
            btnThanhToan.Enabled = false;
            dgvHoaDOn.DataSource = listBill;
            listBill.DataSource = bill.loadBill();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTuenKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void BindingSource()
        {
            txtMaHDCTHD.DataBindings.Add(new Binding("Text", dgvHoaDOn.DataSource, "MaHD", true, DataSourceUpdateMode.Never));

        }
        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Equals("") || txtDiaChi.Text.Equals("")|| txtSDT.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin Khách Hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    groupHoaDon.Enabled = true;
                    groupKH.Enabled = false;
                    //cbKhachHang.Properties.DataSource = ct.loadCustomerLastID();
                    //cbKhachHang.Properties.ValueMember = "MaKH";
                    //cbKhachHang.Properties.DisplayMember = "TenKH";
                    loadCBO();
                    dgvHoaDOn.DataSource = listBill;
                    listBill.DataSource = bill.loadBill();
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    txtSDT.Text = "";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int maHD = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaHD").ToString());
            dgvInHoaDon.DataSource = billct.loadBillCustomer(maHD);
            groupCTHD.Enabled = true;
            var summaryValue = gridView1.Columns["ThanhTien"].SummaryItem.SummaryValue;
            textEdit1.EditValue = summaryValue;
        }
    }
}