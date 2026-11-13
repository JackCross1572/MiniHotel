using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmPhong : Form
    {
        static readonly string[] MaTT = { "Trong", "CoKhach", "DangDon" };
        bool _dangNap;

        public frmPhong()
        {
            InitializeComponent();

            Load += frmPhong_Load;
            FormClosed += frmPhong_FormClosed;
            tvPhong.AfterSelect += tvPhong_AfterSelect;
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            dgvLoai.SelectionChanged += dgvLoai_SelectionChanged;
            btnThemLoai.Click += btnThemLoai_Click;
            btnSuaLoai.Click += btnSuaLoai_Click;
            btnXoaLoai.Click += btnXoaLoai_Click;
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            // Cột bảng loại phòng
            dgvLoai.Columns.Clear();
            dgvLoai.Columns.Add("colMa", "Mã");
            dgvLoai.Columns.Add("colTen", "Tên loại");
            dgvLoai.Columns.Add("colGia", "Giá mỗi đêm");
            dgvLoai.Columns.Add("colSoPhong", "Số phòng");
            dgvLoai.Columns[0].FillWeight = 15;
            dgvLoai.Columns[1].FillWeight = 35;
            dgvLoai.Columns[2].FillWeight = 30;
            dgvLoai.Columns[3].FillWeight = 20;
            dgvLoai.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLoai.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Trạng thái phòng
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Có khách", "Đang dọn" });
            cboTrangThai.SelectedIndex = 0;

            DataStore.Changed += LamMoiDuLieu;   // dữ liệu đổi ở đâu cũng tự cập nhật
            LamMoiDuLieu();
            XoaTrangPhong();
        }

        private void frmPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStore.Changed -= LamMoiDuLieu;
        }

        private void LamMoiDuLieu()
        {
            _dangNap = true;
            try
            {
                NapLoai();
                NapCay();
            }
            finally { _dangNap = false; }
            HienLoaiDangChon();
        }

        // ---------- Cây Tầng -> Phòng ----------
        private Phong PhongChon()
        {
            return tvPhong.SelectedNode == null ? null : tvPhong.SelectedNode.Tag as Phong;
        }

        private void NapCay()
        {
            Phong cu = PhongChon();
            string soCu = cu == null ? null : cu.SoPhong;
            TreeNode chon = null;

            tvPhong.BeginUpdate();
            tvPhong.Nodes.Clear();
            foreach (var tang in DataStore.Phongs.GroupBy(p => p.Tang).OrderBy(g => g.Key))
            {
                TreeNode goc = new TreeNode("Tầng " + tang.Key);
                goc.Name = "tang" + tang.Key;
                foreach (Phong p in tang.OrderBy(x => x.SoPhong))
                {
                    TreeNode n = new TreeNode("Phòng " + p.SoPhong);
                    n.Tag = p;
                    goc.Nodes.Add(n);
                    if (p.SoPhong == soCu) chon = n;
                }
                tvPhong.Nodes.Add(goc);
            }
            tvPhong.ExpandAll();
            tvPhong.EndUpdate();

            if (chon != null)
            {
                tvPhong.SelectedNode = chon;
                HienPhong((Phong)chon.Tag);
            }
            else if (soCu != null)
            {
                XoaTrangPhong();   // phòng đang chọn vừa bị xóa
            }
        }

        private void tvPhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_dangNap) return;
            Phong p = e.Node == null ? null : e.Node.Tag as Phong;
            if (p != null) { errPhong.Clear(); HienPhong(p); }
        }

        private void HienPhong(Phong p)
        {
            txtSoPhong.Text = p.SoPhong;
            nudTang.Value = Math.Max(nudTang.Minimum, Math.Min(nudTang.Maximum, p.Tang));
            cboLoai.SelectedValue = p.MaLoai;
            cboTrangThai.SelectedIndex = Math.Max(0, Array.IndexOf(MaTT, p.TrangThai));
        }

        private void XoaTrangPhong()
        {
            errPhong.Clear();
            txtSoPhong.Clear();
            nudTang.Value = 1;
            if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
        }

        // Số phòng = số tầng + 2 chữ số (tầng 2 -> 201, 205...)
        private bool SoPhongHopLe(string so, int tang)
        {
            string t = tang.ToString();
            return so.Length == t.Length + 2 && so.All(char.IsDigit) && so.StartsWith(t);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tvPhong.SelectedNode = null;
            XoaTrangPhong();
            txtSoPhong.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errPhong.Clear();
            string so = txtSoPhong.Text.Trim();
            int tang = (int)nudTang.Value;

            if (!SoPhongHopLe(so, tang))
            {
                errPhong.SetError(txtSoPhong, "Số phòng gồm số tầng và 2 chữ số, ví dụ tầng 2: 205");
                txtSoPhong.Focus();
                return;
            }
            if (DataStore.Phongs.Any(p => p.SoPhong == so))
            {
                errPhong.SetError(txtSoPhong, "Số phòng đã tồn tại");
                txtSoPhong.Focus();
                return;
            }
            if (cboLoai.SelectedValue == null)
            {
                errPhong.SetError(cboLoai, "Chọn loại phòng");
                return;
            }
            try
            {
                DataStore.Phongs.Add(new Phong
                {
                    SoPhong = so,
                    Tang = tang,
                    MaLoai = cboLoai.SelectedValue.ToString(),
                    TrangThai = MaTT[Math.Max(0, cboTrangThai.SelectedIndex)]
                });
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "ThemPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errPhong.Clear();
            Phong p = PhongChon();
            if (p == null)
            {
                MessageBox.Show("Hãy chọn một phòng trong cây trước.", "Lưu thay đổi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoPhong.Text.Trim() != p.SoPhong)
            {
                errPhong.SetError(txtSoPhong, "Không đổi được số phòng. Hãy xóa rồi thêm phòng mới.");
                return;
            }
            int tang = (int)nudTang.Value;
            if (!SoPhongHopLe(p.SoPhong, tang))
            {
                errPhong.SetError(nudTang, "Tầng không khớp với số phòng");
                return;
            }
            if (cboLoai.SelectedValue == null)
            {
                errPhong.SetError(cboLoai, "Chọn loại phòng");
                return;
            }
            try
            {
                p.Tang = tang;
                p.MaLoai = cboLoai.SelectedValue.ToString();
                p.TrangThai = MaTT[Math.Max(0, cboTrangThai.SelectedIndex)];
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "LuuPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Phong p = PhongChon();
            if (p == null)
            {
                MessageBox.Show("Hãy chọn một phòng trong cây trước.", "Xóa phòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DataStore.Dats.Any(d => d.SoPhong == p.SoPhong
                    && (d.TrangThai == "DaDat" || d.TrangThai == "DangO")))
            {
                MessageBox.Show("Phòng " + p.SoPhong + " đang có đặt phòng (Đã đặt hoặc Đang ở), không thể xóa.",
                    "Xóa phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xóa phòng " + p.SoPhong + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DataStore.Phongs.Remove(p);
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XoaPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Loại phòng ----------
        private void NapLoai()
        {
            // ComboBox loại phòng ở khung thông tin
            object cu = cboLoai.SelectedValue;
            cboLoai.DataSource = null;
            cboLoai.DisplayMember = "Ten";
            cboLoai.ValueMember = "Ma";
            cboLoai.DataSource = DataStore.Loais.ToList();
            if (cu != null) cboLoai.SelectedValue = cu;

            // Bảng loại phòng
            string maCu = dgvLoai.CurrentRow == null ? null : Convert.ToString(dgvLoai.CurrentRow.Cells[0].Value);
            dgvLoai.Rows.Clear();
            foreach (LoaiPhong l in DataStore.Loais)
            {
                int soPhong = DataStore.Phongs.Count(p => p.MaLoai == l.Ma);   // đếm bằng code, không ghi cứng
                dgvLoai.Rows.Add(l.Ma, l.Ten, l.GiaNgay.ToString("N0"), soPhong);
            }
            if (maCu != null)
            {
                foreach (DataGridViewRow r in dgvLoai.Rows)
                {
                    if (Convert.ToString(r.Cells[0].Value) == maCu)
                    {
                        dgvLoai.CurrentCell = r.Cells[0];
                        r.Selected = true;
                        break;
                    }
                }
            }
        }

        private void dgvLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            HienLoaiDangChon();
        }

        private void HienLoaiDangChon()
        {
            if (dgvLoai.CurrentRow == null) return;
            string ma = Convert.ToString(dgvLoai.CurrentRow.Cells[0].Value);
            LoaiPhong l = DataStore.Loais.FirstOrDefault(x => x.Ma == ma);
            if (l == null) return;
            txtMaLoai.Text = l.Ma;
            txtTenLoai.Text = l.Ten;
            nudGia.Value = Math.Min(nudGia.Maximum, l.GiaNgay);
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            errPhong.Clear();
            string ma = txtMaLoai.Text.Trim();
            string ten = txtTenLoai.Text.Trim();

            if (ma == "") { errPhong.SetError(txtMaLoai, "Nhập mã loại"); txtMaLoai.Focus(); return; }
            if (ten == "") { errPhong.SetError(txtTenLoai, "Nhập tên loại"); txtTenLoai.Focus(); return; }
            if (ma.Contains(";") || ten.Contains(";"))
            {
                errPhong.SetError(txtTenLoai, "Không dùng dấu ; (dấu này dùng để ngăn cột trong tập tin)");
                return;
            }
            if (nudGia.Value <= 0) { errPhong.SetError(nudGia, "Giá phải lớn hơn 0"); return; }
            if (DataStore.Loais.Any(l => l.Ma == ma))
            {
                errPhong.SetError(txtMaLoai, "Mã loại đã tồn tại. Hãy nhập mã mới để thêm.");
                txtMaLoai.Focus();
                return;
            }
            try
            {
                DataStore.Loais.Add(new LoaiPhong { Ma = ma, Ten = ten, GiaNgay = nudGia.Value });
                DataStore.SaveLoai();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "ThemLoai");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            errPhong.Clear();
            if (dgvLoai.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một loại phòng trong bảng trước.", "Sửa loại phòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma = Convert.ToString(dgvLoai.CurrentRow.Cells[0].Value);
            LoaiPhong l = DataStore.Loais.FirstOrDefault(x => x.Ma == ma);
            if (l == null) return;

            string ten = txtTenLoai.Text.Trim();
            if (txtMaLoai.Text.Trim() != ma)
            {
                errPhong.SetError(txtMaLoai, "Không đổi được mã loại");
                return;
            }
            if (ten == "") { errPhong.SetError(txtTenLoai, "Nhập tên loại"); return; }
            if (ten.Contains(";"))
            {
                errPhong.SetError(txtTenLoai, "Không dùng dấu ;");
                return;
            }
            if (nudGia.Value <= 0) { errPhong.SetError(nudGia, "Giá phải lớn hơn 0"); return; }
            try
            {
                l.Ten = ten;
                l.GiaNgay = nudGia.Value;
                DataStore.SaveLoai();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "SuaLoai");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if (dgvLoai.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một loại phòng trong bảng trước.", "Xóa loại phòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma = Convert.ToString(dgvLoai.CurrentRow.Cells[0].Value);
            LoaiPhong l = DataStore.Loais.FirstOrDefault(x => x.Ma == ma);
            if (l == null) return;

            if (DataStore.Phongs.Any(p => p.MaLoai == ma))
            {
                MessageBox.Show("Loại \"" + l.Ten + "\" đang có phòng sử dụng, không thể xóa.",
                    "Xóa loại phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xóa loại phòng \"" + l.Ten + "\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DataStore.Loais.Remove(l);
                DataStore.SaveLoai();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XoaLoai");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}