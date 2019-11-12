namespace QuanLyCuaHangDienMay
{
    partial class FrmPhanQuyen
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
            this.fill_DKToolStrip = new System.Windows.Forms.ToolStrip();
            this.maNhomNguoiDungToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maNhomNguoiDungToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_DKToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.qlCuaHangDienMay = new QuanLyCuaHangDienMay.qlCuaHangDienMay();
            this.quanLiNhomTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhomTaiKhoanTableAdapter = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.QuanLiNhomTaiKhoanTableAdapter();
            this.tableAdapterManager = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager();
            this.quanLiNhomTaiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanLiManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiManHinhTableAdapter = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.QuanLiManHinhTableAdapter();
            this.quanLiManHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fill_DKToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhomTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhomTaiKhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiManHinhDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fill_DKToolStrip
            // 
            this.fill_DKToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maNhomNguoiDungToolStripLabel,
            this.maNhomNguoiDungToolStripTextBox,
            this.fill_DKToolStripButton});
            this.fill_DKToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fill_DKToolStrip.Name = "fill_DKToolStrip";
            this.fill_DKToolStrip.Size = new System.Drawing.Size(854, 25);
            this.fill_DKToolStrip.TabIndex = 3;
            this.fill_DKToolStrip.Text = "fill_DKToolStrip";
            // 
            // maNhomNguoiDungToolStripLabel
            // 
            this.maNhomNguoiDungToolStripLabel.Name = "maNhomNguoiDungToolStripLabel";
            this.maNhomNguoiDungToolStripLabel.Size = new System.Drawing.Size(123, 22);
            this.maNhomNguoiDungToolStripLabel.Text = "MaNhomNguoiDung:";
            // 
            // maNhomNguoiDungToolStripTextBox
            // 
            this.maNhomNguoiDungToolStripTextBox.Name = "maNhomNguoiDungToolStripTextBox";
            this.maNhomNguoiDungToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fill_DKToolStripButton
            // 
            this.fill_DKToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_DKToolStripButton.Name = "fill_DKToolStripButton";
            this.fill_DKToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fill_DKToolStripButton.Text = "Fill_DK";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // qlCuaHangDienMay
            // 
            this.qlCuaHangDienMay.DataSetName = "qlCuaHangDienMay";
            this.qlCuaHangDienMay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiNhomTaiKhoanBindingSource
            // 
            this.quanLiNhomTaiKhoanBindingSource.DataMember = "QuanLiNhomTaiKhoan";
            this.quanLiNhomTaiKhoanBindingSource.DataSource = this.qlCuaHangDienMay;
            // 
            // quanLiNhomTaiKhoanTableAdapter
            // 
            this.quanLiNhomTaiKhoanTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QuanLiManHinhTableAdapter = this.quanLiManHinhTableAdapter;
            this.tableAdapterManager.QuanLiNhomTaiKhoanTableAdapter = this.quanLiNhomTaiKhoanTableAdapter;
            this.tableAdapterManager.QuanLiPhanQuyenTableAdapter = null;
            this.tableAdapterManager.QuanLiTaiKhoan_NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.TinhThanhPhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quanLiNhomTaiKhoanDataGridView
            // 
            this.quanLiNhomTaiKhoanDataGridView.AutoGenerateColumns = false;
            this.quanLiNhomTaiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quanLiNhomTaiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.quanLiNhomTaiKhoanDataGridView.DataSource = this.quanLiNhomTaiKhoanBindingSource;
            this.quanLiNhomTaiKhoanDataGridView.Location = new System.Drawing.Point(12, 110);
            this.quanLiNhomTaiKhoanDataGridView.Name = "quanLiNhomTaiKhoanDataGridView";
            this.quanLiNhomTaiKhoanDataGridView.Size = new System.Drawing.Size(300, 220);
            this.quanLiNhomTaiKhoanDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhomTK";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhomTK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhomTK";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhomTK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // quanLiManHinhBindingSource
            // 
            this.quanLiManHinhBindingSource.DataMember = "QuanLiManHinh";
            this.quanLiManHinhBindingSource.DataSource = this.qlCuaHangDienMay;
            // 
            // quanLiManHinhTableAdapter
            // 
            this.quanLiManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // quanLiManHinhDataGridView
            // 
            this.quanLiManHinhDataGridView.AutoGenerateColumns = false;
            this.quanLiManHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quanLiManHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.quanLiManHinhDataGridView.DataSource = this.quanLiManHinhBindingSource;
            this.quanLiManHinhDataGridView.Location = new System.Drawing.Point(417, 110);
            this.quanLiManHinhDataGridView.Name = "quanLiManHinhDataGridView";
            this.quanLiManHinhDataGridView.Size = new System.Drawing.Size(300, 220);
            this.quanLiManHinhDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenMaMH";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenMaMH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 494);
            this.Controls.Add(this.quanLiManHinhDataGridView);
            this.Controls.Add(this.quanLiNhomTaiKhoanDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fill_DKToolStrip);
            this.Name = "FrmPhanQuyen";
            this.Text = "FrmPhanQuyen";
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            this.fill_DKToolStrip.ResumeLayout(false);
            this.fill_DKToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhomTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhomTaiKhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiManHinhDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip fill_DKToolStrip;
        private System.Windows.Forms.ToolStripLabel maNhomNguoiDungToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maNhomNguoiDungToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_DKToolStripButton;
        private System.Windows.Forms.Button button1;
        private qlCuaHangDienMay qlCuaHangDienMay;
        private System.Windows.Forms.BindingSource quanLiNhomTaiKhoanBindingSource;
        private qlCuaHangDienMayTableAdapters.QuanLiNhomTaiKhoanTableAdapter quanLiNhomTaiKhoanTableAdapter;
        private qlCuaHangDienMayTableAdapters.TableAdapterManager tableAdapterManager;
        private qlCuaHangDienMayTableAdapters.QuanLiManHinhTableAdapter quanLiManHinhTableAdapter;
        private System.Windows.Forms.DataGridView quanLiNhomTaiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource quanLiManHinhBindingSource;
        private System.Windows.Forms.DataGridView quanLiManHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}