using System.IO;
using System.Linq;

namespace ClientFTP
{
    class FileManager
    {
        /// <summary>
        /// Renvoie tous les fichiers et dossiers dans le dossier specifie
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static FtpClientFile[] GetFilesInFolder(FtpClientFile folder)
        {
            if (!folder.isDirectory)
                return new FtpClientFile[] { };

            return Directory.GetDirectories(folder.path).Select(path => new FtpClientFile(path, true))  //Recupere tous les dossiers dans le dossier
                .Concat(Directory.GetFiles(folder.path).Select(path => new FtpClientFile(path, false))) //Recupere tous les fichiers dans le dossier
                .ToArray();
        }
    }
}
