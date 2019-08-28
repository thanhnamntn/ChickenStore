using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// On Github: https://github.com/dongockhanh3103/ChickStore.git
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Khac.frmSplash());
        }
    }
}
