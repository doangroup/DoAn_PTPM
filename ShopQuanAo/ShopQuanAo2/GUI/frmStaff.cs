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
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        StaffDAO st = new StaffDAO();
        BindingSource listStaff = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmStaff()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = listStaff;
            listStaff.DataSource = st.loadStaff();
          
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtNgaySinh.Enabled = false;
            cbGioiTinh.Enabled = false;
            BindingSource();
        }

        private void BindingSource()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtNgaySinh.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvNhanVien.DataSource = listStaff;
                listStaff.DataSource = st.loadStaff();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaNV.Enabled = true;
                txtMaNV.Text = txtTenNV.Text = txtDiaChi.Text = txtSDT.Text = txtNgaySinh.Text = "";
                txtTenNV.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                txtNgaySinh.Enabled = true;
                cbGioiTinh.Enabled = true;
            }
            else if(e.Button.Properties.Caption == "Lưu")
            {

            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                int manv = int.Parse(txtMaNV.Text);
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Nhân Viên: "+txtTenNV.Text+" không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (st.deleteStaff(manv) == true)
                    {
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvNhanVien.DataSource = st.loadStaff();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Nhân Viên để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = st.findStaff(txtTim.Text);
                txtTim.Text = "";
            }
        }
    }
}