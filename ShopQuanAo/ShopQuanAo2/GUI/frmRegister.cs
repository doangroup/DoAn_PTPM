using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShopQuanAo2.View
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
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

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}