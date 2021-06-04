using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ShopQuanAo2.DAO;
using ShopQuanAo2.GUI;
using ShopQuanAo2.View;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        ProductDAO pd = new ProductDAO();
        private Staff acc;

        public Staff Acc
        {
            get { return acc; }
            set { acc = value; phanQuyen(Acc.LoaiTK); }
        }
        void phanQuyen(int loaiTK)
        {
            btnRegister.Enabled = btnSanPham.Enabled = btnTaiKhoan.Enabled = btnDanhMuc.Enabled = btnKhachHang.Enabled = btnNhanVien.Enabled = barButtonItem2.Enabled = barButtonItem6.Enabled = btnHoaDon.Enabled = btnCTHD.Enabled = loaiTK == 1;

        }
        public frmMain(Staff acc)
        {
            InitializeComponent();
            this.Acc = acc;
        }
      

        private Form checkExit(Type type)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == type)
                {
                    return item;
                }
            }
            return null;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
            
            Form frm = this.checkExit(typeof(frmProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProduct product = new frmProduct();
                product.MdiParent = this;
                product.Show();
            }

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
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.Show();
            lg.txtUsername.Text = "";
            lg.txtPassword.Text = "";
        }

        private void groupControl2_Click(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAbout about = new frmAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmStaff));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmStaff staff = new frmStaff();
                staff.MdiParent = this;
                staff.Show();
            }
           

            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProduct product = new frmProduct();
                product.MdiParent = this;
                product.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCategory cate = new frmCategory();
                cate.MdiParent = this;
                cate.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmCustomer));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCustomer ct = new frmCustomer();
                ct.MdiParent = this;
                ct.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePass change = new frmChangePass(Acc);
            change.ShowDialog();
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmBill));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBill bill = new frmBill();
                bill.MdiParent = this;
                bill.Show();
            }
        }

        private void btnCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmBillInfo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBillInfo billInfo = new frmBillInfo();
                billInfo.MdiParent = this;
                billInfo.Show();
            }
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmSellProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSellProduct sell = new frmSellProduct(Acc);
                sell.MdiParent = this;
                sell.Show();
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmAddProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmAddProduct sell = new frmAddProduct();
                sell.MdiParent = this;
                sell.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmAddProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmAddProduct sell = new frmAddProduct();
                sell.MdiParent = this;
                sell.Show();
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmSellProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSellProduct sell = new frmSellProduct(Acc);
                sell.MdiParent = this;
                sell.Show();
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmAddCustomer));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmAddCustomer sell = new frmAddCustomer();
                sell.MdiParent = this;
                sell.Show();
            }
        }
    }
}
