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
using DevExpress.XtraEditors.Controls;
namespace ShopQuanAo2.GUI
{
    public partial class frmBillInfo : DevExpress.XtraEditors.XtraForm
    {
        BillInfoDAO billInfo = new BillInfoDAO();
        ProductDAO pd = new ProductDAO();
        BindingSource listBillInfo = new BindingSource();
        public frmBillInfo()
        {
            InitializeComponent();
        }

        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            dgvChiTIetHD.DataSource = listBillInfo;
            listBillInfo.DataSource = billInfo.loadBillInfo();


            cbTinhTrang.SelectedItem = 1;
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
            cbTinhTrang.DataBindings.Add(new Binding("Text", dgvChiTIetHD.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            cbSanPham.DataBindings.Add(new Binding("EditValue", dgvChiTIetHD.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
       

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                dgvChiTIetHD.DataSource = listBillInfo;
                listBillInfo.DataSource = billInfo.loadBillInfo();
            }
            else if (e.Button.Properties.Caption == "Thêm")
            {
                txtMaHD.Text = "";
                
                txtSoLuong.Text = "0";
                txtMaHD.Focus();
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {
                //Kiểm tra khóa chính nếu trùng thì sẽ hỏi có sửa k? nếu k thì t.b lỗi
                // nếu có sẽ sửa 
                //Chưa xong phần kiểm tra khóa chính để hỏi Sửa 

                int maHD = int.Parse(txtMaHD.Text);
                int soLuong = int.Parse(txtSoLuong.Text);
                double thanhTien = double.Parse(txtThanhTien.Text);
                int macthd = int.Parse(txtMaCTHD.Text);
                int tinhTrang = int.Parse(cbTinhTrang.SelectedText.ToString());
                if (billInfo.checkPrimarykey(maHD) == true)
                {
                    DialogResult dl = XtraMessageBox.Show("Mã hóa đơn trùng với mã đã có bán có muốn sửa cho Mã Hóa Đơn: " + txtMaHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        try
                        {
                            billInfo.repairBillInfo(macthd, maHD, soLuong, thanhTien, tinhTrang);
                            XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvChiTIetHD.DataSource = listBillInfo;
                            listBillInfo.DataSource = billInfo.loadBillInfo();

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
                    int maSP = int.Parse(cbSanPham.EditValue.ToString());
                    try
                    {
                        billInfo.addBillInfo(maHD, maSP,soLuong, thanhTien);
                        XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvChiTIetHD.DataSource = listBillInfo;
                        listBillInfo.DataSource = billInfo.loadBillInfo();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.Button.Properties.Caption == "Xóa")
            {
                int maCTHD = int.Parse(txtMaCTHD.Text);

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn xóa Hóa Đơn: " + txtMaHD.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        billInfo.deleteBillInfo(maCTHD);
                        XtraMessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvChiTIetHD.DataSource = listBillInfo;
                        listBillInfo.DataSource = billInfo.loadBillInfo();
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
                int soLuong = int.Parse(txtSoLuong.Text);
                double thanhTien = double.Parse(txtThanhTien.Text);
                int tinhTrang = int.Parse(cbTinhTrang.SelectedText.ToString());
                int maCTHD = int.Parse(txtMaCTHD.Text);

                DialogResult dl = XtraMessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    try
                    {
                        billInfo.repairBillInfo(maCTHD, maHD, soLuong, thanhTien, tinhTrang);
                        XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvChiTIetHD.DataSource = listBillInfo;
                        listBillInfo.DataSource = billInfo.loadBillInfo();

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Sửa thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
        //public void loadStatus()
        //{
        //    StatusBillInfoDAO st = new StatusBillInfoDAO();
        //    st.Add(new StatusBillInfo(0, "Chưa thanh Toán"));
        //    st.Add(new StatusBillInfo(1, "Đã Thanh Toán"));


        //    //bind the lookup editor to the list
        //    cbTinhTrang.Properties.DataSource = st;
        //    cbTinhTrang.Properties.DisplayMember = "Name";
        //    cbTinhTrang.Properties.ValueMember = "Id";
        //     //Add columns.
        //     //The ID column is populated 
        //     //via the GetNotInListValue event (not listed in the example).
        //    cbTinhTrang.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
        //    cbTinhTrang.Properties.Columns.Add(new LookUpColumnInfo("Name", "TinhTrang", 80));
        //    //enable text editing
        //    cbTinhTrang.Properties.TextEditStyle = TextEditStyles.Standard;
        //}
    }
}