using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
namespace ShopQuanAo2.GUI
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        CustomerDAO ct = new CustomerDAO();

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            loadDGV();
        }
        public void loadDGV()
        {
            dgvKhachHang.DataSource = ct.loadCustomer();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                loadDGV(); XtraMessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Thêm thất bại! - Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}