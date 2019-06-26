using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace ClientFTP
{
    class GUI
    {
        private static Form1 form;
        public static FtpClientFile selection;
        public static FtpClientFile parentDirectory;
        private static FtpClientFile currentDirectory;
        private static List<FtpClientFile> clientFiles;

        public static void Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            selection = null;
            parentDirectory = null;
            currentDirectory = null;
            clientFiles = new List<FtpClientFile>();
            form.SetPathTextBox("");
            Application.Run(form);
        }

        public static void Close()
        {
            Disconnect();
        }

        public static FtpClientFile GetSelection()
        {
            return selection;
        }

        //Ajoute du texte dans la console avec un saut de ligne
        public static void WriteLineToConsole(string s)
        {
            form.consoleTextBox.AppendText(s);
            form.consoleTextBox.AppendText(Environment.NewLine);
            form.consoleTextBox.AppendText(Environment.NewLine);
        }

        //Ajoute du texte dans la console sans retour à la ligne
        public static void WriteToConsole(string s)
        {
            form.consoleTextBox.AppendText(s);
        }

        public static void Disconnect()
        {
            if (!Connection.IsConnectionActive())
                return;
            try
            {
                Connection.Close();
                WriteLineToConsole("Disconnected from the server.");
            }
            catch (Exception)
            {
                WriteLineToConsole("Could not disconnect from the server.");
            }
            selection = null;
            currentDirectory = null;
            clientFiles = null;
            form.SetPathTextBox("");
        }

        public static void Connect()
        {
            if (Connection.IsConnectionActive())
            {
                Disconnect();
                if (Connection.IsConnectionActive()) return;
            }
            try
            {
                NetworkCredential credentials = new NetworkCredential(form.GetUsername(), form.GetPassword());
                Connection.Open(form.GetHost(), form.GetPort(), credentials);

                WriteLineToConsole("Connected to the server.");
            }
            catch (Exception)
            {
                form.SetPassword("");
                WriteLineToConsole("Could not connect to the server.");
                Connection.client = null;
                return;
            }
            MoveToDirectory(FtpClientFile.serverHomeFolder);
        }

        public static void RefreshFileList()
        {
            ClearFileGrid();
            DisplayFiles();
        }
        public static void ClearFileGrid()
        {
            form.fileGrid.Rows.Clear();
        }
        private static void ShowFile(FtpClientFile file)
        {
            string fileType = (file.isDirectory)? "directory" : "file";
            if(file!=parentDirectory)
                form.fileGrid.Rows.Add(fileType,file.name);
            else
                form.fileGrid.Rows.Add(fileType, "../");
        }
        public static void DisplayFiles()
        {
            try
            {
                clientFiles = Connection.GetAllFiles(currentDirectory);
                if (parentDirectory != null) clientFiles.Insert(0, parentDirectory);
                foreach (FtpClientFile file in clientFiles)
                {
                    ShowFile(file);
                }
            }
            catch (Exception)
            {
                clientFiles = null;
                WriteLineToConsole("Could not display files from the server.");
            }
            //form.fileGrid.CurrentCell.Selected = false;
        }

        public static FtpClientFile GetFileByName(string n)
        {
            if (n == "") return parentDirectory;
            foreach (FtpClientFile f in clientFiles)
                if (f.name == n)
                    return f;
            return null;
        }

        public static void ChangeSelection(FtpClientFile newSelection)
        {
            selection = newSelection;
            if(selection!=null)
                form.SetPathTextBox(selection.path);
            else
                form.SetPathTextBox(currentDirectory.path);
        }

        public static FtpClientFile GetParentDirectory()
        {
            if (currentDirectory == FtpClientFile.serverHomeFolder)
            {
                WriteLineToConsole("Repertoire parent, le parent est maintenant égal à null");
                return null;
            }

            string parentPath = currentDirectory.path.Remove(currentDirectory.path.Length - 1);
            parentPath = parentPath.Substring(0,parentPath.LastIndexOf('/')+1);
            
            if(parentPath != "/")
                return new FtpClientFile(parentPath, true);
            return FtpClientFile.serverHomeFolder;
        }

        public static void MoveToDirectory(FtpClientFile newDirectory)
        {
            currentDirectory = newDirectory;
            parentDirectory = GetParentDirectory();
            
            selection = null;    
            GUI.RefreshFileList();
            form.SetPathTextBox(newDirectory.path);
        }
    }
}
