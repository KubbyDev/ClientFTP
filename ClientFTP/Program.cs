using System;

namespace ClientFTP
{
    static class Program
    {
        static void Main()
        {
            GUI.Init();
            /*
            Connection.Open("127.0.0.1", 21, new System.Net.NetworkCredential("admin", "admin1234"));
            Connection.DisplayFiles();

            long time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 1) ;

            Connection.UploadFile(new FtpClientFile("F:/Images/folder/i.png"));
            Connection.UploadFile(new FtpClientFile("F:/Images/folder", true));
            Connection.DisplayFiles();

            Connection.DownloadFile("atome.jpg", "F:/Images/");

            Connection.Move("atome.jpg", "a/");
            Connection.Rename("a/atome.jpg", "atomeeee.jpg");

            Connection.DisplayFiles();

            foreach(FtpClientFile file in Connection.GetAllFiles("a/")) Console.WriteLine(file.path);

            Connection.Delete("a/atomeeee.jpg");

            Connection.DisplayFiles();*/

            time = DateTime.Now.Second;
            while (DateTime.Now.Second - time < 60);

            Connection.Close();
        }
    }
}