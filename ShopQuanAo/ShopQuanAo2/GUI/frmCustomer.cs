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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerDAO ct = new CustomerDAO();
       
        BindingSource listCustomer = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = listCustomer;
            listCustomer.DataSource = ct.loadCustomer();
            

            BindingSource();
        }
        private void BindingSource()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
           
            txtTenKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
           
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            int maKH = int.Parse(txtMaKH.Text);
           

            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvKhachHang.DataSource = listCustomer;
                listCustomer.DataSource = ct.loadCustomer();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
           
                txtMaKH.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 
                

                if (ct.checkPrimarykey(maKH) == true)
                {
                    DialogResult dl = XtraMessageBox.Show("Mã khách hàng trùng với mã đã có bán có muốn sửa cho Mã Khách Hàng: " + txtMaKH.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        try
                        {
                            ct.repairCustomer(maKH, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvKhachHang.DataSource = listCustomer;
                            listCustomer.DataSource = ct.loadCustomer();

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại! Lỗi - Trùng mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Không trùng mã thì sẽ thêm vào
                else
                {
                    try
                    {
                        ct.addCustomer(maKH, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvKhachHang.DataSource = listCustomer;
                        listCustomer.DataSource = ct.loadCustomer();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        ct.deleteCustomer(maKH);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvKhachHang.DataSource = listCustomer;
                        listCustomer.DataSource = ct.loadCustomer();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {


               
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        ct.repairCustomer(maKH, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvKhachHang.DataSource = listCustomer;
                        listCustomer.DataSource = ct.loadCustomer();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Khách Hàng để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    dgvKhachHang.DataSource = listCustomer;
                    listCustomer.DataSource = ct.findCustomer(txtTim.Text);
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