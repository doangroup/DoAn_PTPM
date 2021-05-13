namespace ShopQuanAo2.GUI
{
    partial class frmSellProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellProduct));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAddBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.cbSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.cbKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNgayBan = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(581, 282);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bán Hàng";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbNhanVien);
            this.layoutControl1.Controls.Add(this.btnAddBill);
            this.layoutControl1.Controls.Add(this.btnAddCustomer);
            this.layoutControl1.Controls.Add(this.cbSanPham);
            this.layoutControl1.Controls.Add(this.cbKhachHang);
            this.layoutControl1.Controls.Add(this.txtNgayBan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(577, 255);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Image = global::ShopQuanAo2.Properties.Resources.document_add_icon;
            this.btnAddBill.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAddBill.Location = new System.Drawing.Point(16, 146);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(545, 93);
            this.btnAddBill.StyleController = this.layoutControl1;
            this.btnAddBill.TabIndex = 14;
            this.btnAddBill.Text = "Tạo Hóa Đơn";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddCustomer.Location = new System.Drawing.Point(291, 16);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(270, 40);
            this.btnAddCustomer.StyleController = this.layoutControl1;
            this.btnAddCustomer.TabIndex = 13;
            this.btnAddCustomer.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbSanPham
            // 
            this.cbSanPham.Location = new System.Drawing.Point(87, 90);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSanPham.Size = new System.Drawing.Size(474, 22);
            this.cbSanPham.StyleController = this.layoutControl1;
            this.cbSanPham.TabIndex = 11;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Location = new System.Drawing.Point(87, 16);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKhachHang.Size = new System.Drawing.Size(198, 22);
            this.cbKhachHang.StyleController = this.layoutControl1;
            this.cbKhachHang.TabIndex = 10;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.EditValue = null;
            this.txtNgayBan.Location = new System.Drawing.Point(87, 118);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBan.Properties.DisplayFormat.FormatString = "";
            this.txtNgayBan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBan.Properties.EditFormat.FormatString = "";
            this.txtNgayBan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBan.Properties.Mask.EditMask = "";
            this.txtNgayBan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayBan.Size = new System.Drawing.Size(474, 22);
            this.txtNgayBan.StyleController = this.layoutControl1;
            this.txtNgayBan.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(577, 255);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNgayBan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(551, 28);
            this.layoutControlItem5.Text = "Ngày Bán";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbKhachHang;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(275, 46);
            this.layoutControlItem2.Text = "Khách Hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbSanPham;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(551, 28);
            this.layoutControlItem4.Text = "Sản Phẩm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAddCustomer;
            this.layoutControlItem6.Location = new System.Drawing.Point(275, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(276, 46);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAddBill;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(551, 99);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Location = new System.Drawing.Point(87, 62);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNhanVien.Size = new System.Drawing.Size(474, 22);
            this.cbNhanVien.StyleController = this.layoutControl1;
            this.cbNhanVien.TabIndex = 15;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbNhanVien;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(551, 28);
            this.layoutControlItem3.Text = "Nhân Viên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 16);
            // 
            // frmSellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 282);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSellProduct";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmSellProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cbSanPham;
        private DevExpress.XtraEditors.LookUpEdit cbKhachHang;
        private DevExpress.XtraEditors.DateEdit txtNgayBan;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnAddBill;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit cbNhanVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}