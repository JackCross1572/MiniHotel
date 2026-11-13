using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public static class FileHelper
    {
        public static string Duong(string ten)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ten);
        }

        public static List<T> Load<T>(string ten, int soCot, Func<string[], T> parse)
        {
            return LoadRange(ten, soCot, soCot, parse);
        }

        // Đọc tập tin: bỏ dòng trống, dòng sai số cột, dòng lỗi định dạng (ghi log)
        public static List<T> LoadRange<T>(string ten, int minCot, int maxCot, Func<string[], T> parse)
        {
            List<T> ds = new List<T>();
            try
            {
                string f = Duong(ten);
                if (!File.Exists(f))
                {
                    File.WriteAllText(f, "", Encoding.UTF8);   // tự tạo tập tin rỗng khi chưa có
                    return ds;
                }
                foreach (string dong in File.ReadAllLines(f, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(dong)) continue;
                    string[] p = dong.Split(';');
                    if (p.Length < minCot || p.Length > maxCot) continue;
                    try { ds.Add(parse(p)); }
                    catch (Exception ex) { Logger.Write(ex, ten + ": " + dong); }
                }
            }
            catch (Exception ex) { Logger.Write(ex, "Load " + ten); }
            return ds;
        }

        public static void Save<T>(string ten, IEnumerable<T> items, Func<T, string> toLine)
        {
            try
            {
                File.WriteAllLines(Duong(ten), items.Select(toLine).ToArray(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "Save " + ten);
                throw;
            }
        }
    }
}