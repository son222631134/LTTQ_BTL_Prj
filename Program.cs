using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Prj
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
            //    Application.Run(new Frm.Main.frmMain());
            //}
            //catch (Exception ex) { }

            Application.Run(new Frm.Main.frmMain());
            //Application.Run(new Form_Login());
        }
    }
}
