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
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        ProductDAO pd = new ProductDAO();
        CategoryDAO cate = new CategoryDAO();
        BindingSource listProduct = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmProduct()
        {
            InitializeComponent();
        }
        
        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = listProduct;
            listProduct.DataSource = pd.loadProduct();
            cbDanhMuc.Properties.DataSource = cate.loadCategory();
            cbDanhMuc.Properties.ValueMember = "MaDM";
            cbDanhMuc.Properties.DisplayMember = "TenDM";

            txtMaSP.Enabled = false;
            cbDanhMuc.Enabled = false;
            txtTenSP.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtGhiChu.Enabled = false;
            BindingSource();
        }

        private void BindingSource()
        {
            txtMaSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            cbDanhMuc.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvSanPham.DataSource = listProduct;
                listProduct.DataSource = pd.loadProduct();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaSP.Enabled = true;
                txtMaSP.Text = cbDanhMuc.Text = txtTenSP.Text = txtSoLuong.Text = txtDonGia.Text = txtGhiChu.Text = "";
                cbDanhMuc.Enabled = true;
                txtSoLuong.Enabled = true;
                txtDonGia.Enabled = true;
                txtGhiChu.Enabled = true;
                txtTenSP.Enabled = true;
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {

            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                int manv = int.Parse(txtMaSP.Text);
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Nhân Viên: " + txtTenSP.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (pd.deleteProduct(manv) == true)
                    {
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvSanPham.DataSource = pd.loadProduct();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Nhân Viên để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvSanPham.DataSource = pd.findProduct(txtTim.Text);
                txtTim.Text = "";
            }
        }
    }
}