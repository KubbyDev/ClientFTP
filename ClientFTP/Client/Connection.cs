using FluentFTP;
using System;
using System.Linq;
using System.Net;

namespace ClientFTP
{
    class Connection
    {
        public static FtpClient client = null;

        public static bool isConnectionActive()
        {
            return (client!=null);
        }

        public static void Open(string hostIP, int port, NetworkCredential credentials)
        {
            // create an FTP client
            // if you don't specify login credentials, we use the "anonymous" user account
            client = new FtpClient(hostIP,port,credentials);

            // begin connecting to the server
            client.Connect();
        }

        public static void Close()
        {
            client.Disconnect();
            client = null;
        }

        /// <summary> fileToUpload est le fichier local, 
        /// destinationFolder est le dossier destination sur le serveur </summary>
        /// <param name="fileToUpload"></param>
        /// <param name="destinationFolder"></param>
        public static void UploadFile(FtpClientFile fileToUpload, FtpClientFile destinationFolder = null)
        {
            //Si le dossier de destination n'est pas specifie on prend le dossier home
            if (destinationFolder == null)
                destinationFolder = FtpClientFile.serverHomeFolder;

            //Si le dossier de destination n'est pas un dossier on devient tout rouge
            if( ! destinationFolder.isDirectory)
            {
                Console.Error.WriteLine("The destination must be a folder !");
                return;
            }

            //Si le dossier de destination n'existe pas on le cree
            client.CreateDirectory(destinationFolder.path);

            //Si le fichier de depart est un dossier on upload tous les fichiers dedans
            if (fileToUpload.isDirectory)
            {
                foreach (FtpClientFile file in FileManager.GetFilesInFolder(fileToUpload))
                    UploadFile(file, new FtpClientFile(destinationFolder.path + fileToUpload.name, true));

                return;
            }

            //Check si le fichier existe deja
            string filePath = destinationFolder.path + fileToUpload.name;
            if(client.FileExists(filePath))
            {
                string GetNewPath(int i)
                {
                    int dotIndex = fileToUpload.name.LastIndexOf('.');
                    return destinationFolder.path + fileToUpload.name.Substring(0, dotIndex) + " (" + i + ")" + fileToUpload.name.Substring(dotIndex);
                }

                int index = 1;
                filePath = GetNewPath(index);

                while (client.FileExists(filePath))
                {
                    index++;
                    filePath = GetNewPath(index);
                }
            }

            //Upload le fichier
            Console.WriteLine("Uploading " + fileToUpload.name + " ...");
            client.UploadFile(fileToUpload.path, filePath);
        }

        /// <summary> fileToDownload est le fichier sur le serveur, 
        /// destinationFolder est le dossier de destination en local </summary>
        /// <param name="fileToDownload"></param>
        /// <param name="destinationFolder"></param>
        public static void DownloadFile(FtpClientFile fileToDownload, FtpClientFile destinationFolder)
        {
            //Si le dossier de destination n'est pas un dossier on devient tout rouge
            if (!destinationFolder.isDirectory)
            {
                Console.Error.WriteLine("The destination must be a folder !");
                return;
            }

            //Si le dossier de destination n'existe pas on le cree
            FileManager.CreateDirectory(destinationFolder.path);

            //Si le fichier de depart est un dossier on download tous les fichiers dedans
            if (fileToDownload.isDirectory)
            {
                foreach (FtpClientFile file in GetAllFiles(fileToDownload.path))
                    DownloadFile(file, new FtpClientFile(destinationFolder.path + fileToDownload.name, true));

                return;
            }

            //Check si le fichier existe deja
            string filePath = destinationFolder.path + fileToDownload.name;
            if (FileManager.FileExists(filePath))
            {
                string GetNewPath(int i)
                {
                    int dotIndex = fileToDownload.name.LastIndexOf('.');
                    return destinationFolder.path + fileToDownload.name.Substring(0, dotIndex) + " (" + i + ")" + fileToDownload.name.Substring(dotIndex);
                }

                int index = 1;
                filePath = GetNewPath(index);

                while (FileManager.FileExists(filePath))
                {
                    index++;
                    filePath = GetNewPath(index);
                }
            }

            //Download le fichier
            Console.WriteLine("Downloading " + fileToDownload.name + " ...");
            client.DownloadFile(filePath, fileToDownload.path);
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

            client.MoveFile(file, newPath + "/" + FtpClientFile.GetName(file));
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

            return client.GetListing(path).Select(file => new FtpClientFile(file.FullName, file.Type == FtpFileSystemObjectType.Directory)).ToArray<FtpClientFile>();
        }
    }
}
