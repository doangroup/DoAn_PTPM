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
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.GUI
{
    public partial class frmSellProductInfo : DevExpress.XtraEditors.XtraForm
    {
        ProductDAO pd = new ProductDAO();
        BillInfoDAO info = new BillInfoDAO();
        BillCustomerDAO billCT = new BillCustomerDAO();
        BillDAO bill = new BillDAO();
        string mahd2;

        
        //void bill2(Bill bill)
        //{

        //    txtMaHD.Text = bill.MaHD.ToString();

        //}
        public frmSellProductInfo()
        {
            InitializeComponent();
            
        }
        public frmSellProductInfo(string mahd):this()
        {

            mahd2 = mahd;
            txtMaHD.Text = mahd2;
            
        }
        private void BindingSource()
        {
            txtTongTien.DataBindings.Add(new Binding("Text", dgvInHoaDon.DataSource, "TongTien", true, DataSourceUpdateMode.Never));
        }
        private void frmSellProductInfo_Load(object sender, EventArgs e)
        {
            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";
            cbSanPham.ItemIndex = 0;
            txtGia.Enabled = false;
            int maHD = int.Parse(txtMaHD.Text);
            
            
            //BindingSource();
        }

        private void cbSanPham_EditValueChanged(object sender, EventArgs e)
        {
            int maSP = int.Parse(cbSanPham.EditValue.ToString());
            txtGia.Text = pd.loadPriceByProductID(maSP).ToString();
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
           
            int maSP = int.Parse(cbSanPham.EditValue.ToString());
            int maHD = int.Parse(txtMaHD.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double giaBan = double.Parse(txtGia.Text);
            if (e.Button.Properties.Caption == "Thêm")
            {
                info.addBillInfo(maHD, maSP, soLuong, giaBan);
                dgvInHoaDon.DataSource = billCT.loadBillCustomer(maHD);
                txtTienKhachDua.Enabled = true;
            }
            //int maHD = int.Parse(txtMaHD.Text);
            txtTongTien.Text = bill.loadTotal(maHD).ToString();
        }

        private void txtTienKhachDua_EditValueChanged(object sender, EventArgs e)
        {
            double khachDua = double.Parse(txtTienKhachDua.Text);
            double tongTien = double.Parse(txtTongTien.Text);
            txtTienThua.Text = (khachDua - tongTien).ToString();
        }

        private void dgvInHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvInHoaDon_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void dgvInHoaDon_ClientSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvInHoaDon_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvInHoaDon_DefaultViewChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvInHoaDon_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvInHoaDon_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}