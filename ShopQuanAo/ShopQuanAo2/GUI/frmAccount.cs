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
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        AcountDAO acc = new AcountDAO();
    
        BindingSource listAccount = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = listAccount;
            listAccount.DataSource = acc.loadAccount();
         

            BindingSource();
        }
        private void BindingSource()
        {
            //txtTenDN.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "TenDN", true, DataSourceUpdateMode.Never));
            //txtLoaiTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            
        }
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            

            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvTaiKhoan.DataSource = listAccount;
                listAccount.DataSource = acc.loadAccount();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 
                //int madm = int.Parse(cbDanhMuc.EditValue.ToString());

                //if (pd.checkPrimarykey(masp) == true)
                //{
                //    DialogResult dl = XtraMessageBox.Show("Mã sản phẩm trùng với mã đã có bán có muốn sửa cho Mã Sản Phẩm: " + txtMaSP.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (dl == DialogResult.Yes)
                //    {
                //        try
                //        {
                //            pd.repairProduct(masp, madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                //            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //            dgvSanPham.DataSource = listProduct;
                //            listProduct.DataSource = pd.loadProduct();

                //        }
                //        catch (Exception ex)
                //        {
                //            XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //    else
                //    {
                //        XtraMessageBox.Show("Thêm thất bại! Lỗi - Trùng mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //Không trùng mã thì sẽ thêm vào
                //else
                //{
                //    try
                //    {
                //        pd.addProduct(masp, madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                //        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        dgvSanPham.DataSource = listProduct;
                //        listProduct.DataSource = pd.loadProduct();

                //    }
                //    catch (Exception ex)
                //    {
                //        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {

                //DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Sản Phẩm: " + txtTenSP.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dl == DialogResult.Yes)
                //{
                //    try
                //    {
                //        pd.deleteProduct(masp);
                //        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        dgvSanPham.DataSource = listProduct;
                //        listProduct.DataSource = pd.loadProduct();
                //    }
                //    catch (Exception ex)
                //    {
                //        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {


                //int madm = int.Parse(cbDanhMuc.EditValue.ToString());
                //DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dl == DialogResult.Yes)
                //{
                //    try
                //    {
                //        pd.repairProduct(masp, madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                //        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        dgvSanPham.DataSource = listProduct;
                //        listProduct.DataSource = pd.loadProduct();

                //    }
                //    catch (Exception ex)
                //    {
                //        XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                //if (txtTim.Text == "")
                //{
                //    XtraMessageBox.Show("Vui lòng nhập Tên Sản Phẩm để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //try
                //{
                //    dgvSanPham.DataSource = listProduct;
                //    listProduct.DataSource = pd.findProduct(txtTim.Text);
                //    txtTim.Text = "";
                //}
                //catch (Exception ex)
                //{

                //    XtraMessageBox.Show("Tìm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

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