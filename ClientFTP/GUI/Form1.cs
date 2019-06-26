using System;
using System.Windows.Forms;

namespace ClientFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetUsername() => usernameTextBox.Text;
        public string GetPassword() => passwordTextBox.Text;
        public void SetPassword(string s) => passwordTextBox.Text = s;
        public string GetHost() => hostTextBox.Text;
        public int GetPort() => int.Parse(portTextBox.Text);
        public void SetPathTextBox(string s) => pathTextBox.Text = s;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            GUI.Connect();
            GUI.RefreshFileList();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            GUI.Disconnect();
            GUI.ClearFileGrid();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            GUI.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (GUI.selection == null)
            {
                GUI.WriteLineToConsole("You must select a file !");
                return;
            }

            Connection.Delete(GUI.selection);
            GUI.RefreshFileList();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GUI.RefreshFileList();
        }

        //Event : Touche Enter dans le champ "password"
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GUI.Connect();
            }
        }

        private void FileGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fileGrid.SelectedRows.Count != 0)
            {
                if (GUI.selection.isDirectory)
                    GUI.MoveToDirectory(GUI.selection);
                else
                    GUI.Download();
            }
        }

        private void FileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fileGrid.SelectedRows.Count != 0)
            {
                string cellValue = fileGrid.SelectedRows[0].Cells[1].Value.ToString();
                if (cellValue != "../")
                    GUI.ChangeSelection(GUI.GetFileByName(cellValue));
                else
                    GUI.ChangeSelection(GUI.parentDirectory);
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (GUI.selection == null)
            {
                GUI.WriteLineToConsole("You must select a file !");
                return;
            }

            string newName = PromptDialog.Show("Select a new name", "New name:");
            if(newName != "")
                Connection.Rename(GUI.selection, newName);

            GUI.RefreshFileList();
        }

        private void CreateDirectoryButton_Click(object sender, EventArgs e)
        {
            string name = PromptDialog.Show("Select a name", "Directory name:");
            if (name != "")
                GUI.CreateDirectory(name);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            GUI.Download();
        }
    }
}
