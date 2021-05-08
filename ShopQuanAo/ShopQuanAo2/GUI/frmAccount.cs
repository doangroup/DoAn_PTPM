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

            //BindingSource();
        }
        private void BindingSource()
        {
            txtTenDN.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "TenDN", true, DataSourceUpdateMode.Never));
            txtLoaiTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            ////True: tự động ép kiểu, ngược lại; Never k thay đổi giá trị, chỉ đi 1 nguồn duy nhất
            //txtTenDN.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "TenDN", true, DataSourceUpdateMode.Never));
            ////txt.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            //txtLoaiTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            
        }
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            

            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvTaiKhoan.DataSource = listAccount;
                listAccount.DataSource = acc.loadAccount();
            }
           
            
            else if (e.Button.Properties.Caption == "Xóa")
            {

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Sản Phẩm: " + txtTenDN.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        acc.deleteAccount(txtTenDN.Text);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvTaiKhoan.DataSource = listAccount;
                        listAccount.DataSource = acc.loadAccount();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dgvTaiKhoan.DataSource = listAccount;
                    listAccount.DataSource = acc.findAccount(txtTim.Text);
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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

       

    }
}