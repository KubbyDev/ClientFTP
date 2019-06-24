using FluentFTP;
using System;
using System.Net;

namespace ClientFTP
{
    class Connection
    {
        public static FtpClient client;

        public static void Start()
        {
            // create an FTP client
            client = new FtpClient("127.0.0.1");
            client.Port = 21;

            // if you don't specify login credentials, we use the "anonymous" user account
            client.Credentials = new NetworkCredential("admin", "admin1234");

            // begin connecting to the server
            client.Connect();
        }

        public static void DisplayFiles()
        {
            // get a list of files and directories
            foreach (FtpListItem item in client.GetListing(""))
                Console.WriteLine(item);
        }
    }
}
