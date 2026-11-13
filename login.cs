using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmLogin : Form
    {
        public User NguoiDung { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void lblTieuDe_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errLogin.Clear();
            lblLoi.Text = "";

            if (txtUser.Text.Trim() == "")
            {
                errLogin.SetError(txtUser, "Nhập tên đăng nhập");
                txtUser.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                errLogin.SetError(txtPass, "Nhập mật khẩu");
                txtPass.Focus();
                return;
            }

            string loi;
            User u = AuthService.Check(txtUser.Text.Trim(), txtPass.Text, out loi);
            if (u == null)
            {
                lblLoi.Text = loi;
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            using (RegistryKey k = Registry.CurrentUser.CreateSubKey(@"Software\MiniHotel"))
            {
                if (chkNho.Checked) k.SetValue("LastUser", u.TenDN);
                else k.DeleteValue("LastUser", false);
            }

            NguoiDung = u;
            DialogResult = DialogResult.OK;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\MiniHotel"))
            {
                string last = (k == null) ? null : k.GetValue("LastUser") as string;
                if (!string.IsNullOrEmpty(last))
                {
                    txtUser.Text = last;
                    ActiveControl = txtPass;
                }
            }
        }
    }
}
