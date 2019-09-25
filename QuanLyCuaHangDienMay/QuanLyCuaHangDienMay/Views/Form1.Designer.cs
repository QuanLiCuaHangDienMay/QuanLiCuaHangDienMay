namespace QuanLyCuaHangDienMay
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabHienthi = new DevExpress.XtraTab.XtraTabControl();
            this.rbSStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.imgCL1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienthi)).BeginInit();
            this.tabHienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCL1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.imgCL1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnChangePass,
            this.btnLogout,
            this.btnPhanQuyen,
            this.btnBackup,
            this.btnRestore,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            this.ribbonControl1.StatusBar = this.rbSStatus;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePass);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhanQuyen);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Dữ liệu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Giao diện";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // tabHienthi
            // 
            this.tabHienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHienthi.Location = new System.Drawing.Point(0, 143);
            this.tabHienthi.Name = "tabHienthi";
            this.tabHienthi.Size = new System.Drawing.Size(758, 366);
            this.tabHienthi.TabIndex = 1;
            // 
            // rbSStatus
            // 
            this.rbSStatus.Location = new System.Drawing.Point(1, 341);
            this.rbSStatus.Name = "rbSStatus";
            this.rbSStatus.Ribbon = this.ribbonControl1;
            this.rbSStatus.Size = new System.Drawing.Size(752, 20);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageIndexDisabled = 7;
            this.btnLogin.ImageOptions.DisabledImageIndex = 7;
            this.btnLogin.ImageOptions.ImageIndex = 7;
            this.btnLogin.Name = "btnLogin";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Id = 2;
            this.btnChangePass.ImageOptions.ImageIndex = 0;
            this.btnChangePass.Name = "btnChangePass";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.Name = "btnLogout";
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân Quyền Người Dùng";
            this.btnPhanQuyen.Id = 4;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 5;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi dữ liệu";
            this.btnRestore.Id = 6;
            this.btnRestore.Name = "btnRestore";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // imgCL1
            // 
            this.imgCL1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCL1.ImageStream")));
            this.imgCL1.Images.SetKeyName(0, "barcode.png");
            this.imgCL1.Images.SetKeyName(1, "box.png");
            this.imgCL1.Images.SetKeyName(2, "box-1.png");
            this.imgCL1.Images.SetKeyName(3, "box-2.png");
            this.imgCL1.Images.SetKeyName(4, "browser.png");
            this.imgCL1.Images.SetKeyName(5, "clipboard.png");
            this.imgCL1.Images.SetKeyName(6, "clipboard-1.png");
            this.imgCL1.Images.SetKeyName(7, "computer.png");
            this.imgCL1.Images.SetKeyName(8, "conveyor.png");
            this.imgCL1.Images.SetKeyName(9, "conveyor-1.png");
            this.imgCL1.Images.SetKeyName(10, "conveyor-2.png");
            this.imgCL1.Images.SetKeyName(11, "delivery-truck.png");
            this.imgCL1.Images.SetKeyName(12, "documents.png");
            this.imgCL1.Images.SetKeyName(13, "factory.png");
            this.imgCL1.Images.SetKeyName(14, "factory-1.png");
            this.imgCL1.Images.SetKeyName(15, "hammer.png");
            this.imgCL1.Images.SetKeyName(16, "helmet.png");
            this.imgCL1.Images.SetKeyName(17, "house.png");
            this.imgCL1.Images.SetKeyName(18, "industrial-robot.png");
            this.imgCL1.Images.SetKeyName(19, "industrial-robot-1.png");
            this.imgCL1.Images.SetKeyName(20, "industrial-robot-2.png");
            this.imgCL1.Images.SetKeyName(21, "industrial-robot-3.png");
            this.imgCL1.Images.SetKeyName(22, "industrial-robot-4.png");
            this.imgCL1.Images.SetKeyName(23, "industrial-robot-5.png");
            this.imgCL1.Images.SetKeyName(24, "industrial-robot-6.png");
            this.imgCL1.Images.SetKeyName(25, "industrial-robot-7.png");
            this.imgCL1.Images.SetKeyName(26, "industrial-robot-8.png");
            this.imgCL1.Images.SetKeyName(27, "industrial-robot-9.png");
            this.imgCL1.Images.SetKeyName(28, "industrial-robot-10.png");
            this.imgCL1.Images.SetKeyName(29, "industrial-robot-11.png");
            this.imgCL1.Images.SetKeyName(30, "industrial-robot-12.png");
            this.imgCL1.Images.SetKeyName(31, "industrial-robot-13.png");
            this.imgCL1.Images.SetKeyName(32, "industrial-robot-14.png");
            this.imgCL1.Images.SetKeyName(33, "industrial-robot-15.png");
            this.imgCL1.Images.SetKeyName(34, "industrial-robot-16.png");
            this.imgCL1.Images.SetKeyName(35, "industrial-robot-17.png");
            this.imgCL1.Images.SetKeyName(36, "industrial-robot-18.png");
            this.imgCL1.Images.SetKeyName(37, "network.png");
            this.imgCL1.Images.SetKeyName(38, "saw.png");
            this.imgCL1.Images.SetKeyName(39, "screw.png");
            this.imgCL1.Images.SetKeyName(40, "settings.png");
            this.imgCL1.Images.SetKeyName(41, "settings-1.png");
            this.imgCL1.Images.SetKeyName(42, "settings-2.png");
            this.imgCL1.Images.SetKeyName(43, "trolley.png");
            this.imgCL1.Images.SetKeyName(44, "truck.png");
            this.imgCL1.Images.SetKeyName(45, "worker.png");
            this.imgCL1.Images.SetKeyName(46, "worker-1.png");
            this.imgCL1.Images.SetKeyName(47, "worker-2.png");
            this.imgCL1.Images.SetKeyName(48, "wrench.png");
            this.imgCL1.Images.SetKeyName(49, "wrench-1.png");
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 509);
            this.Controls.Add(this.tabHienthi);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rbSStatus;
            this.Text = "QUAN LY CUA HANG DIEN MAY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienthi)).EndInit();
            this.tabHienthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCL1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTab.XtraTabControl tabHienthi;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbSStatus;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.Utils.ImageCollection imgCL1;
    }
}

