using System;

namespace ClientFTP
{
    class FtpClientFile
    {
        public readonly string path;
        public readonly bool isDirectory;

        /// <summary>
        /// Le nom du fichier (sans le chemin d'acces)
        /// </summary>
        public string name
        {
            get
            {
                if (_name == null)
                    _name = this.GetName();
                return _name;
            }
            private set { _name = value; }
        }
        private string _name = null;

        public FtpClientFile(string path, bool isDirectory = false)
        {
            this.isDirectory = isDirectory;
            this.path = path;

            //Ajoute un separateur si besoin
            if (this.isDirectory && this.path[this.path.Length - 1] != '/')
                this.path += '/';

            //Supprime le dernier / si besoin
            if ( ! this.isDirectory && this.path[this.path.Length - 1] == '/')
                this.path = this.path.Substring(0, this.path.Length - 1);
        }

        public string GetName() => GetName(this.path);
        public static string GetName(string path)
        {
            string[] folders = path.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

            if (folders.Length == 0)
                return "";

            return folders[folders.Length - 1];
        }

        //Le dossier home du serveur
        public static FtpClientFile serverHomeFolder = new FtpClientFile("/", true);
    }
}
