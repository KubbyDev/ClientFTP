using FluentFTP;
using System;
using System.Net;

namespace ClientFTP
{
    class Connection
    {
        public static FtpClient client;

        public static void Open()
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

        public static void Close()
        {
            client.Disconnect();
        }

        /// <summary> filePath est le chemin d'acces du fichier local, 
        /// remoteDestination est la destination du fichier sur le serveur </summary>
        /// <param name="filePath"></param>
        /// <param name="remoteDestination"></param>
        public static void UploadFile(String filePath, String remoteDestination = "/")
        {
            //Ajoute un separateur si besoin
            if (remoteDestination[remoteDestination.Length - 1] != '/') remoteDestination += '/';

            //Ajoute le nom du fichier
            string[] path = filePath.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            remoteDestination += path[path.Length-1];

            Console.WriteLine("Uploading " + path[path.Length-1] + " ...");

            client.UploadFile(filePath, remoteDestination);
        }

        /// <summary> filePath est le chemin d'acces du fichier sur le serveur, 
        /// localDestination est la destination du fichier en local </summary>
        /// <param name="filePath"></param>
        /// <param name="localDestination"></param>
        public static void DownloadFile(String filePath, String localDestination)
        {
            //Ajoute un separateur si besoin
            if (localDestination[localDestination.Length - 1] != '/') localDestination += '/';
            if (filePath[0] != '/') filePath = '/' + filePath;

            //Ajoute le nom du fichier
            string[] path = filePath.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            localDestination += path[path.Length - 1];

            Console.WriteLine("Downloading " + filePath + " ...");

            client.DownloadFile(localDestination, filePath);
        }
    }
}
