using System;
using System.Windows.Forms;

namespace S.H.I.E.L.D_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int port = 1234;
            string serverIP = "127.0.0.1";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(serverIP, port));
        }
    }
}
