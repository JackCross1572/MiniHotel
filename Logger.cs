using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsFormsApp2
{
    public static class Logger
    {
        public static void Write(Exception ex, string ctx = "")
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
                File.AppendAllText(path, "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] "
                    + ctx + " " + ex.Message + Environment.NewLine);
            }
            catch { }
        }
    }
}