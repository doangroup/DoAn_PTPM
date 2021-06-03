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
namespace ShopQuanAo2.GUI
{
    public partial class frmAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        CategoryDAO ct = new CategoryDAO();
        ProductDAO pd = new ProductDAO();
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = ct.loadCategory();
          
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
            //int madm = int.Parse(gridView2.GetFocusedDataRow()["MaDM"].ToString());



        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int madm = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaDM").ToString());
            dgvSanPham.DataSource = pd.loadProductByCategoryID(madm);
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }
    }
}