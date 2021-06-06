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
namespace ShopQuanAo2.GUI
{
    public partial class frmBill : DevExpress.XtraEditors.XtraForm
    {
        BillDAO bill = new BillDAO();
        StaffDAO staff = new StaffDAO();
        ProductDAO pd = new ProductDAO();
        CustomerDAO ct = new CustomerDAO();

        BindingSource listBill = new BindingSource();
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = listBill;
            listBill.DataSource = bill.loadBillF();

            cbKhachHang.Properties.DataSource = ct.loadCustomer();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";

            cbNhanVien.Properties.DataSource = staff.loadStaff();
            cbNhanVien.Properties.DisplayMember = "TenNV";
            cbNhanVien.Properties.ValueMember = "MaNV";

            

            BindingSource();
        }
        private void BindingSource()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
            cbKhachHang.DataBindings.Add(new Binding("EditValue", dgvHoaDon.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            cbNhanVien.DataBindings.Add(new Binding("EditValue", dgvHoaDon.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTinhTrang.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txtNgayBan.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "NgayBan", true, DataSourceUpdateMode.Never));
            txtTongTien.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TongTien", true, DataSourceUpdateMode.Never));

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
            
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvHoaDon.DataSource = listBill;
                listBill.DataSource = bill.loadBill();
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên Khách Hàng")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Khách Hàng để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    int maHD = int.Parse(txtTim.Text);
                    dgvHoaDon.DataSource = listBill;                
                    listBill.DataSource = bill.findBill(maHD);
                    txtTim.Text = "";
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Tìm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (e.Button.Properties.Caption == "Xuất Word")
            {
            }
            else if (e.Button.Properties.Caption == "Xuất Excel")
            {
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}