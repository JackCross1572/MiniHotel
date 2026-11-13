namespace WindowsFormsApp2
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sfdBaoCao = new System.Windows.Forms.SaveFileDialog();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.btnXuatBC = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboKieu = new System.Windows.Forms.ComboBox();
            this.lblKieu = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tlpThe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCongSuat = new System.Windows.Forms.Panel();
            this.lblCongSuat = new System.Windows.Forms.Label();
            this.lblTenCS = new System.Windows.Forms.Label();
            this.pnlLuot = new System.Windows.Forms.Panel();
            this.lblLuotTra = new System.Windows.Forms.Label();
            this.lblTenLuot = new System.Windows.Forms.Label();
            this.pnlKy = new System.Windows.Forms.Panel();
            this.lblDoanhThuKy = new System.Windows.Forms.Label();
            this.lblTenKy = new System.Windows.Forms.Label();
            this.pnlTong = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTenTong = new System.Windows.Forms.Label();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLoc.SuspendLayout();
            this.tlpThe.SuspendLayout();
            this.pnlCongSuat.SuspendLayout();
            this.pnlLuot.SuspendLayout();
            this.pnlKy.SuspendLayout();
            this.pnlTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoc
            // 
            this.pnlLoc.Controls.Add(this.btnXuatBC);
            this.pnlLoc.Controls.Add(this.cboThang);
            this.pnlLoc.Controls.Add(this.lblThang);
            this.pnlLoc.Controls.Add(this.cboNam);
            this.pnlLoc.Controls.Add(this.lblNam);
            this.pnlLoc.Controls.Add(this.cboKieu);
            this.pnlLoc.Controls.Add(this.lblKieu);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(14, 62);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(956, 48);
            this.pnlLoc.TabIndex = 0;
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.Location = new System.Drawing.Point(610, 8);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.Size = new System.Drawing.Size(170, 32);
            this.btnXuatBC.TabIndex = 6;
            this.btnXuatBC.Text = "Xuất báo cáo";
            this.btnXuatBC.UseVisualStyleBackColor = true;
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(470, 10);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(110, 25);
            this.cboThang.TabIndex = 5;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(415, 15);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(47, 17);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng:";
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(305, 10);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(90, 25);
            this.cboNam.TabIndex = 3;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(265, 15);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // cboKieu
            // 
            this.cboKieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieu.FormattingEnabled = true;
            this.cboKieu.Location = new System.Drawing.Point(125, 10);
            this.cboKieu.Name = "cboKieu";
            this.cboKieu.Size = new System.Drawing.Size(120, 25);
            this.cboKieu.TabIndex = 1;
            // 
            // lblKieu
            // 
            this.lblKieu.AutoSize = true;
            this.lblKieu.Location = new System.Drawing.Point(20, 15);
            this.lblKieu.Name = "lblKieu";
            this.lblKieu.Size = new System.Drawing.Size(95, 17);
            this.lblKieu.TabIndex = 0;
            this.lblKieu.Text = "Thống kê theo:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTieuDe.Location = new System.Drawing.Point(14, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(956, 62);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Thống kê doanh thu";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpThe
            // 
            this.tlpThe.ColumnCount = 4;
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.Controls.Add(this.pnlCongSuat, 3, 0);
            this.tlpThe.Controls.Add(this.pnlLuot, 2, 0);
            this.tlpThe.Controls.Add(this.pnlKy, 0, 0);
            this.tlpThe.Controls.Add(this.pnlTong, 1, 0);
            this.tlpThe.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpThe.Location = new System.Drawing.Point(14, 110);
            this.tlpThe.Name = "tlpThe";
            this.tlpThe.RowCount = 1;
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpThe.Size = new System.Drawing.Size(956, 96);
            this.tlpThe.TabIndex = 2;
            // 
            // pnlCongSuat
            // 
            this.pnlCongSuat.BackColor = System.Drawing.Color.White;
            this.pnlCongSuat.Controls.Add(this.lblCongSuat);
            this.pnlCongSuat.Controls.Add(this.lblTenCS);
            this.pnlCongSuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCongSuat.Location = new System.Drawing.Point(720, 3);
            this.pnlCongSuat.Name = "pnlCongSuat";
            this.pnlCongSuat.Size = new System.Drawing.Size(233, 90);
            this.pnlCongSuat.TabIndex = 3;
            // 
            // lblCongSuat
            // 
            this.lblCongSuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCongSuat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongSuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblCongSuat.Location = new System.Drawing.Point(0, 13);
            this.lblCongSuat.Name = "lblCongSuat";
            this.lblCongSuat.Size = new System.Drawing.Size(233, 77);
            this.lblCongSuat.TabIndex = 7;
            this.lblCongSuat.Text = "0%";
            this.lblCongSuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenCS
            // 
            this.lblTenCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenCS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenCS.Location = new System.Drawing.Point(0, 0);
            this.lblTenCS.Name = "lblTenCS";
            this.lblTenCS.Size = new System.Drawing.Size(233, 13);
            this.lblTenCS.TabIndex = 6;
            this.lblTenCS.Text = "Công suất phòng";
            // 
            // pnlLuot
            // 
            this.pnlLuot.BackColor = System.Drawing.Color.White;
            this.pnlLuot.Controls.Add(this.lblLuotTra);
            this.pnlLuot.Controls.Add(this.lblTenLuot);
            this.pnlLuot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLuot.Location = new System.Drawing.Point(481, 3);
            this.pnlLuot.Name = "pnlLuot";
            this.pnlLuot.Size = new System.Drawing.Size(233, 90);
            this.pnlLuot.TabIndex = 2;
            // 
            // lblLuotTra
            // 
            this.lblLuotTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLuotTra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuotTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblLuotTra.Location = new System.Drawing.Point(0, 13);
            this.lblLuotTra.Name = "lblLuotTra";
            this.lblLuotTra.Size = new System.Drawing.Size(233, 77);
            this.lblLuotTra.TabIndex = 7;
            this.lblLuotTra.Text = "0";
            this.lblLuotTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenLuot
            // 
            this.lblTenLuot.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenLuot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLuot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenLuot.Location = new System.Drawing.Point(0, 0);
            this.lblTenLuot.Name = "lblTenLuot";
            this.lblTenLuot.Size = new System.Drawing.Size(233, 13);
            this.lblTenLuot.TabIndex = 6;
            this.lblTenLuot.Text = "Số lượt trả phòng";
            // 
            // pnlKy
            // 
            this.pnlKy.BackColor = System.Drawing.Color.White;
            this.pnlKy.Controls.Add(this.lblDoanhThuKy);
            this.pnlKy.Controls.Add(this.lblTenKy);
            this.pnlKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKy.Location = new System.Drawing.Point(3, 3);
            this.pnlKy.Name = "pnlKy";
            this.pnlKy.Size = new System.Drawing.Size(233, 90);
            this.pnlKy.TabIndex = 0;
            // 
            // lblDoanhThuKy
            // 
            this.lblDoanhThuKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoanhThuKy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblDoanhThuKy.Location = new System.Drawing.Point(0, 13);
            this.lblDoanhThuKy.Name = "lblDoanhThuKy";
            this.lblDoanhThuKy.Size = new System.Drawing.Size(233, 77);
            this.lblDoanhThuKy.TabIndex = 6;
            this.lblDoanhThuKy.Text = "0Đ";
            this.lblDoanhThuKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenKy
            // 
            this.lblTenKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenKy.Location = new System.Drawing.Point(0, 0);
            this.lblTenKy.Name = "lblTenKy";
            this.lblTenKy.Size = new System.Drawing.Size(233, 13);
            this.lblTenKy.TabIndex = 5;
            this.lblTenKy.Text = "Doanh thu";
            // 
            // pnlTong
            // 
            this.pnlTong.BackColor = System.Drawing.Color.White;
            this.pnlTong.Controls.Add(this.lblTongDoanhThu);
            this.pnlTong.Controls.Add(this.lblTenTong);
            this.pnlTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTong.Location = new System.Drawing.Point(242, 3);
            this.pnlTong.Name = "pnlTong";
            this.pnlTong.Size = new System.Drawing.Size(233, 90);
            this.pnlTong.TabIndex = 1;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(0, 13);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(233, 77);
            this.lblTongDoanhThu.TabIndex = 7;
            this.lblTongDoanhThu.Text = "0Đ";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenTong
            // 
            this.lblTenTong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenTong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTenTong.Location = new System.Drawing.Point(0, 0);
            this.lblTenTong.Name = "lblTenTong";
            this.lblTenTong.Size = new System.Drawing.Size(233, 13);
            this.lblTenTong.TabIndex = 6;
            this.lblTenTong.Text = "Tổng doanh thu";
            // 
            // chartDT
            // 
            this.chartDT.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.chartDT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea1);
            this.chartDT.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDT.Legends.Add(legend1);
            this.chartDT.Location = new System.Drawing.Point(14, 206);
            this.chartDT.Name = "chartDT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDT.Series.Add(series1);
            this.chartDT.Size = new System.Drawing.Size(956, 355);
            this.chartDT.TabIndex = 3;
            this.chartDT.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.tlpThe);
            this.Controls.Add(this.pnlLoc);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Thống kê doanh thu";
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.tlpThe.ResumeLayout(false);
            this.pnlCongSuat.ResumeLayout(false);
            this.pnlLuot.ResumeLayout(false);
            this.pnlKy.ResumeLayout(false);
            this.pnlTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdBaoCao;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tlpThe;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboKieu;
        private System.Windows.Forms.Label lblKieu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.Button btnXuatBC;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Panel pnlKy;
        private System.Windows.Forms.Panel pnlCongSuat;
        private System.Windows.Forms.Label lblCongSuat;
        private System.Windows.Forms.Label lblTenCS;
        private System.Windows.Forms.Panel pnlLuot;
        private System.Windows.Forms.Label lblLuotTra;
        private System.Windows.Forms.Label lblTenLuot;
        private System.Windows.Forms.Label lblDoanhThuKy;
        private System.Windows.Forms.Label lblTenKy;
        private System.Windows.Forms.Panel pnlTong;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTenTong;
    }
}