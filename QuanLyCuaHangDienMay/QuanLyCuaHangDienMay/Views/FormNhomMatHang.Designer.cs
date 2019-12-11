namespace QuanLyCuaHangDienMay.Views
{
    partial class frm_NhomMatHang
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_insert = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_del = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gc_loaiMH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoaiMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_loaiMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_insert,
            this.btn_edit,
            this.btn_del,
            this.btn_exit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_insert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_del),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_insert
            // 
            this.btn_insert.Caption = "Thêm";
            this.btn_insert.Id = 0;
            this.btn_insert.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.add_32x32;
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_insert_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Sửa";
            this.btn_edit.Id = 1;
            this.btn_edit.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.Pencil_icon;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // btn_del
            // 
            this.btn_del.Caption = "Xóa";
            this.btn_del.Id = 2;
            this.btn_del.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.removepivotfield_32x32;
            this.btn_del.Name = "btn_del";
            this.btn_del.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_del_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "Làm mới";
            this.btn_exit.Id = 3;
            this.btn_exit.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.close_32x32;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(699, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 599);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(699, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(699, 60);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // gc_loaiMH
            // 
            this.gc_loaiMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_loaiMH.Location = new System.Drawing.Point(0, 60);
            this.gc_loaiMH.MainView = this.gridView1;
            this.gc_loaiMH.MenuManager = this.barManager1;
            this.gc_loaiMH.Name = "gc_loaiMH";
            this.gc_loaiMH.Size = new System.Drawing.Size(699, 539);
            this.gc_loaiMH.TabIndex = 19;
            this.gc_loaiMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoaiMatHang,
            this.TenLoaiMatHang});
            this.gridView1.GridControl = this.gc_loaiMH;
            this.gridView1.Name = "gridView1";
            // 
            // MaLoaiMatHang
            // 
            this.MaLoaiMatHang.Caption = "Mã loại mặt hàng";
            this.MaLoaiMatHang.FieldName = "MaLoaiMatHang";
            this.MaLoaiMatHang.Name = "MaLoaiMatHang";
            this.MaLoaiMatHang.Visible = true;
            this.MaLoaiMatHang.VisibleIndex = 0;
            // 
            // TenLoaiMatHang
            // 
            this.TenLoaiMatHang.Caption = "Tên loại mặt hàng";
            this.TenLoaiMatHang.FieldName = "TenLoaiMatHang";
            this.TenLoaiMatHang.Name = "TenLoaiMatHang";
            this.TenLoaiMatHang.Visible = true;
            this.TenLoaiMatHang.VisibleIndex = 1;
            // 
            // frm_NhomMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 599);
            this.Controls.Add(this.gc_loaiMH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhomMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhóm mặt hàng";
            this.Load += new System.EventHandler(this.frm_NhomMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_loaiMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_insert;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.BarButtonItem btn_del;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraGrid.GridControl gc_loaiMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiMatHang;
    }
}