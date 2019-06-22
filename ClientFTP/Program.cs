using FluentFTP;
using System;
using System.Net;

namespace ClientFTP
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create an FTP client
            FtpClient client = new FtpClient("123.123.123.123");

            // if you don't specify login credentials, we use the "anonymous" user account
            client.Credentials = new NetworkCredential("david", "pass123");

            // begin connecting to the server
            client.Connect();

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
        }
    }
}
