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
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        CategoryDAO cate= new CategoryDAO();
        BindingSource listCategory = new BindingSource();
        //Tránh mất dữ liệu gốc khi binding qua textbox
        //Hạn chế lỗi mất kêt nối Binding - Nguồn: K Team
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = listCategory;
            listCategory.DataSource = cate.loadCategory();

            txtMaDM.Enabled = false;
            txtTenDM.Enabled = false;
            
            BindingSource();
        }

        private void BindingSource()
        {
            txtMaDM.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            txtTenDM.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "TenDM", true, DataSourceUpdateMode.Never));
           
        }
    }
}