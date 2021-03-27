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
namespace ShopQuanAo2.View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rs == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
        AcountDAO acount = new AcountDAO();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (acount.login(txtUsername.Text, txtPassword.Text) == true)
            {
                XtraMessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}