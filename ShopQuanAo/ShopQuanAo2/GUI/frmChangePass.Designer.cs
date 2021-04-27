namespace ShopQuanAo2.GUI
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangePass = new DevExpress.XtraEditors.SimpleButton();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRePassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtRePassword);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtNewPassword);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnRegister);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnChangePass);
            this.groupControl1.Controls.Add(this.btnOut);
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(824, 363);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Đổi mật khẩu";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(209, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 36);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(398, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(290, 34);
            this.txtPassword.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(12, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(348, 36);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(398, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(290, 34);
            this.txtUserName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(12, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(191, 36);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật Khẩu Cũ";
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(344, 247);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(233, 69);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangePass.Appearance.Options.UseFont = true;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.Location = new System.Drawing.Point(51, 247);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(268, 69);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Đổi Mật Khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnOut
            // 
            this.btnOut.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Appearance.Options.UseFont = true;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(609, 247);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(158, 69);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Thoát";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Location = new System.Drawing.Point(12, 121);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(207, 36);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Mật Khẩu Mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(398, 125);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewPassword.Properties.Appearance.Options.UseFont = true;
            this.txtNewPassword.Size = new System.Drawing.Size(290, 34);
            this.txtNewPassword.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(225, 121);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(19, 36);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 36);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tài Khoản";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(366, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 36);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "*";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(398, 167);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRePassword.Properties.Appearance.Options.UseFont = true;
            this.txtRePassword.Size = new System.Drawing.Size(290, 34);
            this.txtRePassword.TabIndex = 18;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 363);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnChangePass;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtRePassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}