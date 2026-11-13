namespace WindowsFormsApp2
{
    partial class frmDatPhong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errDat = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gbDat = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.flpPhongTrong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpDi = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblLoi = new System.Windows.Forms.Label();
            this.lblDi = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();
            this.pnlNut = new System.Windows.Forms.Panel();
            this.btnDoiPhong = new System.Windows.Forms.Button();
            this.btnHuyDat = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.lblChon = new System.Windows.Forms.Label();
            this.lvDat = new System.Windows.Forms.ListView();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.errDat)).BeginInit();
            this.gbDat.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlNut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // errDat
            // 
            this.errDat.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errDat.ContainerControl = this;
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
            this.lblTieuDe.Size = new System.Drawing.Size(1148, 68);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Đặt phòng";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDat
            // 
            this.gbDat.Controls.Add(this.btnXacNhan);
            this.gbDat.Controls.Add(this.flpPhongTrong);
            this.gbDat.Controls.Add(this.lblPhongTrong);
            this.gbDat.Controls.Add(this.btnTim);
            this.gbDat.Controls.Add(this.dtpDi);
            this.gbDat.Controls.Add(this.dtpDen);
            this.gbDat.Controls.Add(this.cboLoai);
            this.gbDat.Controls.Add(this.txtSDT);
            this.gbDat.Controls.Add(this.txtHoTen);
            this.gbDat.Controls.Add(this.txtCCCD);
            this.gbDat.Controls.Add(this.lblLoi);
            this.gbDat.Controls.Add(this.lblDi);
            this.gbDat.Controls.Add(this.lblDen);
            this.gbDat.Controls.Add(this.lblLoai);
            this.gbDat.Controls.Add(this.lblSDT);
            this.gbDat.Controls.Add(this.lblHoTen);
            this.gbDat.Controls.Add(this.lblCCCD);
            this.gbDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDat.Location = new System.Drawing.Point(0, 68);
            this.gbDat.Margin = new System.Windows.Forms.Padding(4);
            this.gbDat.Name = "gbDat";
            this.gbDat.Padding = new System.Windows.Forms.Padding(4);
            this.gbDat.Size = new System.Drawing.Size(1148, 301);
            this.gbDat.TabIndex = 4;
            this.gbDat.TabStop = false;
            this.gbDat.Text = "Đặt phòng mới";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(765, 196);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(233, 50);
            this.btnXacNhan.TabIndex = 16;
            this.btnXacNhan.Text = "Xác nhận đặt phòng";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // flpPhongTrong
            // 
            this.flpPhongTrong.AutoScroll = true;
            this.flpPhongTrong.Location = new System.Drawing.Point(140, 191);
            this.flpPhongTrong.Margin = new System.Windows.Forms.Padding(4);
            this.flpPhongTrong.Name = "flpPhongTrong";
            this.flpPhongTrong.Size = new System.Drawing.Size(607, 58);
            this.flpPhongTrong.TabIndex = 15;
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.AutoSize = true;
            this.lblPhongTrong.Location = new System.Drawing.Point(19, 199);
            this.lblPhongTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(90, 19);
            this.lblPhongTrong.TabIndex = 14;
            this.lblPhongTrong.Text = "Phòng trống:";
            // 
            // btnTim
            // 
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Location = new System.Drawing.Point(765, 139);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(187, 44);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm phòng trống";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // dtpDi
            // 
            this.dtpDi.CustomFormat = " dd/MM/yyyy";
            this.dtpDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDi.Location = new System.Drawing.Point(532, 144);
            this.dtpDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDi.Name = "dtpDi";
            this.dtpDi.Size = new System.Drawing.Size(209, 25);
            this.dtpDi.TabIndex = 12;
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = " dd/MM/yyyy";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(299, 144);
            this.dtpDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(209, 25);
            this.dtpDen.TabIndex = 11;
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(19, 144);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(256, 25);
            this.cboLoai.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(625, 65);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(233, 25);
            this.txtSDT.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(299, 65);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(303, 25);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(19, 65);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(256, 25);
            this.txtCCCD.TabIndex = 7;
            // 
            // lblLoi
            // 
            this.lblLoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLoi.Location = new System.Drawing.Point(19, 256);
            this.lblLoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(980, 26);
            this.lblLoi.TabIndex = 6;
            // 
            // lblDi
            // 
            this.lblDi.AutoSize = true;
            this.lblDi.Location = new System.Drawing.Point(532, 115);
            this.lblDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDi.Name = "lblDi";
            this.lblDi.Size = new System.Drawing.Size(56, 19);
            this.lblDi.TabIndex = 5;
            this.lblDi.Text = "Ngày đi";
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(299, 115);
            this.lblDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(68, 19);
            this.lblDen.TabIndex = 4;
            this.lblDen.Text = "Ngày đến";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(19, 115);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(82, 19);
            this.lblLoai.TabIndex = 3;
            this.lblLoai.Text = "Loại phòng ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(625, 37);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(89, 19);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(299, 37);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(51, 19);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(19, 37);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(46, 19);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblDanhSach.Location = new System.Drawing.Point(0, 369);
            this.lblDanhSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblDanhSach.Size = new System.Drawing.Size(1148, 39);
            this.lblDanhSach.TabIndex = 5;
            this.lblDanhSach.Text = "Danh sách đặt phòng";
            this.lblDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLoc
            // 
            this.pnlLoc.Controls.Add(this.cboLoc);
            this.pnlLoc.Controls.Add(this.txtTim);
            this.pnlLoc.Controls.Add(this.lblLoc);
            this.pnlLoc.Controls.Add(this.lblTim);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(0, 408);
            this.pnlLoc.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(1148, 48);
            this.pnlLoc.TabIndex = 6;
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(548, 13);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(174, 25);
            this.cboLoc.TabIndex = 3;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(70, 13);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.MaxLength = 50;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(349, 25);
            this.txtTim.TabIndex = 2;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(443, 20);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(73, 19);
            this.lblLoc.TabIndex = 1;
            this.lblLoc.Text = "Trạng thái:";
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(23, 20);
            this.lblTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(34, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Tìm:";
            // 
            // pnlNut
            // 
            this.pnlNut.Controls.Add(this.chart1);
            this.pnlNut.Controls.Add(this.btnXoaDon);
            this.pnlNut.Controls.Add(this.btnDoiPhong);
            this.pnlNut.Controls.Add(this.btnHuyDat);
            this.pnlNut.Controls.Add(this.btnNhanPhong);
            this.pnlNut.Controls.Add(this.lblChon);
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNut.Location = new System.Drawing.Point(0, 686);
            this.pnlNut.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Size = new System.Drawing.Size(1148, 48);
            this.pnlNut.TabIndex = 7;
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiPhong.Enabled = false;
            this.btnDoiPhong.Location = new System.Drawing.Point(670, 7);
            this.btnDoiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(117, 44);
            this.btnDoiPhong.TabIndex = 3;
            this.btnDoiPhong.Text = "Đổi phòng";
            this.btnDoiPhong.UseVisualStyleBackColor = true;
            // 
            // btnHuyDat
            // 
            this.btnHuyDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDat.Enabled = false;
            this.btnHuyDat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnHuyDat.Location = new System.Drawing.Point(1020, 7);
            this.btnHuyDat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyDat.Name = "btnHuyDat";
            this.btnHuyDat.Size = new System.Drawing.Size(117, 44);
            this.btnHuyDat.TabIndex = 2;
            this.btnHuyDat.Text = "Hủy đặt";
            this.btnHuyDat.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhanPhong.Enabled = false;
            this.btnNhanPhong.Location = new System.Drawing.Point(896, 7);
            this.btnNhanPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(117, 44);
            this.btnNhanPhong.TabIndex = 1;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblChon.Location = new System.Drawing.Point(23, 18);
            this.lblChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(143, 19);
            this.lblChon.TabIndex = 0;
            this.lblChon.Text = "Chưa chọn đặt phòng";
            // 
            // lvDat
            // 
            this.lvDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDat.FullRowSelect = true;
            this.lvDat.GridLines = true;
            this.lvDat.HideSelection = false;
            this.lvDat.Location = new System.Drawing.Point(0, 456);
            this.lvDat.Margin = new System.Windows.Forms.Padding(4);
            this.lvDat.MultiSelect = false;
            this.lvDat.Name = "lvDat";
            this.lvDat.Size = new System.Drawing.Size(1148, 230);
            this.lvDat.TabIndex = 8;
            this.lvDat.UseCompatibleStateImageBehavior = false;
            this.lvDat.View = System.Windows.Forms.View.Details;
            // 
            // btnXoaDon
            // 
            this.btnXoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDon.Enabled = false;
            this.btnXoaDon.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoaDon.Location = new System.Drawing.Point(560, 7);
            this.btnXoaDon.Name = "btnXoaDon";
            this.btnXoaDon.Size = new System.Drawing.Size(100, 34);
            this.btnXoaDon.TabIndex = 4;
            this.btnXoaDon.Text = "Xóa dòng";
            this.btnXoaDon.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1148, 734);
            this.ControlBox = false;
            this.Controls.Add(this.lvDat);
            this.Controls.Add(this.pnlNut);
            this.Controls.Add(this.pnlLoc);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.gbDat);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Đặt phòng";
            ((System.ComponentModel.ISupportInitialize)(this.errDat)).EndInit();
            this.gbDat.ResumeLayout(false);
            this.gbDat.PerformLayout();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            this.pnlNut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errDat;
        private System.Windows.Forms.GroupBox gbDat;
        private System.Windows.Forms.Label lblLoi;
        private System.Windows.Forms.Label lblDi;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListView lvDat;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.DateTimePicker dtpDi;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.FlowLayoutPanel flpPhongTrong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Button btnHuyDat;
        private System.Windows.Forms.Button btnDoiPhong;
        private System.Windows.Forms.Button btnXoaDon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}