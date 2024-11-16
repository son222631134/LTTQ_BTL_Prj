using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Prj.Class
{
    internal class Function
    {
        public static void CopyFile(string src, string des)
        {
            if (src == des) return;
            string path = des.Substring(0, des.LastIndexOf("\\"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                File.Copy(src, des, true);
            } catch (Exception ex) {
                if (ex is IOException)
                {
                    File.Delete(des);
                    File.Copy(src, des, true);
                }
            }
        }

    }
}
