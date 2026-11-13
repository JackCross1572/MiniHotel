namespace WindowsFormsApp2
{
    partial class frmPhong
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
            this.errPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.splPhong = new System.Windows.Forms.SplitContainer();
            this.tvPhong = new System.Windows.Forms.TreeView();
            this.gbLoai = new System.Windows.Forms.GroupBox();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.pnlLoaiNhap = new System.Windows.Forms.Panel();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.btnSuaLoai = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.nudGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.nudTang = new System.Windows.Forms.NumericUpDown();
            this.lblTang = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splPhong)).BeginInit();
            this.splPhong.Panel1.SuspendLayout();
            this.splPhong.Panel2.SuspendLayout();
            this.splPhong.SuspendLayout();
            this.gbLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.pnlLoaiNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).BeginInit();
            this.gbPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTang)).BeginInit();
            this.SuspendLayout();
            // 
            // errPhong
            // 
            this.errPhong.ContainerControl = this;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(984, 52);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Quản lí phòng";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // splPhong
            // 
            this.splPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPhong.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splPhong.Location = new System.Drawing.Point(0, 52);
            this.splPhong.Name = "splPhong";
            // 
            // splPhong.Panel1
            // 
            this.splPhong.Panel1.Controls.Add(this.tvPhong);
            this.splPhong.Panel1MinSize = 200;
            // 
            // splPhong.Panel2
            // 
            this.splPhong.Panel2.Controls.Add(this.gbLoai);
            this.splPhong.Panel2.Controls.Add(this.gbPhong);
            this.splPhong.Size = new System.Drawing.Size(984, 509);
            this.splPhong.SplitterDistance = 240;
            this.splPhong.TabIndex = 3;
            // 
            // tvPhong
            // 
            this.tvPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPhong.FullRowSelect = true;
            this.tvPhong.HideSelection = false;
            this.tvPhong.ItemHeight = 26;
            this.tvPhong.Location = new System.Drawing.Point(0, 0);
            this.tvPhong.Name = "tvPhong";
            this.tvPhong.Size = new System.Drawing.Size(240, 509);
            this.tvPhong.TabIndex = 0;
            // 
            // gbLoai
            // 
            this.gbLoai.Controls.Add(this.dgvLoai);
            this.gbLoai.Controls.Add(this.pnlLoaiNhap);
            this.gbLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLoai.Location = new System.Drawing.Point(0, 196);
            this.gbLoai.Name = "gbLoai";
            this.gbLoai.Size = new System.Drawing.Size(740, 313);
            this.gbLoai.TabIndex = 1;
            this.gbLoai.TabStop = false;
            this.gbLoai.Text = "Loại phòng";
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoai.Location = new System.Drawing.Point(3, 21);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.Size = new System.Drawing.Size(734, 221);
            this.dgvLoai.TabIndex = 1;
            // 
            // pnlLoaiNhap
            // 
            this.pnlLoaiNhap.Controls.Add(this.btnXoaLoai);
            this.pnlLoaiNhap.Controls.Add(this.btnSuaLoai);
            this.pnlLoaiNhap.Controls.Add(this.btnThemLoai);
            this.pnlLoaiNhap.Controls.Add(this.nudGia);
            this.pnlLoaiNhap.Controls.Add(this.lblGia);
            this.pnlLoaiNhap.Controls.Add(this.txtTenLoai);
            this.pnlLoaiNhap.Controls.Add(this.lblTenLoai);
            this.pnlLoaiNhap.Controls.Add(this.txtMaLoai);
            this.pnlLoaiNhap.Controls.Add(this.lblMaLoai);
            this.pnlLoaiNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoaiNhap.Location = new System.Drawing.Point(3, 242);
            this.pnlLoaiNhap.Name = "pnlLoaiNhap";
            this.pnlLoaiNhap.Size = new System.Drawing.Size(734, 68);
            this.pnlLoaiNhap.TabIndex = 0;
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoaLoai.Location = new System.Drawing.Point(600, 26);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(80, 30);
            this.btnXoaLoai.TabIndex = 8;
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.UseVisualStyleBackColor = true;
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Location = new System.Drawing.Point(512, 26);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(80, 30);
            this.btnSuaLoai.TabIndex = 7;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.UseVisualStyleBackColor = true;
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(424, 26);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(80, 30);
            this.btnThemLoai.TabIndex = 6;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            // 
            // nudGia
            // 
            this.nudGia.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGia.Location = new System.Drawing.Point(272, 28);
            this.nudGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGia.Name = "nudGia";
            this.nudGia.Size = new System.Drawing.Size(140, 25);
            this.nudGia.TabIndex = 5;
            this.nudGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGia.ThousandsSeparator = true;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(272, 6);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(87, 19);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá mỗi đêm";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(102, 28);
            this.txtTenLoai.MaxLength = 30;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(160, 25);
            this.txtTenLoai.TabIndex = 3;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(102, 6);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(55, 19);
            this.lblTenLoai.TabIndex = 2;
            this.lblTenLoai.Text = "Tên loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(12, 28);
            this.txtMaLoai.MaxLength = 5;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(80, 25);
            this.txtMaLoai.TabIndex = 1;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(16, 6);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(29, 19);
            this.lblMaLoai.TabIndex = 0;
            this.lblMaLoai.Text = "Mã";
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.cboTrangThai);
            this.gbPhong.Controls.Add(this.lblTrangThai);
            this.gbPhong.Controls.Add(this.btnLuu);
            this.gbPhong.Controls.Add(this.btnXoa);
            this.gbPhong.Controls.Add(this.btnLamMoi);
            this.gbPhong.Controls.Add(this.btnThem);
            this.gbPhong.Controls.Add(this.cboLoai);
            this.gbPhong.Controls.Add(this.lblLoai);
            this.gbPhong.Controls.Add(this.nudTang);
            this.gbPhong.Controls.Add(this.lblTang);
            this.gbPhong.Controls.Add(this.txtSoPhong);
            this.gbPhong.Controls.Add(this.lblSoPhong);
            this.gbPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPhong.Location = new System.Drawing.Point(0, 0);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(740, 196);
            this.gbPhong.TabIndex = 0;
            this.gbPhong.TabStop = false;
            this.gbPhong.Text = "Thông tin phòng";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(240, 114);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 25);
            this.cboTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(240, 92);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 19);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(136, 148);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 34);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Location = new System.Drawing.Point(276, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(396, 148);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 34);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(16, 114);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(200, 25);
            this.cboLoai.TabIndex = 5;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(16, 92);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(78, 19);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loại phòng";
            // 
            // nudTang
            // 
            this.nudTang.Location = new System.Drawing.Point(240, 54);
            this.nudTang.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTang.Name = "nudTang";
            this.nudTang.Size = new System.Drawing.Size(120, 25);
            this.nudTang.TabIndex = 3;
            this.nudTang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Location = new System.Drawing.Point(240, 32);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(39, 19);
            this.lblTang.TabIndex = 2;
            this.lblTang.Text = "Tầng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(16, 54);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(200, 25);
            this.txtSoPhong.TabIndex = 1;
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(16, 32);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(68, 19);
            this.lblSoPhong.TabIndex = 0;
            this.lblSoPhong.Text = "Số phòng";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splPhong);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quản lý phòng";
            ((System.ComponentModel.ISupportInitialize)(this.errPhong)).EndInit();
            this.splPhong.Panel1.ResumeLayout(false);
            this.splPhong.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splPhong)).EndInit();
            this.splPhong.ResumeLayout(false);
            this.gbLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.pnlLoaiNhap.ResumeLayout(false);
            this.pnlLoaiNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).EndInit();
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errPhong;
        private System.Windows.Forms.SplitContainer splPhong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TreeView tvPhong;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.GroupBox gbLoai;
        private System.Windows.Forms.Panel pnlLoaiNhap;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.NumericUpDown nudTang;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.NumericUpDown nudGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Button btnXoaLoai;
        private System.Windows.Forms.Button btnSuaLoai;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
    }
}