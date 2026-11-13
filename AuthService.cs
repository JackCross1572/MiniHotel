using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsFormsApp2
{
    public static class AuthService
    {
        private static string FilePath
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt"); }
        }

        public static string Hash(string s)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] b = sha.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder sb = new StringBuilder();
                foreach (byte x in b) sb.Append(x.ToString("x2"));
                return sb.ToString();
            }
        }

        public static List<User> Load()
        {
            List<User> list = new List<User>();
            try
            {
                if (!File.Exists(FilePath))
                {
                    // Tự tạo tập tin với 2 tài khoản mẫu
                    list.Add(new User { TenDN = "admin", MatKhauHash = Hash("admin123"), VaiTro = "Admin" });
                    list.Add(new User { TenDN = "letan", MatKhauHash = Hash("letan123"), VaiTro = "LeTan" });
                    Save(list);
                    return list;
                }
                foreach (string line in File.ReadAllLines(FilePath, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] p = line.Split(';');
                    if (p.Length != 5) continue;          // bỏ dòng sai định dạng
                    try
                    {
                        list.Add(new User
                        {
                            TenDN = p[0],
                            MatKhauHash = p[1],
                            VaiTro = p[2],
                            SoLanSai = int.Parse(p[3]),
                            Khoa = p[4] == "1"
                        });
                    }
                    catch (Exception ex) { Logger.Write(ex, "users.txt: " + line); }
                }
            }
            catch (Exception ex) { Logger.Write(ex, "AuthService.Load"); }
            return list;
        }

        public static void Save(List<User> list)
        {
            List<string> lines = new List<string>();
            foreach (User u in list)
                lines.Add(u.TenDN + ";" + u.MatKhauHash + ";" + u.VaiTro + ";" + u.SoLanSai + ";" + (u.Khoa ? "1" : "0"));
            File.WriteAllLines(FilePath, lines.ToArray(), Encoding.UTF8);
        }

        // Trả về User nếu đúng; trả về null kèm thông báo lỗi trong loi nếu sai
        public static User Check(string tenDN, string matKhau, out string loi)
        {
            loi = "";
            try
            {
                List<User> ds = Load();
                User u = ds.Find(x => x.TenDN.Equals(tenDN, StringComparison.OrdinalIgnoreCase));
                if (u == null) { loi = "Sai tên đăng nhập hoặc mật khẩu."; return null; }
                if (u.Khoa) { loi = "Tài khoản đã bị khóa do nhập sai 3 lần."; return null; }

                if (u.MatKhauHash != Hash(matKhau))
                {
                    u.SoLanSai++;
                    if (u.SoLanSai >= 3) { u.Khoa = true; loi = "Tài khoản đã bị khóa do nhập sai 3 lần."; }
                    else loi = "Sai tên đăng nhập hoặc mật khẩu. Còn " + (3 - u.SoLanSai) + " lần thử.";
                    Save(ds);
                    return null;
                }
                if (u.SoLanSai != 0) { u.SoLanSai = 0; Save(ds); }
                return u;
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "AuthService.Check");
                loi = "Không đọc được dữ liệu tài khoản.";
                return null;
            }
        }
    }
}