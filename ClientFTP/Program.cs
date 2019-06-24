using System;

namespace ClientFTP
{
    static class Program
    {
        static void Main()
        {
            GUI.Init();
            Connection.Open();
            Connection.DisplayFiles();

            long time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 5);

            // disconnect! good bye!
            Connection.Close();
        }
    }
}