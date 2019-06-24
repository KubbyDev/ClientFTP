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

            Connection.Move("atome.jpg", "a/");
            Connection.Rename("a/atome.jpg", "atomeeee.jpg");

            Connection.DisplayFiles();

            foreach(FtpClientFile file in Connection.GetAllFiles("a/")) Console.WriteLine(file.path);

            Connection.Delete("a/atomeeee.jpg");

            Connection.DisplayFiles();

            time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 20);

            Connection.Close();
        }
    }
}