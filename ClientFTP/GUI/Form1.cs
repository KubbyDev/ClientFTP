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

        public System.Windows.Forms.TextBox GetConsoleTextBox()
        {
            return consoleTextBox;
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
            return Int32.Parse(portTextBox.Text);
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
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void Button1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
