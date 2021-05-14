using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ShopQuanAo2.DAO;
namespace ShopQuanAo2.View
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        StaffDAO st = new StaffDAO();

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cbLoaiTK.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            txtMatKhau.Properties.PasswordChar = (txtMatKhau.Properties.PasswordChar == '*') ? '\0' : '*';
            txtNhapLaiMK.Properties.PasswordChar = (txtNhapLaiMK.Properties.PasswordChar == '*') ? '\0' : '*';


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void RePassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int loatk = int.Parse(cbLoaiTK.SelectedItem.ToString());
           
            int sDT = int.Parse(txtSDT.Text);
            string ngaySinh = txtNgaySinh.ToString();
            try
            {
                if (txtNhapLaiMK.Text.Trim().Equals(txtMatKhau.Text.Trim()))
                {
                    st.addStaff2(txtTenNV.Text.Trim(), cbGioiTinh.SelectedItem.ToString().Trim(), txtDiaChi.Text.Trim(), sDT, txtNgaySinh.Text, txtTaiKhoan.Text.Trim(), MaHoaMD5.MD5Hash(txtNhapLaiMK.Text).ToString(), loatk);
                    XtraMessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    XtraMessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đăng ký thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }
    }
}