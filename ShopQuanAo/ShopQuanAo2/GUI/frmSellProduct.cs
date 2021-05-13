using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShopQuanAo2.GUI
{
    public partial class frmSellProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmSellProduct()
        {
            InitializeComponent();
        }

        private void btnKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void lookUpEdit1_Properties_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddCusmer ct = new frmAddCusmer();
            ct.ShowDialog();
        }
    }
}