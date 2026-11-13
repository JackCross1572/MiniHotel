namespace WindowsFormsApp2
{
    partial class frmDichVu
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
            this.errDV = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdHoaDon = new System.Windows.Forms.SaveFileDialog();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.nudGiaDV = new System.Windows.Forms.NumericUpDown();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.pnlDanhMuc = new System.Windows.Forms.Panel();
            this.tabDV = new System.Windows.Forms.TabControl();
            this.tabGhi = new System.Windows.Forms.TabPage();
            this.splDV = new System.Windows.Forms.SplitContainer();
            this.lvSuDung = new System.Windows.Forms.ListView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.pnlThemDV = new System.Windows.Forms.Panel();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.lblSL = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.chkTraTre = new System.Windows.Forms.CheckBox();
            this.lblPhuThu = new System.Windows.Forms.Label();
            this.lblPhuThuTen = new System.Windows.Forms.Label();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.lblTienDVTen = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTienPhongTen = new System.Windows.Forms.Label();
            this.pnlChon = new System.Windows.Forms.Panel();
            this.cboDatPhong = new System.Windows.Forms.ComboBox();
            this.lblDat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errDV)).BeginInit();
            this.tabDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaDV)).BeginInit();
            this.tabDV.SuspendLayout();
            this.tabGhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splDV)).BeginInit();
            this.splDV.Panel1.SuspendLayout();
            this.splDV.Panel2.SuspendLayout();
            this.splDV.SuspendLayout();
            this.pnlThemDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.gbHoaDon.SuspendLayout();
            this.pnlChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // errDV
            // 
            this.errDV.ContainerControl = this;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(984, 68);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "Dịch vụ và hóa đơn";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tabDanhMuc.Controls.Add(this.dgvDanhMuc);
            this.tabDanhMuc.Controls.Add(this.btnSuaDM);
            this.tabDanhMuc.Controls.Add(this.btnXoaDM);
            this.tabDanhMuc.Controls.Add(this.btnThemDM);
            this.tabDanhMuc.Controls.Add(this.nudGiaDV);
            this.tabDanhMuc.Controls.Add(this.lblGiaDV);
            this.tabDanhMuc.Controls.Add(this.txtTenDV);
            this.tabDanhMuc.Controls.Add(this.lblTenDV);
            this.tabDanhMuc.Controls.Add(this.pnlDanhMuc);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 36);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhMuc.Size = new System.Drawing.Size(976, 453);
            this.tabDanhMuc.TabIndex = 1;
            this.tabDanhMuc.Text = "Danh mục dịch vụ";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(970, 371);
            this.dgvDanhMuc.TabIndex = 8;
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Location = new System.Drawing.Point(572, 25);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(90, 32);
            this.btnSuaDM.TabIndex = 7;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoaDM.Location = new System.Drawing.Point(672, 25);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(90, 32);
            this.btnXoaDM.TabIndex = 6;
            this.btnXoaDM.Text = "Thêm";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(472, 25);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(90, 32);
            this.btnThemDM.TabIndex = 5;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            // 
            // nudGiaDV
            // 
            this.nudGiaDV.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGiaDV.Location = new System.Drawing.Point(292, 28);
            this.nudGiaDV.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGiaDV.Name = "nudGiaDV";
            this.nudGiaDV.Size = new System.Drawing.Size(160, 25);
            this.nudGiaDV.TabIndex = 4;
            this.nudGiaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGiaDV.ThousandsSeparator = true;
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Location = new System.Drawing.Point(292, 6);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(57, 19);
            this.lblGiaDV.TabIndex = 3;
            this.lblGiaDV.Text = "Đơn giá";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(12, 28);
            this.txtTenDV.MaxLength = 40;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(260, 25);
            this.txtTenDV.TabIndex = 2;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(12, 6);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(78, 19);
            this.lblTenDV.TabIndex = 1;
            this.lblTenDV.Text = "Tên dịch vụ";
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDanhMuc.Location = new System.Drawing.Point(3, 374);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(970, 76);
            this.pnlDanhMuc.TabIndex = 0;
            // 
            // tabDV
            // 
            this.tabDV.Controls.Add(this.tabGhi);
            this.tabDV.Controls.Add(this.tabDanhMuc);
            this.tabDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDV.ItemSize = new System.Drawing.Size(200, 32);
            this.tabDV.Location = new System.Drawing.Point(0, 68);
            this.tabDV.Name = "tabDV";
            this.tabDV.Padding = new System.Drawing.Point(14, 6);
            this.tabDV.SelectedIndex = 0;
            this.tabDV.Size = new System.Drawing.Size(984, 493);
            this.tabDV.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDV.TabIndex = 5;
            this.tabDV.Tag = "";
            // 
            // tabGhi
            // 
            this.tabGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.tabGhi.Controls.Add(this.splDV);
            this.tabGhi.Controls.Add(this.pnlChon);
            this.tabGhi.Location = new System.Drawing.Point(4, 36);
            this.tabGhi.Name = "tabGhi";
            this.tabGhi.Size = new System.Drawing.Size(976, 453);
            this.tabGhi.TabIndex = 2;
            this.tabGhi.Text = "Dịch vụ và trả phòng";
            // 
            // splDV
            // 
            this.splDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splDV.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splDV.Location = new System.Drawing.Point(0, 52);
            this.splDV.Name = "splDV";
            // 
            // splDV.Panel1
            // 
            this.splDV.Panel1.Controls.Add(this.lvSuDung);
            this.splDV.Panel1.Controls.Add(this.btnThemDV);
            this.splDV.Panel1.Controls.Add(this.pnlThemDV);
            // 
            // splDV.Panel2
            // 
            this.splDV.Panel2.Controls.Add(this.gbHoaDon);
            this.splDV.Size = new System.Drawing.Size(976, 401);
            this.splDV.SplitterDistance = 600;
            this.splDV.TabIndex = 1;
            // 
            // lvSuDung
            // 
            this.lvSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSuDung.FullRowSelect = true;
            this.lvSuDung.GridLines = true;
            this.lvSuDung.HideSelection = false;
            this.lvSuDung.Location = new System.Drawing.Point(0, 64);
            this.lvSuDung.MultiSelect = false;
            this.lvSuDung.Name = "lvSuDung";
            this.lvSuDung.Size = new System.Drawing.Size(600, 337);
            this.lvSuDung.TabIndex = 5;
            this.lvSuDung.UseCompatibleStateImageBehavior = false;
            this.lvSuDung.View = System.Windows.Forms.View.Details;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(376, 23);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(90, 32);
            this.btnThemDV.TabIndex = 4;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // pnlThemDV
            // 
            this.pnlThemDV.Controls.Add(this.btnXoaDV);
            this.pnlThemDV.Controls.Add(this.nudSL);
            this.pnlThemDV.Controls.Add(this.lblSL);
            this.pnlThemDV.Controls.Add(this.cboDichVu);
            this.pnlThemDV.Controls.Add(this.lblDV);
            this.pnlThemDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThemDV.Location = new System.Drawing.Point(0, 0);
            this.pnlThemDV.Name = "pnlThemDV";
            this.pnlThemDV.Size = new System.Drawing.Size(600, 64);
            this.pnlThemDV.TabIndex = 0;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoaDV.Location = new System.Drawing.Point(476, 23);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(100, 32);
            this.btnXoaDV.TabIndex = 5;
            this.btnXoaDV.Text = "Xóa dòng";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(290, 26);
            this.nudSL.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(70, 25);
            this.nudSL.TabIndex = 3;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(290, 4);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(23, 19);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "SL";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(12, 26);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(260, 25);
            this.cboDichVu.TabIndex = 1;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(12, 4);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(55, 19);
            this.lblDV.TabIndex = 0;
            this.lblDV.Text = "Dịch vụ";
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.BackColor = System.Drawing.Color.White;
            this.gbHoaDon.Controls.Add(this.btnXuatHD);
            this.gbHoaDon.Controls.Add(this.btnTraPhong);
            this.gbHoaDon.Controls.Add(this.lblTong);
            this.gbHoaDon.Controls.Add(this.lblTongTien);
            this.gbHoaDon.Controls.Add(this.chkTraTre);
            this.gbHoaDon.Controls.Add(this.lblPhuThu);
            this.gbHoaDon.Controls.Add(this.lblPhuThuTen);
            this.gbHoaDon.Controls.Add(this.lblTienDV);
            this.gbHoaDon.Controls.Add(this.lblTienDVTen);
            this.gbHoaDon.Controls.Add(this.lblTienPhong);
            this.gbHoaDon.Controls.Add(this.lblTienPhongTen);
            this.gbHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(372, 401);
            this.gbHoaDon.TabIndex = 6;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Hóa đơn trả phòng";
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHD.Location = new System.Drawing.Point(16, 284);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(334, 40);
            this.btnXuatHD.TabIndex = 10;
            this.btnXuatHD.Text = "Xuất hóa đơn TXT";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnTraPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(16, 236);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(334, 40);
            this.btnTraPhong.TabIndex = 9;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTong.Location = new System.Drawing.Point(180, 182);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(170, 30);
            this.lblTong.TabIndex = 8;
            this.lblTong.Text = "0Đ";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(16, 186);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(91, 21);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng cộng";
            // 
            // chkTraTre
            // 
            this.chkTraTre.AutoSize = true;
            this.chkTraTre.Location = new System.Drawing.Point(16, 142);
            this.chkTraTre.Name = "chkTraTre";
            this.chkTraTre.Size = new System.Drawing.Size(99, 23);
            this.chkTraTre.TabIndex = 6;
            this.chkTraTre.Text = "Trả sau 12h";
            this.chkTraTre.UseVisualStyleBackColor = true;
            // 
            // lblPhuThu
            // 
            this.lblPhuThu.Location = new System.Drawing.Point(180, 104);
            this.lblPhuThu.Name = "lblPhuThu";
            this.lblPhuThu.Size = new System.Drawing.Size(170, 22);
            this.lblPhuThu.TabIndex = 5;
            this.lblPhuThu.Text = "0Đ";
            this.lblPhuThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhuThuTen
            // 
            this.lblPhuThuTen.AutoSize = true;
            this.lblPhuThuTen.Location = new System.Drawing.Point(16, 104);
            this.lblPhuThuTen.Name = "lblPhuThuTen";
            this.lblPhuThuTen.Size = new System.Drawing.Size(100, 19);
            this.lblPhuThuTen.TabIndex = 4;
            this.lblPhuThuTen.Text = "Phụ thu trả trễ";
            // 
            // lblTienDV
            // 
            this.lblTienDV.Location = new System.Drawing.Point(180, 70);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(170, 22);
            this.lblTienDV.TabIndex = 3;
            this.lblTienDV.Text = "0Đ";
            this.lblTienDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienDVTen
            // 
            this.lblTienDVTen.AutoSize = true;
            this.lblTienDVTen.Location = new System.Drawing.Point(16, 70);
            this.lblTienDVTen.Name = "lblTienDVTen";
            this.lblTienDVTen.Size = new System.Drawing.Size(55, 19);
            this.lblTienDVTen.TabIndex = 2;
            this.lblTienDVTen.Text = "Dịch vụ";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.Location = new System.Drawing.Point(180, 36);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(170, 22);
            this.lblTienPhong.TabIndex = 1;
            this.lblTienPhong.Text = "0Đ";
            this.lblTienPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienPhongTen
            // 
            this.lblTienPhongTen.AutoSize = true;
            this.lblTienPhongTen.Location = new System.Drawing.Point(16, 36);
            this.lblTienPhongTen.Name = "lblTienPhongTen";
            this.lblTienPhongTen.Size = new System.Drawing.Size(78, 19);
            this.lblTienPhongTen.TabIndex = 0;
            this.lblTienPhongTen.Text = "Tiền Phòng";
            // 
            // pnlChon
            // 
            this.pnlChon.Controls.Add(this.cboDatPhong);
            this.pnlChon.Controls.Add(this.lblDat);
            this.pnlChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChon.Location = new System.Drawing.Point(0, 0);
            this.pnlChon.Name = "pnlChon";
            this.pnlChon.Size = new System.Drawing.Size(976, 52);
            this.pnlChon.TabIndex = 0;
            // 
            // cboDatPhong
            // 
            this.cboDatPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatPhong.FormattingEnabled = true;
            this.cboDatPhong.Location = new System.Drawing.Point(160, 12);
            this.cboDatPhong.Name = "cboDatPhong";
            this.cboDatPhong.Size = new System.Drawing.Size(420, 25);
            this.cboDatPhong.TabIndex = 1;
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(16, 16);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(125, 19);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Đặt phòng đang ở:";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tabDV);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDichVu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dịch vụ và hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.errDV)).EndInit();
            this.tabDanhMuc.ResumeLayout(false);
            this.tabDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaDV)).EndInit();
            this.tabDV.ResumeLayout(false);
            this.tabGhi.ResumeLayout(false);
            this.splDV.Panel1.ResumeLayout(false);
            this.splDV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splDV)).EndInit();
            this.splDV.ResumeLayout(false);
            this.pnlThemDV.ResumeLayout(false);
            this.pnlThemDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.pnlChon.ResumeLayout(false);
            this.pnlChon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errDV;
        private System.Windows.Forms.SaveFileDialog sfdHoaDon;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TabControl tabDV;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabGhi;
        private System.Windows.Forms.Panel pnlChon;
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.SplitContainer splDV;
        private System.Windows.Forms.Panel pnlThemDV;
        private System.Windows.Forms.ComboBox cboDatPhong;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.ListView lvSuDung;
        private System.Windows.Forms.Label lblTienPhongTen;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblPhuThu;
        private System.Windows.Forms.Label lblPhuThuTen;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.Label lblTienDVTen;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.CheckBox chkTraTre;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.Panel pnlDanhMuc;
        private System.Windows.Forms.NumericUpDown nudGiaDV;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
    }
}