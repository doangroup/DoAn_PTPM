using DevExpress.XtraEditors;
using ShopQuanAo2.DAO;
using System;
using System.Windows.Forms;
namespace ShopQuanAo2.GUI
{
    public partial class frmBillInfo : DevExpress.XtraEditors.XtraForm
    {
        private BillInfoDAO billInfo = new BillInfoDAO();
        private ProductDAO pd = new ProductDAO();
        private BindingSource listBillInfo = new BindingSource();
        public frmBillInfo()
        {
            InitializeComponent();
        }

        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            dgvChiTIetHD.DataSource = listBillInfo;
            listBillInfo.DataSource = billInfo.loadBillInfo();



            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";
            //loadStatus();
            BindingSource();
        }
        private void BindingSource()
        {
            txtMaCTHD.DataBindings.Add(new Binding("Text", dgvChiTIetHD.DataSource, "MaCTHD", true, DataSourceUpdateMode.Never));
            txtMaHD.DataBindings.Add(new Binding("Text", dgvChiTIetHD.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvChiTIetHD.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtThanhTien.DataBindings.Add(new Binding("Text", dgvChiTIetHD.DataSource, "ThanhTien", true, DataSourceUpdateMode.Never));

            cbSanPham.DataBindings.Add(new Binding("EditValue", dgvChiTIetHD.DataSource, "MaSP", true, DataSourceUpdateMode.Never));


        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvChiTIetHD.DataSource = listBillInfo;
                listBillInfo.DataSource = billInfo.loadBillInfo();
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Mã Hóa Đơn")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Khách Hàng để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    int maHD = int.Parse(txtTim.Text);
                    dgvChiTIetHD.DataSource = listBillInfo;
                    listBillInfo.DataSource = billInfo.findBillInfo(maHD);
                    txtTim.Text = "";
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Tìm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (e.Button.Properties.Caption == "Xuất Word")
            {
            }
            else if (e.Button.Properties.Caption == "Xuất Excel")
            {
            }
        }
        
    }
}