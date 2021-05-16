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
            int dongia = int.Parse(txtDonGia.Text);
            
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvSanPham.DataSource = listProduct;
                listProduct.DataSource = pd.loadProduct();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaSP.Text = "";
                cbDanhMuc.Text = "";
                txtTenSP.Text = "";
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                txtGhiChu.Text = "";
                txtMaSP.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 
                int madm = int.Parse(cbDanhMuc.EditValue.ToString());

                if (pd.checkPrimarykey(masp) == true)
                {
                    DialogResult dl = XtraMessageBox.Show("Mã sản phẩm trùng với mã đã có bán có muốn sửa cho Mã Sản Phẩm: " + txtMaSP.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại! Lỗi - Trùng mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Không trùng mã thì sẽ thêm vào
                else 
                {
                    try
                    {
                        pd.addProduct(masp, madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
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
            else if (e.Button.Properties.Caption == "Xuất Word")
            {
            }
            else if (e.Button.Properties.Caption == "Xuất Excel")
            {
            }
        }
    }
}