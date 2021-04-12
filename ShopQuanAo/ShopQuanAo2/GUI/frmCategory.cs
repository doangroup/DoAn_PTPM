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
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        CategoryDAO cate= new CategoryDAO();
        BindingSource listCategory = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = listCategory;
            listCategory.DataSource = cate.loadCategory();

            
            
            BindingSource();
        }

        private void BindingSource()
        {
            txtMaDM.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            txtTenDM.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "TenDM", true, DataSourceUpdateMode.Never));
           
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            int maDM = int.Parse(txtMaDM.Text);
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvDanhMuc.DataSource = listCategory;
                listCategory.DataSource = cate.loadCategory();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaDM.Text = "";
                txtTenDM.Text = "";
               
                txtMaDM.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 
                

                if (cate.checkPrimarykey(maDM) == true)
                {
                    DialogResult dl = XtraMessageBox.Show("Mã danh mục trùng với mã đã có bán có muốn sửa cho Mã Danh Mục: " + txtMaDM.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        try
                        {
                            cate.repairCategory(maDM, txtTenDM.Text);
                            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvDanhMuc.DataSource = listCategory;
                            listCategory.DataSource = cate.loadCategory();

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại! Lỗi - Trùng mã danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Không trùng mã thì sẽ thêm vào
                else
                {
                    try
                    {
                        cate.addCategory(maDM, txtTenDM.Text);
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDanhMuc.DataSource = listCategory;
                        listCategory.DataSource = cate.loadCategory();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Danh Mục: " + txtTenDM.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        cate.deleteCategory(maDM);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDanhMuc.DataSource = listCategory;
                        listCategory.DataSource = cate.loadCategory();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {


                
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        cate.repairCategory(maDM,txtTenDM.Text);
                        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDanhMuc.DataSource = listCategory;
                        listCategory.DataSource = cate.loadCategory();

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
                    dgvDanhMuc.DataSource = listCategory;
                    listCategory.DataSource = cate.findCategory(txtTim.Text);
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