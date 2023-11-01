using Quanlikho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlikho.Utils;
using Quanlikho.Views;

namespace Quanlikho
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.dbName = "quanlikho";
            DatabaseHelper.serverName = "(local)";
            DatabaseHelper.userDb = "nth2982";
            DatabaseHelper.password = "123456";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
