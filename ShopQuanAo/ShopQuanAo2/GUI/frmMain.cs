using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopQuanAo2.View;
namespace ShopQuanAo2
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            btnLogout.Enabled = true;
            btnChangePass.Enabled = true;
            
        }
        
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
