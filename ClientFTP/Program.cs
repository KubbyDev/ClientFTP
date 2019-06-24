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
            while (DateTime.Now.Second - time < 1) ;

            Connection.UploadFile("F:/Images/Bordel/atome.jpg");
            Connection.DisplayFiles();

            Connection.DownloadFile("atome.jpg", "F:/Images/");

            time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 20);

            Connection.Close();
        }
    }
}