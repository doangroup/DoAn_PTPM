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
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerDAO ct = new CustomerDAO();

        
        
        public frmAddCustomer()
        {
            InitializeComponent();
            
        }
       
       
        private void frmSellProductInfo_Load(object sender, EventArgs e)
        {
            
            
            
            //BindingSource();
        }

        private void cbSanPham_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
           
           
            if (e.Button.Properties.Caption == "Thêm")
            {
                try
                {
                    ct.addCustomer(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void txtTienKhachDua_EditValueChanged(object sender, EventArgs e)
        {
           
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