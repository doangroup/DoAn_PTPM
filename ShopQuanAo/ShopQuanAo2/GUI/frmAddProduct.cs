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
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.GUI
{
    public partial class frmAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        BindingSource listCate = new BindingSource();
        CategoryDAO ct = new CategoryDAO();
        ProductDAO pd = new ProductDAO();
        private void frmAddProduct_Load(object sender, EventArgs e)
        {


            groupControl3.Enabled = false;
            dgvDanhMuc.DataSource = listCate;
            listCate.DataSource = ct.loadCategory();
            BindingSource();
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
            //int madm = int.Parse(gridView2.GetFocusedDataRow()["MaDM"].ToString());



        }
        private void BindingSource()
        {
            txtMaDM.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int madm = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaDM").ToString());
            dgvSanPham.DataSource = pd.loadProductByCategoryID(madm);
            groupControl3.Enabled = true;
            //BindingSource();
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                ct.addCategory(txtTenDM.Text.Trim());
                dgvDanhMuc.DataSource = listCate;
                listCate.DataSource = ct.loadCategory();
                dgvSanPham.DataSource = pd.loadProductByCategoryName(txtTenDM.Text.Trim());
               
                txtMaDM.Text = ct.loadCategoryLastID().ToString();
                XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupControl3.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(txtSoLuong.Text);
                double dongia = double.Parse(txtDonGia.Text);
                int madm = int.Parse(txtMaDM.Text);
                pd.addProduct(madm, txtTenSP.Text, soluong, dongia, txtGhiChu.Text);
                dgvSanPham.DataSource = pd.loadProductByCategoryID(madm);
                XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenSP.Text = "";
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                txtGhiChu.Text = "";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Thêm thất bại ! Lỗi - " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}