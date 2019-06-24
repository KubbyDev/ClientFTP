using System;

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
            GUI.Init();
            Connection.Start();
            Connection.DisplayFiles();

            long time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 5);

            // disconnect! good bye!
            //client.Disconnect();
        }
    }
}
