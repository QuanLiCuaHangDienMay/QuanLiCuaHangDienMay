namespace QuanLyCuaHangDienMay
{
    partial class FrmThemNguoiDungVaoNhom
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
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qlCuaHangDienMay = new QuanLyCuaHangDienMay.qlCuaHangDienMay();
            this.quanLiTaiKhoan_NhomTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiTaiKhoan_NhomTaiKhoanTableAdapter = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.QuanLiTaiKhoan_NhomTaiKhoanTableAdapter();
            this.tableAdapterManager = new QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager();
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan_NhomTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan_NhomTaiKhoanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(386, 37);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(300, 21);
            this.qL_NhomNguoiDungComboBox.TabIndex = 2;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // qlCuaHangDienMay
            // 
            this.qlCuaHangDienMay.DataSetName = "qlCuaHangDienMay";
            this.qlCuaHangDienMay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiTaiKhoan_NhomTaiKhoanBindingSource
            // 
            this.quanLiTaiKhoan_NhomTaiKhoanBindingSource.DataMember = "QuanLiTaiKhoan_NhomTaiKhoan";
            this.quanLiTaiKhoan_NhomTaiKhoanBindingSource.DataSource = this.qlCuaHangDienMay;
            // 
            // quanLiTaiKhoan_NhomTaiKhoanTableAdapter
            // 
            this.quanLiTaiKhoan_NhomTaiKhoanTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QuanLiTaiKhoan_NhomTaiKhoanTableAdapter = this.quanLiTaiKhoan_NhomTaiKhoanTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.TinhThanhPhoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyCuaHangDienMay.qlCuaHangDienMayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quanLiTaiKhoan_NhomTaiKhoanDataGridView
            // 
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.AutoGenerateColumns = false;
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.DataSource = this.quanLiTaiKhoan_NhomTaiKhoanBindingSource;
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.Location = new System.Drawing.Point(386, 97);
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.Name = "quanLiTaiKhoan_NhomTaiKhoanDataGridView";
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.Size = new System.Drawing.Size(300, 220);
            this.quanLiTaiKhoan_NhomTaiKhoanDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenTaiKhoan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNhomTK";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNhomTK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.quanLiTaiKhoan_NhomTaiKhoanDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Name = "FrmThemNguoiDungVaoNhom";
            this.Text = "FrmThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.FrmThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlCuaHangDienMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan_NhomTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan_NhomTaiKhoanDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.Button button1;
        private qlCuaHangDienMay qlCuaHangDienMay;
        private System.Windows.Forms.BindingSource quanLiTaiKhoan_NhomTaiKhoanBindingSource;
        private qlCuaHangDienMayTableAdapters.QuanLiTaiKhoan_NhomTaiKhoanTableAdapter quanLiTaiKhoan_NhomTaiKhoanTableAdapter;
        private qlCuaHangDienMayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView quanLiTaiKhoan_NhomTaiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}