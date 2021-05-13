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
    public partial class frmBill : DevExpress.XtraEditors.XtraForm
    {
        BillDAO bill = new BillDAO();
        StaffDAO staff = new StaffDAO();
        ProductDAO pd = new ProductDAO();
        CustomerDAO ct = new CustomerDAO();

        BindingSource listBill = new BindingSource();
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = listBill;
            listBill.DataSource = bill.loadBill();

            cbKhachHang.Properties.DataSource = ct.loadCustomer();
            cbKhachHang.Properties.DisplayMember = "TenKH";
            cbKhachHang.Properties.ValueMember = "MaKH";

            cbNhanVien.Properties.DataSource = staff.loadStaff();
            cbNhanVien.Properties.DisplayMember = "TenNV";
            cbNhanVien.Properties.ValueMember = "MaNV";

            cbSanPham.Properties.DataSource = pd.loadProduct();
            cbSanPham.Properties.DisplayMember = "TenSP";
            cbSanPham.Properties.ValueMember = "MaSP";

            BindingSource();
        }
        private void BindingSource()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
            cbKhachHang.DataBindings.Add(new Binding("EditValue", dgvHoaDon.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            cbNhanVien.DataBindings.Add(new Binding("EditValue", dgvHoaDon.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            cbSanPham.DataBindings.Add(new Binding("EditValue", dgvHoaDon.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtNgayBan.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "NgayBan", true, DataSourceUpdateMode.Never));
            txtTongTien.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TongTien", true, DataSourceUpdateMode.Never));

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
            
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvHoaDon.DataSource = listBill;
                listBill.DataSource = bill.loadBill();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaHD.Text = "";
                
                txtNgayBan.Text = "";
                txtMaHD.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 

                int maHD = int.Parse(txtMaHD.Text);
                int maKH = int.Parse(cbKhachHang.EditValue.ToString());
                int MaNV = int.Parse(cbNhanVien.EditValue.ToString());
                int maSP = int.Parse(cbSanPham.EditValue.ToString());
                if (bill.checkPrimarykey(maHD) == true)
                {
                    DialogResult dl = XtraMessageBox.Show("Mã hóa đơn trùng với mã đã có bán có muốn sửa cho Mã Hóa Đơn: " + txtMaHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        try
                        {
                            bill.repairBill(maHD, maKH,MaNV,maSP,txtNgayBan.SelectedText.ToString());
                            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvHoaDon.DataSource = listBill;
                            listBill.DataSource = bill.loadBill();

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại! Lỗi - Trùng mã danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Không trùng mã thì sẽ thêm vào
                else
                {
                    double tongtien = double.Parse(txtTongTien.Text);
                    try
                    {
                        bill.addBill(maHD, maKH,MaNV,maSP,txtNgayBan.SelectedText.ToString(),tongtien);
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvHoaDon.DataSource = listBill;
                        listBill.DataSource = bill.loadBill();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                int maHD = int.Parse(txtMaHD.Text);
                
                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Hóa Đơn: " + txtMaHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        bill.deleteBill(maHD);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvHoaDon.DataSource = listBill;
                        listBill.DataSource = bill.loadBill();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Sửa")
            {
                int maHD = int.Parse(txtMaHD.Text);
                int maKH = int.Parse(cbKhachHang.EditValue.ToString());
                int MaNV = int.Parse(cbNhanVien.EditValue.ToString());
                int maSP = int.Parse(cbSanPham.EditValue.ToString());


                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        bill.repairBill(maHD, maKH,MaNV,maSP,txtNgayBan.SelectedText.ToString());
                        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvHoaDon.DataSource = listBill;
                        listBill.DataSource = bill.loadBill();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Tìm Kiếm Theo Tên Khách Hàng")
            {
                if (txtTim.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên Khách Hàng để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    int maHD = int.Parse(txtTim.Text);
                    dgvHoaDon.DataSource = listBill;                
                    listBill.DataSource = bill.findBill(maHD);
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