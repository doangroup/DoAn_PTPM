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
            txtLoaiTK.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvNhanVien.DataSource = listStaff;
                listStaff.DataSource = st.loadStaff();
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                int maNV = int.Parse(txtMaNV.Text);
                 
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        st.deleteStaff(maNV);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvNhanVien.DataSource = listStaff;
                        listStaff.DataSource = st.loadStaff();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {
                
               
                int maNV = int.Parse(txtMaNV.Text);
                int sDT = int.Parse(txtSDT.Text);
                string gioiTinh = cbGioiTinh.Text;

                DateTime dt = Convert.ToDateTime(txtNgaySinh.EditValue);
               
                string ngaySinh = dt.ToString("yyyy-MM-dd");

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    if (txtLoaiTK.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Vui lòng nhập loại tài khoản\nVí Dụ: 1 = Quản lý | 0 = Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtLoaiTK.Focus();
                    }
                    else {
                        int loaiTK = int.Parse(txtLoaiTK.Text);
                        try { 
                            st.repairStaff(maNV, txtTenNV.Text, gioiTinh, txtDiaChi.Text, sDT, ngaySinh, loaiTK);
                            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvNhanVien.DataSource = listStaff;
                            listStaff.DataSource = st.loadStaff();

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Nhân Viên để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    dgvNhanVien.DataSource = listStaff;
                    listStaff.DataSource = st.findStaff(txtTim.Text);
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