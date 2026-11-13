namespace WindowsFormsApp2
{
    partial class frmTrangChu
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
            this.imgPhong = new System.Windows.Forms.ImageList(this.components);
            this.tmrNhac = new System.Windows.Forms.Timer(this.components);
            this.ctxPhong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNhanPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.sepCtx = new System.Windows.Forms.ToolStripSeparator();
            this.ctxDangDon = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tlpThe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTenDoanhThu = new System.Windows.Forms.Label();
            this.pnlDangDon = new System.Windows.Forms.Panel();
            this.lblSoDangDon = new System.Windows.Forms.Label();
            this.lblTenDangDon = new System.Windows.Forms.Label();
            this.pnlCoKhach = new System.Windows.Forms.Panel();
            this.lblSoCoKhach = new System.Windows.Forms.Label();
            this.lblTenCoKhach = new System.Windows.Forms.Label();
            this.pnlTrong = new System.Windows.Forms.Panel();
            this.lblSoTrong = new System.Windows.Forms.Label();
            this.lblTenTrong = new System.Windows.Forms.Label();
            this.flpChuThich = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCtTrong = new System.Windows.Forms.Label();
            this.lblCtCoKhach = new System.Windows.Forms.Label();
            this.lblCtDangDon = new System.Windows.Forms.Label();
            this.lblNhac = new System.Windows.Forms.Label();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.ctxPhong.SuspendLayout();
            this.tlpThe.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlDangDon.SuspendLayout();
            this.pnlCoKhach.SuspendLayout();
            this.pnlTrong.SuspendLayout();
            this.flpChuThich.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPhong
            // 
            this.imgPhong.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgPhong.ImageSize = new System.Drawing.Size(48, 48);
            this.imgPhong.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tmrNhac
            // 
            this.tmrNhac.Enabled = true;
            this.tmrNhac.Interval = 30000;
            // 
            // ctxPhong
            // 
            this.ctxPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDatPhong,
            this.ctxNhanPhong,
            this.ctxTraPhong,
            this.sepCtx,
            this.ctxDangDon,
            this.ctxTrong});
            this.ctxPhong.Name = "ctxPhong";
            this.ctxPhong.Size = new System.Drawing.Size(194, 120);
            // 
            // ctxDatPhong
            // 
            this.ctxDatPhong.Name = "ctxDatPhong";
            this.ctxDatPhong.Size = new System.Drawing.Size(193, 22);
            this.ctxDatPhong.Text = "Đặt phòng";
            // 
            // ctxNhanPhong
            // 
            this.ctxNhanPhong.Name = "ctxNhanPhong";
            this.ctxNhanPhong.Size = new System.Drawing.Size(193, 22);
            this.ctxNhanPhong.Text = "Nhận phòng";
            // 
            // ctxTraPhong
            // 
            this.ctxTraPhong.Name = "ctxTraPhong";
            this.ctxTraPhong.Size = new System.Drawing.Size(193, 22);
            this.ctxTraPhong.Text = "Trả phòng";
            // 
            // sepCtx
            // 
            this.sepCtx.Name = "sepCtx";
            this.sepCtx.Size = new System.Drawing.Size(190, 6);
            // 
            // ctxDangDon
            // 
            this.ctxDangDon.Name = "ctxDangDon";
            this.ctxDangDon.Size = new System.Drawing.Size(193, 22);
            this.ctxDangDon.Text = "Đánh dấu đang dọn";
            // 
            // ctxTrong
            // 
            this.ctxTrong.Name = "ctxTrong";
            this.ctxTrong.Size = new System.Drawing.Size(193, 22);
            this.ctxTrong.Text = "Đánh dấu trống";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(1010, 52);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Sơ đồ phòng";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpThe
            // 
            this.tlpThe.ColumnCount = 4;
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.Controls.Add(this.pnlDoanhThu, 3, 0);
            this.tlpThe.Controls.Add(this.pnlDangDon, 2, 0);
            this.tlpThe.Controls.Add(this.pnlCoKhach, 1, 0);
            this.tlpThe.Controls.Add(this.pnlTrong, 0, 0);
            this.tlpThe.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpThe.Location = new System.Drawing.Point(0, 52);
            this.tlpThe.Name = "tlpThe";
            this.tlpThe.Padding = new System.Windows.Forms.Padding(14, 0, 14, 8);
            this.tlpThe.RowCount = 1;
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpThe.Size = new System.Drawing.Size(1010, 96);
            this.tlpThe.TabIndex = 2;
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblTenDoanhThu);
            this.pnlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoanhThu.Location = new System.Drawing.Point(755, 0);
            this.pnlDoanhThu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlDoanhThu.Size = new System.Drawing.Size(235, 88);
            this.pnlDoanhThu.TabIndex = 3;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblDoanhThu.Location = new System.Drawing.Point(12, 30);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblDoanhThu.Size = new System.Drawing.Size(211, 50);
            this.lblDoanhThu.TabIndex = 3;
            this.lblDoanhThu.Text = "0";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDoanhThu
            // 
            this.lblTenDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenDoanhThu.Location = new System.Drawing.Point(12, 8);
            this.lblTenDoanhThu.Name = "lblTenDoanhThu";
            this.lblTenDoanhThu.Size = new System.Drawing.Size(211, 22);
            this.lblTenDoanhThu.TabIndex = 1;
            this.lblTenDoanhThu.Text = "Doanh thu hôm nay";
            // 
            // pnlDangDon
            // 
            this.pnlDangDon.BackColor = System.Drawing.Color.White;
            this.pnlDangDon.Controls.Add(this.lblSoDangDon);
            this.pnlDangDon.Controls.Add(this.lblTenDangDon);
            this.pnlDangDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDangDon.Location = new System.Drawing.Point(510, 0);
            this.pnlDangDon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlDangDon.Name = "pnlDangDon";
            this.pnlDangDon.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlDangDon.Size = new System.Drawing.Size(233, 88);
            this.pnlDangDon.TabIndex = 2;
            // 
            // lblSoDangDon
            // 
            this.lblSoDangDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoDangDon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoDangDon.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSoDangDon.Location = new System.Drawing.Point(12, 30);
            this.lblSoDangDon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoDangDon.Name = "lblSoDangDon";
            this.lblSoDangDon.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblSoDangDon.Size = new System.Drawing.Size(209, 50);
            this.lblSoDangDon.TabIndex = 3;
            this.lblSoDangDon.Text = "0";
            this.lblSoDangDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDangDon
            // 
            this.lblTenDangDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenDangDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDangDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenDangDon.Location = new System.Drawing.Point(12, 8);
            this.lblTenDangDon.Name = "lblTenDangDon";
            this.lblTenDangDon.Size = new System.Drawing.Size(209, 22);
            this.lblTenDangDon.TabIndex = 1;
            this.lblTenDangDon.Text = "Đang dọn";
            // 
            // pnlCoKhach
            // 
            this.pnlCoKhach.BackColor = System.Drawing.Color.White;
            this.pnlCoKhach.Controls.Add(this.lblSoCoKhach);
            this.pnlCoKhach.Controls.Add(this.lblTenCoKhach);
            this.pnlCoKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoKhach.Location = new System.Drawing.Point(265, 0);
            this.pnlCoKhach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlCoKhach.Name = "pnlCoKhach";
            this.pnlCoKhach.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlCoKhach.Size = new System.Drawing.Size(233, 88);
            this.pnlCoKhach.TabIndex = 1;
            // 
            // lblSoCoKhach
            // 
            this.lblSoCoKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoCoKhach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoCoKhach.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSoCoKhach.Location = new System.Drawing.Point(12, 30);
            this.lblSoCoKhach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoCoKhach.Name = "lblSoCoKhach";
            this.lblSoCoKhach.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblSoCoKhach.Size = new System.Drawing.Size(209, 50);
            this.lblSoCoKhach.TabIndex = 2;
            this.lblSoCoKhach.Text = "0";
            this.lblSoCoKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenCoKhach
            // 
            this.lblTenCoKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenCoKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenCoKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenCoKhach.Location = new System.Drawing.Point(12, 8);
            this.lblTenCoKhach.Name = "lblTenCoKhach";
            this.lblTenCoKhach.Size = new System.Drawing.Size(209, 22);
            this.lblTenCoKhach.TabIndex = 1;
            this.lblTenCoKhach.Text = "Có khách";
            // 
            // pnlTrong
            // 
            this.pnlTrong.BackColor = System.Drawing.Color.White;
            this.pnlTrong.Controls.Add(this.lblSoTrong);
            this.pnlTrong.Controls.Add(this.lblTenTrong);
            this.pnlTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrong.Location = new System.Drawing.Point(20, 0);
            this.pnlTrong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pnlTrong.Name = "pnlTrong";
            this.pnlTrong.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlTrong.Size = new System.Drawing.Size(233, 88);
            this.pnlTrong.TabIndex = 0;
            // 
            // lblSoTrong
            // 
            this.lblSoTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoTrong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(130)))), ((int)(((byte)(87)))));
            this.lblSoTrong.Location = new System.Drawing.Point(12, 30);
            this.lblSoTrong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoTrong.Name = "lblSoTrong";
            this.lblSoTrong.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblSoTrong.Size = new System.Drawing.Size(209, 50);
            this.lblSoTrong.TabIndex = 3;
            this.lblSoTrong.Text = "0";
            this.lblSoTrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenTrong
            // 
            this.lblTenTrong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenTrong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenTrong.Location = new System.Drawing.Point(12, 8);
            this.lblTenTrong.Name = "lblTenTrong";
            this.lblTenTrong.Size = new System.Drawing.Size(209, 22);
            this.lblTenTrong.TabIndex = 0;
            this.lblTenTrong.Text = "Phòng trống";
            // 
            // flpChuThich
            // 
            this.flpChuThich.Controls.Add(this.lblCtTrong);
            this.flpChuThich.Controls.Add(this.lblCtCoKhach);
            this.flpChuThich.Controls.Add(this.lblCtDangDon);
            this.flpChuThich.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpChuThich.Location = new System.Drawing.Point(0, 148);
            this.flpChuThich.Name = "flpChuThich";
            this.flpChuThich.Size = new System.Drawing.Size(1010, 32);
            this.flpChuThich.TabIndex = 3;
            // 
            // lblCtTrong
            // 
            this.lblCtTrong.AutoSize = true;
            this.lblCtTrong.Location = new System.Drawing.Point(0, 0);
            this.lblCtTrong.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.lblCtTrong.Name = "lblCtTrong";
            this.lblCtTrong.Size = new System.Drawing.Size(56, 19);
            this.lblCtTrong.TabIndex = 4;
            this.lblCtTrong.Text = "● Trống";
            // 
            // lblCtCoKhach
            // 
            this.lblCtCoKhach.AutoSize = true;
            this.lblCtCoKhach.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCtCoKhach.Location = new System.Drawing.Point(72, 0);
            this.lblCtCoKhach.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.lblCtCoKhach.Name = "lblCtCoKhach";
            this.lblCtCoKhach.Size = new System.Drawing.Size(78, 19);
            this.lblCtCoKhach.TabIndex = 5;
            this.lblCtCoKhach.Text = "\t● Có khách";
            // 
            // lblCtDangDon
            // 
            this.lblCtDangDon.AutoSize = true;
            this.lblCtDangDon.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCtDangDon.Location = new System.Drawing.Point(166, 0);
            this.lblCtDangDon.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.lblCtDangDon.Name = "lblCtDangDon";
            this.lblCtDangDon.Size = new System.Drawing.Size(82, 19);
            this.lblCtDangDon.TabIndex = 6;
            this.lblCtDangDon.Text = "\t● Đang dọn";
            // 
            // lblNhac
            // 
            this.lblNhac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.lblNhac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNhac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblNhac.Location = new System.Drawing.Point(0, 616);
            this.lblNhac.Name = "lblNhac";
            this.lblNhac.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblNhac.Size = new System.Drawing.Size(1010, 34);
            this.lblNhac.TabIndex = 4;
            this.lblNhac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNhac.Visible = false;
            // 
            // lvPhong
            // 
            this.lvPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.lvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPhong.ContextMenuStrip = this.ctxPhong;
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.HideSelection = false;
            this.lvPhong.LargeImageList = this.imgPhong;
            this.lvPhong.Location = new System.Drawing.Point(0, 180);
            this.lvPhong.MultiSelect = false;
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(1010, 436);
            this.lvPhong.TabIndex = 5;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.ControlBox = false;
            this.Controls.Add(this.lvPhong);
            this.Controls.Add(this.lblNhac);
            this.Controls.Add(this.flpChuThich);
            this.Controls.Add(this.tlpThe);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sơ đồ phòng";
            this.ctxPhong.ResumeLayout(false);
            this.tlpThe.ResumeLayout(false);
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDangDon.ResumeLayout(false);
            this.pnlCoKhach.ResumeLayout(false);
            this.pnlTrong.ResumeLayout(false);
            this.flpChuThich.ResumeLayout(false);
            this.flpChuThich.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgPhong;
        private System.Windows.Forms.Timer tmrNhac;
        private System.Windows.Forms.ContextMenuStrip ctxPhong;
        private System.Windows.Forms.ToolStripMenuItem ctxDatPhong;
        private System.Windows.Forms.ToolStripMenuItem ctxNhanPhong;
        private System.Windows.Forms.ToolStripMenuItem ctxTraPhong;
        private System.Windows.Forms.ToolStripSeparator sepCtx;
        private System.Windows.Forms.ToolStripMenuItem ctxDangDon;
        private System.Windows.Forms.ToolStripMenuItem ctxTrong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tlpThe;
        private System.Windows.Forms.Panel pnlTrong;
        private System.Windows.Forms.FlowLayoutPanel flpChuThich;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblTenDoanhThu;
        private System.Windows.Forms.Panel pnlDangDon;
        private System.Windows.Forms.Label lblTenDangDon;
        private System.Windows.Forms.Panel pnlCoKhach;
        private System.Windows.Forms.Label lblTenCoKhach;
        private System.Windows.Forms.Label lblTenTrong;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblSoDangDon;
        private System.Windows.Forms.Label lblSoCoKhach;
        private System.Windows.Forms.Label lblSoTrong;
        private System.Windows.Forms.Label lblCtTrong;
        private System.Windows.Forms.Label lblCtCoKhach;
        private System.Windows.Forms.Label lblCtDangDon;
        private System.Windows.Forms.Label lblNhac;
        private System.Windows.Forms.ListView lvPhong;
    }
}