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
            FtpClient client = new FtpClient("192.168.1.16");
            client.Port = 21;

            // if you don't specify login credentials, we use the "anonymous" user account
            client.Credentials = new NetworkCredential("User", "1234");

            // begin connecting to the server
            client.Connect();

            // get a list of files and directories
            foreach (FtpListItem item in client.GetListing(""))
            {
                Console.WriteLine(item);

                // if this is a file
                if (item.Type == FtpFileSystemObjectType.File)
                {
                    // get the file size
                    long size = client.GetFileSize(item.FullName);
                }

                // get modified date/time of the file or folder
                DateTime time = client.GetModifiedTime(item.FullName);

                // calculate a hash for the file on the server side (default algorithm)
                //FtpHash hash = client.GetHash(item.FullName);

            }

            while (true) ;

            // upload a file
            //client.UploadFile(@"C:\MyVideo.mp4", "/htdocs/MyVideo.mp4");

            // rename the uploaded file
            //client.Rename("/htdocs/MyVideo.mp4", "/htdocs/MyVideo_2.mp4");

            // download the file again
            //client.DownloadFile(@"C:\MyVideo_2.mp4", "/htdocs/MyVideo_2.mp4");

            // delete the file
            //client.DeleteFile("/htdocs/MyVideo_2.mp4");

            // delete a folder recursively
            //client.DeleteDirectory("/htdocs/extras/");

            // check if a file exists
            //if (client.FileExists("/htdocs/big2.txt")) { }

            // check if a folder exists
            //if (client.DirectoryExists("/htdocs/extras/")) { }

            // upload a file and retry 3 times before giving up
            //client.RetryAttempts = 3;
            //client.UploadFile(@"C:\MyVideo.mp4", "/htdocs/big.txt", FtpExists.Overwrite, false, FtpVerify.Retry);

            // disconnect! good bye!
            //client.Disconnect();

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
        }
    }
}
