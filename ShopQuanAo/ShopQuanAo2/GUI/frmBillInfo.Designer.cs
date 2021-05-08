namespace ShopQuanAo2.GUI
{
    partial class frmBillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillInfo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTim = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbTinhTrang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.dgvChiTIetHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTIetHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1061, 677);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thao Tác";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTim);
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tải Lại", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons3")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons4")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất Word", global::ShopQuanAo2.Properties.Resources.Word_icon),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất Excel", global::ShopQuanAo2.Properties.Resources.Excel_icon),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tìm Kiếm Theo Mã Hóa Đơn", ((System.Drawing.Image)(resources.GetObject("groupControl2.CustomHeaderButtons5"))))});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupControl2.Location = new System.Drawing.Point(2, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1057, 650);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl2_CustomButtonClick);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(809, 3);
            this.txtTim.Name = "txtTim";
            this.txtTim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTim.Properties.Appearance.Options.UseFont = true;
            this.txtTim.Size = new System.Drawing.Size(238, 40);
            this.txtTim.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtThanhTien);
            this.layoutControl1.Controls.Add(this.cbTinhTrang);
            this.layoutControl1.Controls.Add(this.txtMaHD);
            this.layoutControl1.Controls.Add(this.dgvChiTIetHD);
            this.layoutControl1.Controls.Add(this.txtSoLuong);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(860, 464, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1053, 599);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Location = new System.Drawing.Point(604, 16);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTinhTrang.Size = new System.Drawing.Size(433, 22);
            this.cbTinhTrang.StyleController = this.layoutControl1;
            this.cbTinhTrang.TabIndex = 15;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(90, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(434, 22);
            this.txtMaHD.StyleController = this.layoutControl1;
            this.txtMaHD.TabIndex = 13;
            // 
            // dgvChiTIetHD
            // 
            this.dgvChiTIetHD.Location = new System.Drawing.Point(16, 72);
            this.dgvChiTIetHD.MainView = this.gridView1;
            this.dgvChiTIetHD.Name = "dgvChiTIetHD";
            this.dgvChiTIetHD.Size = new System.Drawing.Size(1021, 511);
            this.dgvChiTIetHD.TabIndex = 11;
            this.dgvChiTIetHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.dgvChiTIetHD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Hóa Đơn";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "MaHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Lượng";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thành Tiền";
            this.gridColumn3.FieldName = "ThanhTien";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 106;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tình Trạng";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TinhTrang";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 120;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1053, 599);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dgvChiTIetHD;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1027, 517);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSoLuong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(513, 28);
            this.layoutControlItem1.Text = "Số Lượng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaHD;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(514, 28);
            this.layoutControlItem2.Text = "Mã Hóa Đơn";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbTinhTrang;
            this.layoutControlItem4.Location = new System.Drawing.Point(514, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(513, 28);
            this.layoutControlItem4.Text = "Tình Trạng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 17);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(603, 44);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Mask.EditMask = "c";
            this.txtThanhTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtThanhTien.Size = new System.Drawing.Size(434, 22);
            this.txtThanhTien.StyleController = this.layoutControl1;
            this.txtThanhTien.TabIndex = 16;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtThanhTien;
            this.layoutControlItem3.Location = new System.Drawing.Point(513, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(514, 28);
            this.layoutControlItem3.Text = "Thành Tiền";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 17);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(90, 44);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSoLuong.Properties.Mask.EditMask = "n";
            this.txtSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoLuong.Size = new System.Drawing.Size(433, 22);
            this.txtSoLuong.StyleController = this.layoutControl1;
            this.txtSoLuong.TabIndex = 12;
            // 
            // frmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 677);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTIetHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtTim;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cbTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraGrid.GridControl dgvChiTIetHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
    }
}