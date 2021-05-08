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
    public partial class frmAccount2 : DevExpress.XtraEditors.XtraForm
    {
        AcountDAO acc = new AcountDAO();
        BindingSource listAccount = new BindingSource();
        public frmAccount2()
        {
            InitializeComponent();
        }

        private void frmAccount2_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = listAccount;
            listAccount.DataSource = acc.loadAccount();
        }
    }
}