namespace ClientFTP
{
    partial class ConnectionOptionLabel
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
            this.HostLabel = new System.Windows.Forms.Label();
            this.PortValue = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameValue = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.HostValue = new System.Windows.Forms.TextBox();
            this.ConnectionOptionsPanel = new System.Windows.Forms.Panel();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectionOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HostLabel.Location = new System.Drawing.Point(3, 12);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(32, 13);
            this.HostLabel.TabIndex = 0;
            this.HostLabel.Text = "Host:";
            // 
            // PortValue
            // 
            this.PortValue.Location = new System.Drawing.Point(171, 9);
            this.PortValue.Name = "PortValue";
            this.PortValue.Size = new System.Drawing.Size(39, 20);
            this.PortValue.TabIndex = 3;
            this.PortValue.Text = "21";
            this.PortValue.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PortLabel.Location = new System.Drawing.Point(136, 12);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(29, 13);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port:";
            // 
            // PasswordValue
            // 
            this.PasswordValue.Location = new System.Drawing.Point(67, 61);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Size = new System.Drawing.Size(143, 20);
            this.PasswordValue.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // UsernameValue
            // 
            this.UsernameValue.Location = new System.Drawing.Point(67, 35);
            this.UsernameValue.Name = "UsernameValue";
            this.UsernameValue.Size = new System.Drawing.Size(143, 20);
            this.UsernameValue.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 38);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(135, 97);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HostValue
            // 
            this.HostValue.Location = new System.Drawing.Point(41, 7);
            this.HostValue.Name = "HostValue";
            this.HostValue.Size = new System.Drawing.Size(89, 20);
            this.HostValue.TabIndex = 1;
            this.HostValue.Text = "127.0.0.1";
            this.HostValue.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ConnectionOptionsPanel
            // 
            this.ConnectionOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionOptionsPanel.Controls.Add(this.DisconnectButton);
            this.ConnectionOptionsPanel.Controls.Add(this.ConnectButton);
            this.ConnectionOptionsPanel.Controls.Add(this.PasswordValue);
            this.ConnectionOptionsPanel.Controls.Add(this.HostLabel);
            this.ConnectionOptionsPanel.Controls.Add(this.label1);
            this.ConnectionOptionsPanel.Controls.Add(this.PortLabel);
            this.ConnectionOptionsPanel.Controls.Add(this.PortValue);
            this.ConnectionOptionsPanel.Controls.Add(this.UsernameLabel);
            this.ConnectionOptionsPanel.Controls.Add(this.HostValue);
            this.ConnectionOptionsPanel.Controls.Add(this.UsernameValue);
            this.ConnectionOptionsPanel.Location = new System.Drawing.Point(12, 12);
            this.ConnectionOptionsPanel.Name = "ConnectionOptionsPanel";
            this.ConnectionOptionsPanel.Size = new System.Drawing.Size(226, 132);
            this.ConnectionOptionsPanel.TabIndex = 9;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(6, 97);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(22, 26);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 10;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(22, 55);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 10;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(244, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 20;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DownloadButton);
            this.groupBox2.Controls.Add(this.UploadButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 157);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // ConnectionOptionLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConnectionOptionsPanel);
            this.Name = "ConnectionOptionLabel";
            this.Text = "Client FTP";
            this.ConnectionOptionsPanel.ResumeLayout(false);
            this.ConnectionOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.TextBox PortValue;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PasswordValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameValue;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox HostValue;
        private System.Windows.Forms.Panel ConnectionOptionsPanel;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

