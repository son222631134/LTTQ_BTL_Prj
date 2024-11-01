using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Prj.Class
{
    //vo dung vcl
    //a de'o vo dung dau :)))
    internal class Prepare
    {
        private string ProjectName = Assembly.GetExecutingAssembly().GetName().Name; //get project name
        private string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;  //get current directory
        private string ProjectDirectory;
        private string MediaDirectoryInProject =    "\\Database\\Media\\";
        private string DatabaseDirectoryInProject = "\\Database\\Database_BTL.mdf";
        private string IconFilename = "32x32-LogoUTC.ico";

        public Prepare()
        {
            getProjectDirectory();
        }
        public string getProjectDirectory()
        {
            ProjectDirectory = CurrentDirectory.Substring(0, CurrentDirectory.IndexOf(ProjectName)) + ProjectName;
            return ProjectDirectory;
        }
        public string getDatabaseDirectory()
        {
            return ProjectDirectory + DatabaseDirectoryInProject;
        }
        public string getMediaDirectoryInProject() { return MediaDirectoryInProject;}
        public void setFormProperties(Form  frm)
        {
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                frm.Icon = new Icon(ProjectDirectory + MediaDirectoryInProject + "Logo\\" + IconFilename);

            }
            catch (Exception ex)
            {
                
            }
        }

        public void setDgvProperties(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Font = new System.Drawing.Font("Times New Roman", 12F);

        }
    }
}
