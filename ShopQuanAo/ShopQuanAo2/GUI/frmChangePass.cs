using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopQuanAo2.View;
using ShopQuanAo2.DTO;
using ShopQuanAo2.DAO;
namespace ShopQuanAo2.GUI
{
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        private Staff acc;

        public Staff Acc
        {
            get { return acc; }
            set { acc = value; changeAcount(Acc); }
        }
        void changeAcount(Staff acc)
        {
            txtUserName.Text = acc.TenDN;
        }
        public frmChangePass(Staff ac)
        {
            InitializeComponent();
            this.Acc = ac;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmRegister rg = new frmRegister();
            rg.Show();
            this.Hide();
        }
        StaffDAO adao = new StaffDAO();
        private void simpleButton1_Click(object sender, EventArgs e)
        {          
            try
            {
                if (adao.checkPassword(txtUserName.Text.Trim(),MaHoaMD5.MD5Hash(txtPassword.Text.Trim()))==true)
                {
                    if (txtRePassword.Text.Trim().Equals(txtNewPassword.Text.Trim()))
                    {
                        
                        adao.repairPassAccount(txtUserName.Text.Trim(), MaHoaMD5.MD5Hash(txtNewPassword.Text.Trim()));
                        XtraMessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Sai mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đổi mật khẩu thất bại! - Lỗi " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtRePassword.Properties.PasswordChar = (txtRePassword.Properties.PasswordChar == '*') ? '\0' : '*';
            txtNewPassword.Properties.PasswordChar = (txtNewPassword.Properties.PasswordChar == '*') ? '\0' : '*';
            txtPassword.Properties.PasswordChar = (txtPassword.Properties.PasswordChar == '*') ? '\0' : '*';
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}