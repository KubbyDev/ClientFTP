using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFTP
{
    class GUI
    {
        private static Form1 form;
        public static void Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }

        public static void Close()
        {
            Disconnect();
        }

        private static void WriteLineToConsole(string s)
        {
            form.GetConsoleTextBox().AppendText(s+"\n");
        }

        private static void WriteToConsole(string s)
        {
            form.GetConsoleTextBox().AppendText(s);
        }

        public static void Disconnect()
        {
            if (!Connection.IsConnectionActive())
                return;
            try
            {
                Connection.Close();
                WriteLineToConsole("Disconnect from the server.");
            }
            catch (Exception)
            {
                WriteLineToConsole("Could not disconnect from the server.");
            }
        }

        public static void Connect()
        {
            if (Connection.IsConnectionActive()) {
                Disconnect();
                if (Connection.IsConnectionActive()) return;
            }
            try
            {
                NetworkCredential credentials = new NetworkCredential(form.GetUsername(), form.GetPassword());
                Connection.Open(form.GetHost(), form.GetPort(), credentials);
                WriteLineToConsole("Connected to the server.");
            }
            catch (Exception)
            {
                form.SetPassword("");
                WriteLineToConsole("Could not connect to the server.");
            }
        }
    }
}
