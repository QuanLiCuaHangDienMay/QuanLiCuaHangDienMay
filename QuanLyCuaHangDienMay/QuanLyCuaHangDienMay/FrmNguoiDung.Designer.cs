namespace QuanLyCuaHangDienMay
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            System.Windows.Forms.Label tenTaiKhoanLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label tinhTrangTKLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label ngayCapLabel;
            this.qlCuaHangDienMay = new QuanLyCuaHangDienMay.qlCuaHangDienMay();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager();
            this.taiKhoanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.taiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.taiKhoanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tenTaiKhoanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tinhTrangTKTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapDateEdit = new DevExpress.XtraEditors.DateEdit();
            tenTaiKhoanLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            tinhTrangTKLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ngayCapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingNavigator)).BeginInit();
            this.taiKhoanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTaiKhoanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangTKTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qlCuaHangDienMay
            // 
            this.qlCuaHangDienMay.DataSetName = "qlCuaHangDienMay";
            this.qlCuaHangDienMay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qlCuaHangDienMay;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.ChiTietKhoTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuBaoHanhTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LichSuGiaBanTableAdapter = null;
            this.tableAdapterManager.LoaiMatHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhomKHTableAdapter = null;
            this.tableAdapterManager.PhieuBaoHanhTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.QuanLiManHinhTableAdapter = null;
            this.tableAdapterManager.QuanLiNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.QuanLiPhanQuyenTableAdapter = null;
            this.tableAdapterManager.QuanLiTaiKhoan_NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.TinhThanhPhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanBindingNavigator
            // 
            this.taiKhoanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.taiKhoanBindingNavigator.BindingSource = this.taiKhoanBindingSource;
            this.taiKhoanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.taiKhoanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.taiKhoanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.taiKhoanBindingNavigatorSaveItem});
            this.taiKhoanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.taiKhoanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.taiKhoanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.taiKhoanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.taiKhoanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.taiKhoanBindingNavigator.Name = "taiKhoanBindingNavigator";
            this.taiKhoanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.taiKhoanBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.taiKhoanBindingNavigator.TabIndex = 0;
            this.taiKhoanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // taiKhoanDataGridView
            // 
            this.taiKhoanDataGridView.AllowUserToDeleteRows = false;
            this.taiKhoanDataGridView.AutoGenerateColumns = false;
            this.taiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.taiKhoanDataGridView.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanDataGridView.Location = new System.Drawing.Point(72, 183);
            this.taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            this.taiKhoanDataGridView.Size = new System.Drawing.Size(552, 220);
            this.taiKhoanDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TinhTrangTK";
            this.dataGridViewTextBoxColumn3.HeaderText = "TinhTrangTK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayCap";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgayCap";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // taiKhoanBindingNavigatorSaveItem
            // 
            this.taiKhoanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.taiKhoanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("taiKhoanBindingNavigatorSaveItem.Image")));
            this.taiKhoanBindingNavigatorSaveItem.Name = "taiKhoanBindingNavigatorSaveItem";
            this.taiKhoanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.taiKhoanBindingNavigatorSaveItem.Text = "Save Data";
            this.taiKhoanBindingNavigatorSaveItem.Click += new System.EventHandler(this.taiKhoanBindingNavigatorSaveItem_Click);
            // 
            // tenTaiKhoanLabel
            // 
            tenTaiKhoanLabel.AutoSize = true;
            tenTaiKhoanLabel.Location = new System.Drawing.Point(93, 42);
            tenTaiKhoanLabel.Name = "tenTaiKhoanLabel";
            tenTaiKhoanLabel.Size = new System.Drawing.Size(81, 13);
            tenTaiKhoanLabel.TabIndex = 2;
            tenTaiKhoanLabel.Text = "Ten Tai Khoan:";
            // 
            // tenTaiKhoanTextEdit
            // 
            this.tenTaiKhoanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "TenTaiKhoan", true));
            this.tenTaiKhoanTextEdit.Location = new System.Drawing.Point(180, 39);
            this.tenTaiKhoanTextEdit.Name = "tenTaiKhoanTextEdit";
            this.tenTaiKhoanTextEdit.Size = new System.Drawing.Size(274, 20);
            this.tenTaiKhoanTextEdit.TabIndex = 3;
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(93, 68);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(56, 13);
            matKhauLabel.TabIndex = 4;
            matKhauLabel.Text = "Mat Khau:";
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(180, 65);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Size = new System.Drawing.Size(274, 20);
            this.matKhauTextEdit.TabIndex = 5;
            // 
            // tinhTrangTKLabel
            // 
            tinhTrangTKLabel.AutoSize = true;
            tinhTrangTKLabel.Location = new System.Drawing.Point(93, 94);
            tinhTrangTKLabel.Name = "tinhTrangTKLabel";
            tinhTrangTKLabel.Size = new System.Drawing.Size(79, 13);
            tinhTrangTKLabel.TabIndex = 6;
            tinhTrangTKLabel.Text = "Tinh Trang TK:";
            // 
            // tinhTrangTKTextEdit
            // 
            this.tinhTrangTKTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "TinhTrangTK", true));
            this.tinhTrangTKTextEdit.Location = new System.Drawing.Point(180, 91);
            this.tinhTrangTKTextEdit.Name = "tinhTrangTKTextEdit";
            this.tinhTrangTKTextEdit.Size = new System.Drawing.Size(274, 20);
            this.tinhTrangTKTextEdit.TabIndex = 7;
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(93, 120);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(43, 13);
            maNVLabel.TabIndex = 8;
            maNVLabel.Text = "Ma NV:";
            // 
            // maNVTextEdit
            // 
            this.maNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "MaNV", true));
            this.maNVTextEdit.Location = new System.Drawing.Point(180, 117);
            this.maNVTextEdit.Name = "maNVTextEdit";
            this.maNVTextEdit.Size = new System.Drawing.Size(274, 20);
            this.maNVTextEdit.TabIndex = 9;
            // 
            // ngayCapLabel
            // 
            ngayCapLabel.AutoSize = true;
            ngayCapLabel.Location = new System.Drawing.Point(93, 146);
            ngayCapLabel.Name = "ngayCapLabel";
            ngayCapLabel.Size = new System.Drawing.Size(57, 13);
            ngayCapLabel.TabIndex = 10;
            ngayCapLabel.Text = "Ngay Cap:";
            // 
            // ngayCapDateEdit
            // 
            this.ngayCapDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "NgayCap", true));
            this.ngayCapDateEdit.EditValue = null;
            this.ngayCapDateEdit.Location = new System.Drawing.Point(180, 143);
            this.ngayCapDateEdit.Name = "ngayCapDateEdit";
            this.ngayCapDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapDateEdit.Size = new System.Drawing.Size(274, 20);
            this.ngayCapDateEdit.TabIndex = 11;
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tenTaiKhoanLabel);
            this.Controls.Add(this.tenTaiKhoanTextEdit);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextEdit);
            this.Controls.Add(tinhTrangTKLabel);
            this.Controls.Add(this.tinhTrangTKTextEdit);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextEdit);
            this.Controls.Add(ngayCapLabel);
            this.Controls.Add(this.ngayCapDateEdit);
            this.Controls.Add(this.taiKhoanDataGridView);
            this.Controls.Add(this.taiKhoanBindingNavigator);
            this.Name = "FrmNguoiDung";
            this.Text = "FrmNguoiDung";
            this.Load += new System.EventHandler(this.FrmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingNavigator)).EndInit();
            this.taiKhoanBindingNavigator.ResumeLayout(false);
            this.taiKhoanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTaiKhoanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangTKTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlCuaHangDienMay qlCuaHangDienMay;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private qlCuaHangDienMayTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private qlCuaHangDienMayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator taiKhoanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton taiKhoanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView taiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.TextEdit tenTaiKhoanTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.TextEdit tinhTrangTKTextEdit;
        private DevExpress.XtraEditors.TextEdit maNVTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapDateEdit;
    }
}