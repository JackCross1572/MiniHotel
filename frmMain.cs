using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmMain : Form
    {
        private readonly User _user;
        private bool _thoatNgay;

        public frmMain() : this(null) { }

        public frmMain(User u)
        {
            InitializeComponent();
            _user = u;
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load += frmMain_Load;
            FormClosing += frmMain_FormClosing;
            tmrClock.Tick += tmrClock_Tick;

            btnTrangChu.Click += btnTrangChu_Click;
            btnPhong.Click += btnPhong_Click;
            btnDatPhong.Click += btnDatPhong_Click;
            btnDichVu.Click += btnDichVu_Click;
            btnThongKe.Click += btnThongKe_Click;
            mnuTrangChu.Click += btnTrangChu_Click;
            mnuPhong.Click += btnPhong_Click;
            mnuDatPhong.Click += btnDatPhong_Click;
            mnuDichVu.Click += btnDichVu_Click;
            mnuThongKe.Click += btnThongKe_Click;

            btnDangXuat.Click += mnuDangXuat_Click;
            mnuDangXuat.Click += mnuDangXuat_Click;
            mnuSaoLuu.Click += mnuSaoLuu_Click;
            mnuKhoiPhuc.Click += mnuKhoiPhuc_Click;
            mnuThoat.Click += mnuThoat_Click;
            mnuGioiThieu.Click += mnuGioiThieu_Click;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is MdiClient) c.BackColor = Color.FromArgb(244, 246, 249);

            bool admin = _user != null && _user.VaiTro == "Admin";
            tslUser.Text = "Người dùng: " + (_user == null ? "-" : _user.TenDN);
            tslVaiTro.Text = "Vai trò: " + (_user == null ? "-" : (admin ? "Quản trị" : "Lễ tân"));

            btnThongKe.Visible = admin;
            mnuBaoCao.Visible = admin;
            mnuSaoLuu.Visible = admin;
            mnuKhoiPhuc.Visible = admin;
            sepHeThong1.Visible = admin;

            tmrClock_Tick(null, null);
            OpenChild<frmTrangChu>();
            Activate();        // thêm dòng này
            BringToFront();    // và dòng này
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tslClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Mở form con, không mở trùng
        private void OpenChild<T>() where T : Form, new()
        {
            T f = MdiChildren.OfType<T>().FirstOrDefault();
            if (f != null) { f.Activate(); return; }
            f = new T { MdiParent = this, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            f.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
             OpenChild<frmTrangChu>();   // bỏ // khi đã tạo form này
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
             OpenChild<frmPhong>();
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            OpenChild<frmDatPhong>();
        }

        public void MoDatPhong()
        {
            OpenChild<frmDatPhong>();
        }
        private void btnDichVu_Click(object sender, EventArgs e)
        {
             OpenChild<frmDichVu>();
        }
        public void MoDichVu()
        {
            OpenChild<frmDichVu>();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
             OpenChild<frmThongKe>();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _thoatNgay = true;
            Application.Restart();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_thoatNgay) return;
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void mnuSaoLuu_Click(object sender, EventArgs e)
        {
            string goc = AppDomain.CurrentDomain.BaseDirectory;
            if (fbdSaoLuu.ShowDialog() != DialogResult.OK) return;
            try
            {
                string dich = Path.Combine(fbdSaoLuu.SelectedPath,
                    "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmm"));
                Directory.CreateDirectory(dich);
                foreach (string f in Directory.GetFiles(goc, "*.txt"))
                {
                    if (Path.GetFileName(f) == "log.txt") continue;
                    File.Copy(f, Path.Combine(dich, Path.GetFileName(f)), true);
                }
                MessageBox.Show("Đã sao lưu vào thư mục:" + Environment.NewLine + dich,
                    "Sao lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "SaoLuu");
                MessageBox.Show("Không sao lưu được dữ liệu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (fbdKhoiPhuc.ShowDialog() != DialogResult.OK) return;
            try
            {
                string goc = AppDomain.CurrentDomain.BaseDirectory;
                string[] ds = Directory.GetFiles(fbdKhoiPhuc.SelectedPath, "*.txt");
                if (ds.Length == 0)
                {
                    MessageBox.Show("Thư mục này không có tập tin .txt để khôi phục.", "Khôi phục",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (string f in ds)
                    File.Copy(f, Path.Combine(goc, Path.GetFileName(f)), true);
                // Khi đã có DataStore: DataStore.LoadAll(); DataStore.RaiseChanged();
                MessageBox.Show("Đã khôi phục dữ liệu.", "Khôi phục",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "KhoiPhuc");
                MessageBox.Show("Không khôi phục được dữ liệu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MiniHotel - Quản lý khách sạn mini" + Environment.NewLine +
                "Đề 4 - Lập trình WinForms", "Giới thiệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tslUser_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void trwofToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
