using System;
using System.Collections.Generic;
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
            try
            {
                File.Copy(src, des,true);
            } catch (Exception ex)
            {

            }
        }

        internal static void Copy(string src, string dest)
        {
            throw new NotImplementedException();
        }
    }
}
