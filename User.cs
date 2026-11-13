using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsFormsApp2
{
    public class User
    {
        public string TenDN { get; set; }
        public string MatKhauHash { get; set; }
        public string VaiTro { get; set; }   // Admin hoặc LeTan
        public int SoLanSai { get; set; }
        public bool Khoa { get; set; }
    }
}
