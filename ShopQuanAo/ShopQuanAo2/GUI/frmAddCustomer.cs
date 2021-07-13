using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
using System;
using System.Windows.Forms;
namespace ShopQuanAo2.GUI
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private CustomerDAO ct = new CustomerDAO();

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
            if (txtTenKH.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSDT.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin Khách Hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    loadDGV(); XtraMessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Thêm thất bại! - Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}