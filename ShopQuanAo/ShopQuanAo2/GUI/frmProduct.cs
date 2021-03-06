using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ShopQuanAo2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ShopQuanAo2.GUI
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        private ProductDAO pd = new ProductDAO();
        private CategoryDAO cate = new CategoryDAO();
        private BindingSource listProduct = new BindingSource();
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
            cbDanhMuc.ItemIndex = 0;
            BindingSource();
        }

        private void BindingSource()
        {
            txtMaSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            cbDanhMuc.DataBindings.Add(new Binding("EditValue", dgvSanPham.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            txtTenSP.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dgvSanPham.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            int masp = int.Parse(txtMaSP.Text);
            int soluong = int.Parse(txtSoLuong.Text);
            double dongia = double.Parse(txtDonGia.Text);

            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvSanPham.DataSource = listProduct;
                listProduct.DataSource = pd.loadProduct();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {

                cbDanhMuc.EditValue = null;
                txtTenSP.Text = "";
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                txtGhiChu.Text = "";
                cbDanhMuc.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 
                int madm = int.Parse(cbDanhMuc.EditValue.ToString());
                {
                    try
                    {
                        pd.addProduct(madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvSanPham.DataSource = listProduct;
                        listProduct.DataSource = pd.loadProduct();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                masp = int.Parse(txtMaSP.Text);
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Sản Phẩm: " + txtTenSP.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        pd.deleteProduct(masp);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvSanPham.DataSource = listProduct;
                        listProduct.DataSource = pd.loadProduct();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

                masp = int.Parse(txtMaSP.Text);
                int madm = int.Parse(cbDanhMuc.EditValue.ToString());
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        pd.repairProduct(masp, madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvSanPham.DataSource = listProduct;
                        listProduct.DataSource = pd.loadProduct();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Sản Phẩm để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    dgvSanPham.DataSource = listProduct;
                    listProduct.DataSource = pd.findProduct(txtTim.Text);
                    txtTim.Text = "";
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Tìm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (e.Button.Properties.Caption == "Xuất Excel")
            {
                ExportExcel excel = new ExportExcel();
                // Lấy về nguồn dữ liệu cần Export là 1 DataTable
                // DataTable này mỗi bạn lấy mỗi khác. 
                // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
                // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
                // DataGridView nhé 


                DataTable dt = (DataTable)listProduct.DataSource;
                excel.Export(dt, "Danh sach", "DANH SÁCH SẢN PHẨM");
            }
            else if (e.Button.Properties.Caption == "In DS Sản Phẩm")
            {
                rpProduct a = new rpProduct();
                //a.DataSource = pd.loadProduct();
                //BindData();
                a.ShowPreviewDialog();
            }
        }
       
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbDanhMuc_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int madm = int.Parse(cbDanhMuc.EditValue.ToString());


            //    dgvSanPham.DataSource = listProduct;
            //    listProduct.DataSource = pd.loadProductByCategoryID(madm);
            //}
            //catch (Exception ex)
            //{

            //    XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}