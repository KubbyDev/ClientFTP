using FluentFTP;
using System;
using System.Linq;
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

        public static void Close()
        {
            client.Disconnect();
        }

        public static void DisplayFiles()
        {
            // get a list of files and directories
            foreach (FtpListItem item in client.GetListing(""))
                Console.WriteLine(item);
        }

        private static string GetName(string file)
        {
            string[] path = file.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            return path[path.Length - 1];
        }

        //TODO: Rendre ces fonctions plus robustes

        /// <summary> filePath est le chemin d'acces du fichier local, 
        /// remoteDestination est la destination du fichier sur le serveur </summary>
        /// <param name="filePath"></param>
        /// <param name="remoteDestination"></param>
        public static void UploadFile(string filePath, string remoteDestination = "/")
        {
            //Ajoute un separateur si besoin
            if (remoteDestination[remoteDestination.Length - 1] != '/') remoteDestination += '/';

            //Ajoute le nom du fichier
            string fileName = GetName(filePath);
            remoteDestination += fileName;

            Console.WriteLine("Uploading " + fileName + " ...");

            client.UploadFile(filePath, remoteDestination);
        }

        /// <summary> filePath est le chemin d'acces du fichier sur le serveur, 
        /// localDestination est la destination du fichier en local </summary>
        /// <param name="filePath"></param>
        /// <param name="localDestination"></param>
        public static void DownloadFile(string filePath, string localDestination)
        {
            //Ajoute un separateur si besoin
            if (localDestination[localDestination.Length - 1] != '/') localDestination += '/';
            if (filePath[0] != '/') filePath = '/' + filePath;

            //Ajoute le nom du fichier
            string fileName = GetName(filePath);
            localDestination += fileName;

            Console.WriteLine("Downloading " + fileName + " ...");

            client.DownloadFile(localDestination, filePath);
        }

        /// <summary>
        /// Bouge un fichier. file est le fichier a bouger, newPath est le dossier de destination. Attention le dossier de destination doit exister
        /// </summary>
        /// <param name="file"></param>
        /// <param name="newPath"></param>
        public static void Move(string file, string newPath)
        {
            //Ajoute un separateur si besoin
            if (file[0] != '/') file = '/' + file;
            if (newPath[0] != '/') newPath = '/' + newPath;

            client.MoveFile(file, newPath + "/" + GetName(file));
        }

        /// <summary>
        /// Renomme un fichier. path est le fichier a renommer, newName est son nouveau nom
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newName"></param>
        public static void Rename(string path, string newName)
        {
            //Ajoute un separateur si besoin
            if (path[0] != '/') path = '/' + path;

            string dest = path.Substring(0, path.LastIndexOf('/') + 1) + newName;

            client.Rename(path, dest);
        }

        /// <summary>
        /// Supprime un fichier
        /// </summary>
        /// <param name="path"></param>
        public static void Delete(string path)
        {
            //Ajoute un separateur si besoin
            if (path[0] != '/') path = '/' + path;

            client.DeleteFile(path);
        }

        /// <summary>
        /// Renvoie une liste des fichiers/dossiers presents dans le dossier specifie
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FtpClientFile[] GetAllFiles(string path = "/")
        {
            //Ajoute un separateur si besoin
            if (path[0] != '/') path = '/' + path;

            return client.GetListing(path).Select(file => new FtpClientFile(file.Name, file.Type == FtpFileSystemObjectType.Directory, file.FullName)).ToArray<FtpClientFile>();
        }
    }

    class FtpClientFile {

        public readonly string name;
        public readonly bool isDirectory;
        public readonly string path;
        
        public FtpClientFile(string name, bool isDir, string path)
        {
            this.name = name;
            isDirectory = isDir;
            this.path = path;
        }
    }
}
