namespace ShopQuanAo2.GUI
{
    partial class frmSellProductInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellProductInfo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgvInHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTienKhachDua = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTienThua = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienKhachDua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTongTien);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", global::ShopQuanAo2.Properties.Resources.calculator_add_icon3)});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1108, 670);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTienThua);
            this.layoutControl1.Controls.Add(this.txtTienKhachDua);
            this.layoutControl1.Controls.Add(this.dgvInHoaDon);
            this.layoutControl1.Controls.Add(this.cbSanPham);
            this.layoutControl1.Controls.Add(this.txtMaHD);
            this.layoutControl1.Controls.Add(this.txtSoLuong);
            this.layoutControl1.Controls.Add(this.txtGia);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1104, 619);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgvInHoaDon
            // 
            this.dgvInHoaDon.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvInHoaDon.Location = new System.Drawing.Point(131, 256);
            this.dgvInHoaDon.MainView = this.gridView1;
            this.dgvInHoaDon.Name = "dgvInHoaDon";
            this.dgvInHoaDon.Size = new System.Drawing.Size(957, 347);
            this.dgvInHoaDon.TabIndex = 11;
            this.dgvInHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvInHoaDon.DataSourceChanged += new System.EventHandler(this.dgvInHoaDon_DataSourceChanged);
            this.dgvInHoaDon.DefaultViewChanged += new System.EventHandler(this.dgvInHoaDon_DefaultViewChanged);
            this.dgvInHoaDon.ClientSizeChanged += new System.EventHandler(this.dgvInHoaDon_ClientSizeChanged);
            this.dgvInHoaDon.CursorChanged += new System.EventHandler(this.dgvInHoaDon_CursorChanged);
            this.dgvInHoaDon.DockChanged += new System.EventHandler(this.dgvInHoaDon_DockChanged);
            this.dgvInHoaDon.TextChanged += new System.EventHandler(this.dgvInHoaDon_TextChanged);
            this.dgvInHoaDon.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.dgvInHoaDon_ControlAdded);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.dgvInHoaDon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbSanPham
            // 
            this.cbSanPham.Location = new System.Drawing.Point(131, 56);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSanPham.Properties.Appearance.Options.UseFont = true;
            this.cbSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSanPham.Size = new System.Drawing.Size(957, 34);
            this.cbSanPham.StyleController = this.layoutControl1;
            this.cbSanPham.TabIndex = 8;
            this.cbSanPham.EditValueChanged += new System.EventHandler(this.cbSanPham_EditValueChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(131, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Properties.Appearance.Options.UseFont = true;
            this.txtMaHD.Size = new System.Drawing.Size(957, 34);
            this.txtMaHD.StyleController = this.layoutControl1;
            this.txtMaHD.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(131, 96);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(957, 34);
            this.txtSoLuong.StyleController = this.layoutControl1;
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(131, 136);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(957, 34);
            this.txtGia.StyleController = this.layoutControl1;
            this.txtGia.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1104, 619);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaHD;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem4.Text = "Hóa Đơn";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbSanPham;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem1.Text = "Sản Phẩm";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(111, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSoLuong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem3.Text = "Số Lượng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGia;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem2.Text = "Giá";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dgvInHoaDon;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1078, 353);
            this.layoutControlItem5.Text = "Thông Tin Chi Tiết";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 17);
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Enabled = false;
            this.txtTienKhachDua.Location = new System.Drawing.Point(131, 176);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienKhachDua.Properties.Appearance.Options.UseFont = true;
            this.txtTienKhachDua.Size = new System.Drawing.Size(957, 34);
            this.txtTienKhachDua.StyleController = this.layoutControl1;
            this.txtTienKhachDua.TabIndex = 12;
            this.txtTienKhachDua.EditValueChanged += new System.EventHandler(this.txtTienKhachDua_EditValueChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtTienKhachDua;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem6.Text = "Tiền Khách Đưa";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(111, 17);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Location = new System.Drawing.Point(131, 216);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienThua.Properties.Appearance.Options.UseFont = true;
            this.txtTienThua.Size = new System.Drawing.Size(957, 34);
            this.txtTienThua.StyleController = this.layoutControl1;
            this.txtTienThua.TabIndex = 13;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTienThua;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1078, 40);
            this.layoutControlItem7.Text = "Tiền Thối";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(111, 17);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(487, 9);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Appearance.Options.UseForeColor = true;
            this.txtTongTien.Size = new System.Drawing.Size(245, 34);
            this.txtTongTien.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(363, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tổng Tiền";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Khách Hàng";
            this.gridColumn1.FieldName = "TenKH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Nhân Viên";
            this.gridColumn2.FieldName = "TenNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Sản Phẩm";
            this.gridColumn3.FieldName = "TenSP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày Bán";
            this.gridColumn4.FieldName = "NgayBan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lượng";
            this.gridColumn5.FieldName = "SoLuong";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá Bán";
            this.gridColumn6.FieldName = "ThanhTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tổng Tiền";
            this.gridColumn7.FieldName = "TongTien";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // frmSellProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 670);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellProductInfo";
            this.Text = "Chi Tiết Đơn Hàng";
            this.Load += new System.EventHandler(this.frmSellProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienKhachDua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cbSanPham;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl dgvInHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.TextEdit txtTienThua;
        private DevExpress.XtraEditors.TextEdit txtTienKhachDua;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}