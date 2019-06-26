using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ClientFTP
{
    class Connection
    {
        public static FtpClient client = null;

        public static bool IsConnectionActive()
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
                foreach (FtpClientFile file in GetAllFiles(fileToDownload))
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
        /// Bouge un fichier. file est le fichier a bouger, newFolder est le dossier de destination
        /// </summary>
        /// <param name="file"></param>
        /// <param name="newFolder"></param>
        public static void Move(FtpClientFile file, FtpClientFile newFolder)
        {
            //Si le dossier de destination n'est pas un dossier on devient tout rouge
            if (!newFolder.isDirectory)
            {
                Console.Error.WriteLine("The new folder must be a folder !");
                return;
            }

            //Si le dossier de destination n'existe pas on le cree
            client.CreateDirectory(newFolder.path);

            client.MoveFile(file.path, newFolder.path + file.GetName());
        }

        /// <summary>
        /// Renomme un fichier. file est le fichier a renommer, newName est son nouveau nom
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newName"></param>
        public static void Rename(FtpClientFile file, string newName)
        {
            string newPath = file.path.Substring(0, file.path.LastIndexOf('/') + 1) + newName;
            client.Rename(file.path, newPath);
        }

        /// <summary>
        /// Supprime un fichier
        /// </summary>
        /// <param name="file"></param>
        public static void Delete(FtpClientFile file)
        {
            client.DeleteFile(file.path);
        }

        /// <summary>
        /// Renvoie une liste des fichiers/dossiers presents dans le dossier specifie
        /// </summary>
        /// <param name="inFolder"></param>
        /// <returns></returns>
        public static List<FtpClientFile> GetAllFiles(FtpClientFile inFolder)
        {
            if (!inFolder.isDirectory)
                return new List<FtpClientFile>();

            return client.GetListing(inFolder.path).Select(file => new FtpClientFile(file.FullName, file.Type == FtpFileSystemObjectType.Directory)).ToList<FtpClientFile>();
        }
    }
}
