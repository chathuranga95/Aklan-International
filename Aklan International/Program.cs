using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International
{
    static class Program//hello
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmSupervisorWindow());
            Application.Run(new frmWorkerWindow());
            //Application.Run(new frmAdminWindow("shehan","a001"));

        }
    }
}
