namespace ClientFTP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.hostLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.connectionOptionsPanel = new System.Windows.Forms.Panel();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.fileGrid = new System.Windows.Forms.DataGridView();
            this.elementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renameButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.actionPanel = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createDirectoryButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.fileBrowserBox = new System.Windows.Forms.GroupBox();
            this.connectionOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.fileBrowserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hostLabel.Location = new System.Drawing.Point(3, 12);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(32, 13);
            this.hostLabel.TabIndex = 0;
            this.hostLabel.Text = "Host:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(171, 9);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(39, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "21";
            this.portTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.portLabel.Location = new System.Drawing.Point(136, 12);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(143, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordLabel.Location = new System.Drawing.Point(3, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(67, 35);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(143, 20);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameValue_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel.Location = new System.Drawing.Point(3, 38);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(135, 97);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(41, 7);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(89, 20);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.Text = "127.0.0.1";
            this.hostTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // connectionOptionsPanel
            // 
            this.connectionOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionOptionsPanel.Controls.Add(this.disconnectButton);
            this.connectionOptionsPanel.Controls.Add(this.connectButton);
            this.connectionOptionsPanel.Controls.Add(this.passwordTextBox);
            this.connectionOptionsPanel.Controls.Add(this.hostLabel);
            this.connectionOptionsPanel.Controls.Add(this.passwordLabel);
            this.connectionOptionsPanel.Controls.Add(this.portLabel);
            this.connectionOptionsPanel.Controls.Add(this.portTextBox);
            this.connectionOptionsPanel.Controls.Add(this.usernameLabel);
            this.connectionOptionsPanel.Controls.Add(this.hostTextBox);
            this.connectionOptionsPanel.Controls.Add(this.usernameTextBox);
            this.connectionOptionsPanel.Location = new System.Drawing.Point(12, 12);
            this.connectionOptionsPanel.Name = "connectionOptionsPanel";
            this.connectionOptionsPanel.Size = new System.Drawing.Size(226, 132);
            this.connectionOptionsPanel.TabIndex = 9;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(6, 97);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(22, 26);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 10;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(22, 55);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 10;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // fileGrid
            // 
            this.fileGrid.AllowUserToAddRows = false;
            this.fileGrid.AllowUserToDeleteRows = false;
            this.fileGrid.AllowUserToResizeRows = false;
            this.fileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elementType,
            this.elementName});
            this.fileGrid.Location = new System.Drawing.Point(249, 22);
            this.fileGrid.MultiSelect = false;
            this.fileGrid.Name = "fileGrid";
            this.fileGrid.ReadOnly = true;
            this.fileGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.fileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileGrid.Size = new System.Drawing.Size(465, 263);
            this.fileGrid.TabIndex = 0;
            this.fileGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileGrid_CellClick);
            this.fileGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.fileGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileGrid_CellDoubleClick);
            // 
            // elementType
            // 
            this.elementType.HeaderText = "Type";
            this.elementType.Name = "elementType";
            this.elementType.ReadOnly = true;
            this.elementType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.elementType.Width = 75;
            // 
            // elementName
            // 
            this.elementName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.elementName.HeaderText = "Name";
            this.elementName.Name = "elementName";
            this.elementName.ReadOnly = true;
            this.elementName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(22, 84);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 12;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(22, 113);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.consoleTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 143);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.AcceptsReturn = true;
            this.consoleTextBox.Location = new System.Drawing.Point(6, 19);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(696, 118);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.refreshButton);
            this.actionPanel.Controls.Add(this.button1);
            this.actionPanel.Controls.Add(this.createDirectoryButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.renameButton);
            this.actionPanel.Controls.Add(this.downloadButton);
            this.actionPanel.Controls.Add(this.uploadButton);
            this.actionPanel.Location = new System.Drawing.Point(12, 155);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(225, 157);
            this.actionPanel.TabIndex = 15;
            this.actionPanel.TabStop = false;
            this.actionPanel.Text = "Actions";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(105, 84);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remove Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_4);
            // 
            // createDirectoryButton
            // 
            this.createDirectoryButton.Location = new System.Drawing.Point(105, 26);
            this.createDirectoryButton.Name = "createDirectoryButton";
            this.createDirectoryButton.Size = new System.Drawing.Size(106, 23);
            this.createDirectoryButton.TabIndex = 14;
            this.createDirectoryButton.Text = "Create Directory";
            this.createDirectoryButton.UseVisualStyleBackColor = true;
            this.createDirectoryButton.Click += new System.EventHandler(this.Button1_Click_3);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(6, 287);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 16;
            this.pathLabel.Text = "Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(41, 284);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(430, 20);
            this.pathTextBox.TabIndex = 17;
            // 
            // fileBrowserBox
            // 
            this.fileBrowserBox.Controls.Add(this.pathLabel);
            this.fileBrowserBox.Controls.Add(this.pathTextBox);
            this.fileBrowserBox.Location = new System.Drawing.Point(243, 7);
            this.fileBrowserBox.Name = "fileBrowserBox";
            this.fileBrowserBox.Size = new System.Drawing.Size(476, 312);
            this.fileBrowserBox.TabIndex = 18;
            this.fileBrowserBox.TabStop = false;
            this.fileBrowserBox.Text = "File Browser";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(731, 474);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileGrid);
            this.Controls.Add(this.connectionOptionsPanel);
            this.Controls.Add(this.fileBrowserBox);
            this.Name = "Form1";
            this.Text = "Client FTP";
            this.connectionOptionsPanel.ResumeLayout(false);
            this.connectionOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.fileBrowserBox.ResumeLayout(false);
            this.fileBrowserBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel connectionOptionsPanel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox actionPanel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Button createDirectoryButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox consoleTextBox;
        public System.Windows.Forms.DataGridView fileGrid;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementName;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.GroupBox fileBrowserBox;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}

