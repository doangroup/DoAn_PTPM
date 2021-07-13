using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
using ShopQuanAo2.DTO;
using System;
using System.Windows.Forms;
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
            DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private StaffDAO acount = new StaffDAO();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (acount.login(txtUsername.Text, MaHoaMD5.MD5Hash(txtPassword.Text)) == true)
            {
                Staff acc = acount.getAcountByUsername(txtUsername.Text);
                frmMain b = new frmMain(acc);
                this.Hide();
                b.ShowDialog();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            txtPassword.Properties.PasswordChar = (txtPassword.Properties.PasswordChar == '*') ? '\0' : '*';
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}