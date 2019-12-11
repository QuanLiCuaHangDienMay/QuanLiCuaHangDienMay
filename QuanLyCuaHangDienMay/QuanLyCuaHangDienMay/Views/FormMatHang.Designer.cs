namespace QuanLyCuaHangDienMay.Views
{
    partial class frm_MatHang
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
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.btn_delete = new DevExpress.XtraBars.Bar();
            this.bn_insert = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_del = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gc_MatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaoHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrangHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.btn_delete});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bn_insert,
            this.btn_del,
            this.btn_edit,
            this.btn_exit,
            this.barHeaderItem1});
            this.barManager2.MainMenu = this.btn_delete;
            this.barManager2.MaxItemId = 16;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit2});
            // 
            // btn_delete
            // 
            this.btn_delete.BarName = "Main menu";
            this.btn_delete.DockCol = 0;
            this.btn_delete.DockRow = 0;
            this.btn_delete.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.btn_delete.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bn_insert, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_del, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_exit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.btn_delete.OptionsBar.MultiLine = true;
            this.btn_delete.OptionsBar.UseWholeRow = true;
            this.btn_delete.Text = "Main menu";
            // 
            // bn_insert
            // 
            this.bn_insert.Caption = "Thêm mới (Insert)";
            this.bn_insert.Id = 0;
            this.bn_insert.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.add_32x32;
            this.bn_insert.Name = "bn_insert";
            this.bn_insert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bn_insert_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Sửa (Edit)";
            this.btn_edit.Id = 2;
            this.btn_edit.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.Pencil_icon;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // btn_del
            // 
            this.btn_del.Caption = "Xóa (Del)";
            this.btn_del.Id = 1;
            this.btn_del.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.removepivotfield_32x32;
            this.btn_del.ImageOptions.LargeImageIndex = -5;
            this.btn_del.Name = "btn_del";
            this.btn_del.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_del_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "Thoát (Exit)";
            this.btn_exit.Id = 4;
            this.btn_exit.ImageOptions.Image = global::QuanLyCuaHangDienMay.Properties.Resources.close_32x32;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(1370, 60);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 748);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 60);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 688);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1370, 60);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 688);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 6;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gc_MatHang
            // 
            this.gc_MatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_MatHang.Location = new System.Drawing.Point(0, 60);
            this.gc_MatHang.MainView = this.gridView1;
            this.gc_MatHang.MenuManager = this.barManager2;
            this.gc_MatHang.Name = "gc_MatHang";
            this.gc_MatHang.Size = new System.Drawing.Size(1370, 688);
            this.gc_MatHang.TabIndex = 20;
            this.gc_MatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHang,
            this.TenMatHang,
            this.MaLoaiMatHang,
            this.TenLoaiMatHang,
            this.DVT,
            this.GiaBan,
            this.GiaNhap,
            this.MaNhaCC,
            this.TenNhaCC,
            this.BaoHanh,
            this.TinhTrangHang});
            this.gridView1.GridControl = this.gc_MatHang;
            this.gridView1.Name = "gridView1";
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã hàng";
            this.MaHang.FieldName = "MaHang";
            this.MaHang.Name = "MaHang";
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 0;
            // 
            // TenMatHang
            // 
            this.TenMatHang.Caption = "Tên mặt hàng";
            this.TenMatHang.FieldName = "TenMatHang";
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.Visible = true;
            this.TenMatHang.VisibleIndex = 1;
            // 
            // MaLoaiMatHang
            // 
            this.MaLoaiMatHang.Caption = "Mã loại";
            this.MaLoaiMatHang.FieldName = "MaLoaiMatHang";
            this.MaLoaiMatHang.Name = "MaLoaiMatHang";
            // 
            // TenLoaiMatHang
            // 
            this.TenLoaiMatHang.Caption = "Tên loại";
            this.TenLoaiMatHang.FieldName = "TenLoaiMatHang";
            this.TenLoaiMatHang.Name = "TenLoaiMatHang";
            this.TenLoaiMatHang.Visible = true;
            this.TenLoaiMatHang.VisibleIndex = 2;
            // 
            // DVT
            // 
            this.DVT.Caption = "Đơn vị tính";
            this.DVT.FieldName = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 3;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 4;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Caption = "Giá nhập";
            this.GiaNhap.FieldName = "GiaNhap";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Visible = true;
            this.GiaNhap.VisibleIndex = 5;
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.Caption = "Mã nhà cung cấp";
            this.MaNhaCC.FieldName = "MaNhaCC";
            this.MaNhaCC.Name = "MaNhaCC";
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.Caption = "Tên nhà cung cấp";
            this.TenNhaCC.FieldName = "TenNhaCC";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.Visible = true;
            this.TenNhaCC.VisibleIndex = 6;
            // 
            // BaoHanh
            // 
            this.BaoHanh.Caption = "Bảo hành";
            this.BaoHanh.FieldName = "BaoHanh";
            this.BaoHanh.Name = "BaoHanh";
            this.BaoHanh.Visible = true;
            this.BaoHanh.VisibleIndex = 7;
            // 
            // TinhTrangHang
            // 
            this.TinhTrangHang.Caption = "Tình trạng hàng";
            this.TinhTrangHang.FieldName = "TinhTrangHang";
            this.TinhTrangHang.Name = "TinhTrangHang";
            this.TinhTrangHang.Visible = true;
            this.TinhTrangHang.VisibleIndex = 8;
            // 
            // frm_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.gc_MatHang);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MatHang";
            this.Text = "Danh mục mặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar btn_delete;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem bn_insert;
        private DevExpress.XtraBars.BarButtonItem btn_del;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.GridControl gc_MatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn GiaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn BaoHanh;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrangHang;
    }
}