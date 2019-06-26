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

        public string GetUsername()
        {
            return usernameTextBox.Text;
        }
        public string GetPassword()
        {
            return passwordTextBox.Text;
        }
        public void SetPassword(string s)
        {
            passwordTextBox.Text = s;
        }
        public string GetHost()
        {
            return hostTextBox.Text;
        }
        public int GetPort()
        {
            return int.Parse(portTextBox.Text);
        }

        public void SetPathTextBox(string s)
        {
            pathTextBox.Text = s;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GUI.Connect();
            GUI.RefreshFileList();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void UsernameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            GUI.Disconnect();
            GUI.ClearFileGrid();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void Button1_Click_4(object sender, EventArgs e)
        {

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
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
                    GUI.WriteLineToConsole(GUI.selection.name + " is a file.");
            }
        }

        private void FileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fileGrid.SelectedRows.Count != 0)
            {
                string cellValue = fileGrid.SelectedRows[0].Cells[1].Value.ToString();
                FtpClientFile selection;
                if (cellValue != "../")
                    selection = GUI.GetFileByName(cellValue);
                else
                {
                    selection = GUI.parentDirectory;
                }

                GUI.ChangeSelection(selection);
            }
        }
    }
}
