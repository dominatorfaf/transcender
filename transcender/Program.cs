using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transcender.utils;

namespace Transcender
{
    static class Program
    {
        ///  The main entry point for the application.
        

        [STAThread]
        static void Main()
        {
            var database = Connector.makeDBConnection();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
