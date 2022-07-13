namespace emutool
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AmiiboNameBox = new System.Windows.Forms.TextBox();
            this.AmiiboNameLabel = new System.Windows.Forms.Label();
            this.RandomizeUuidCheck = new System.Windows.Forms.CheckBox();
            this.RandomUuidLabel = new System.Windows.Forms.Label();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.CreateAllCheck = new System.Windows.Forms.CheckBox();
            this.UseNameCheck = new System.Windows.Forms.CheckBox();
            this.DirectoryNameBox = new System.Windows.Forms.TextBox();
            this.FtpPortLabel = new System.Windows.Forms.Label();
            this.FtpStartLabel = new System.Windows.Forms.Label();
            this.FtpPortBox = new System.Windows.Forms.TextBox();
            this.DirectoryNameLabel = new System.Windows.Forms.Label();
            this.SaveImageCheck = new System.Windows.Forms.CheckBox();
            this.FtpAddressBox = new System.Windows.Forms.TextBox();
            this.FtpAddressLabel = new System.Windows.Forms.Label();
            this.FtpSaveCheck = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RandomMiiLabel = new System.Windows.Forms.Label();
            this.GenerationBox = new System.Windows.Forms.GroupBox();
            this.LastPathCheck = new System.Windows.Forms.CheckBox();
            this.LastPathLabel = new System.Windows.Forms.Label();
            this.APIStatusStrip = new System.Windows.Forms.StatusStrip();
            this.APIStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AmiiboPictureBox = new System.Windows.Forms.PictureBox();
            this.SeriesComboBox = new System.Windows.Forms.ComboBox();
            this.AmiiboComboBox = new System.Windows.Forms.ComboBox();
            this.AmiiboSelectBox = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsBox.SuspendLayout();
            this.GenerationBox.SuspendLayout();
            this.APIStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmiiboPictureBox)).BeginInit();
            this.AmiiboSelectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmiiboNameBox
            // 
            this.AmiiboNameBox.Location = new System.Drawing.Point(124, 25);
            this.AmiiboNameBox.MaxLength = 40;
            this.AmiiboNameBox.Name = "AmiiboNameBox";
            this.AmiiboNameBox.Size = new System.Drawing.Size(255, 20);
            this.AmiiboNameBox.TabIndex = 1;
            // 
            // AmiiboNameLabel
            // 
            this.AmiiboNameLabel.AutoSize = true;
            this.AmiiboNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmiiboNameLabel.Location = new System.Drawing.Point(15, 28);
            this.AmiiboNameLabel.Name = "AmiiboNameLabel";
            this.AmiiboNameLabel.Size = new System.Drawing.Size(43, 13);
            this.AmiiboNameLabel.TabIndex = 2;
            this.AmiiboNameLabel.Text = "Name:";
            // 
            // RandomizeUuidCheck
            // 
            this.RandomizeUuidCheck.AutoSize = true;
            this.RandomizeUuidCheck.Location = new System.Drawing.Point(18, 202);
            this.RandomizeUuidCheck.Name = "RandomizeUuidCheck";
            this.RandomizeUuidCheck.Size = new System.Drawing.Size(168, 17);
            this.RandomizeUuidCheck.TabIndex = 4;
            this.RandomizeUuidCheck.Text = "Randomize UUID in emulation";
            this.RandomizeUuidCheck.UseVisualStyleBackColor = true;
            this.RandomizeUuidCheck.CheckedChanged += new System.EventHandler(this.RandomizeUuidCheck_CheckedChanged);
            // 
            // RandomUuidLabel
            // 
            this.RandomUuidLabel.AutoSize = true;
            this.RandomUuidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomUuidLabel.Location = new System.Drawing.Point(15, 125);
            this.RandomUuidLabel.Name = "RandomUuidLabel";
            this.RandomUuidLabel.Size = new System.Drawing.Size(361, 65);
            this.RandomUuidLabel.TabIndex = 5;
            this.RandomUuidLabel.Text = resources.GetString("RandomUuidLabel.Text");
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.UseNameCheck);
            this.SettingsBox.Controls.Add(this.DirectoryNameBox);
            this.SettingsBox.Controls.Add(this.FtpPortLabel);
            this.SettingsBox.Controls.Add(this.FtpStartLabel);
            this.SettingsBox.Controls.Add(this.FtpPortBox);
            this.SettingsBox.Controls.Add(this.DirectoryNameLabel);
            this.SettingsBox.Controls.Add(this.SaveImageCheck);
            this.SettingsBox.Controls.Add(this.AmiiboNameLabel);
            this.SettingsBox.Controls.Add(this.FtpAddressBox);
            this.SettingsBox.Controls.Add(this.RandomUuidLabel);
            this.SettingsBox.Controls.Add(this.FtpAddressLabel);
            this.SettingsBox.Controls.Add(this.AmiiboNameBox);
            this.SettingsBox.Controls.Add(this.FtpSaveCheck);
            this.SettingsBox.Controls.Add(this.RandomizeUuidCheck);
            this.SettingsBox.Location = new System.Drawing.Point(418, 12);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(396, 341);
            this.SettingsBox.TabIndex = 6;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "2 - Generation settings";
            // 
            // CreateAllCheck
            // 
            this.CreateAllCheck.AutoSize = true;
            this.CreateAllCheck.Location = new System.Drawing.Point(51, 514);
            this.CreateAllCheck.Name = "CreateAllCheck";
            this.CreateAllCheck.Size = new System.Drawing.Size(294, 17);
            this.CreateAllCheck.TabIndex = 11;
            this.CreateAllCheck.Text = "Generate all amiibos at once, instead of the selected one";
            this.CreateAllCheck.UseVisualStyleBackColor = true;
            this.CreateAllCheck.CheckedChanged += new System.EventHandler(this.CreateAllCheck_CheckedChanged);
            // 
            // UseNameCheck
            // 
            this.UseNameCheck.AutoSize = true;
            this.UseNameCheck.Checked = true;
            this.UseNameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseNameCheck.Location = new System.Drawing.Point(124, 77);
            this.UseNameCheck.Name = "UseNameCheck";
            this.UseNameCheck.Size = new System.Drawing.Size(160, 17);
            this.UseNameCheck.TabIndex = 10;
            this.UseNameCheck.Text = "Use name as directory name";
            this.UseNameCheck.UseVisualStyleBackColor = true;
            this.UseNameCheck.CheckedChanged += new System.EventHandler(this.UseNameCheck_CheckedChanged);
            // 
            // DirectoryNameBox
            // 
            this.DirectoryNameBox.Enabled = false;
            this.DirectoryNameBox.Location = new System.Drawing.Point(124, 51);
            this.DirectoryNameBox.MaxLength = 10;
            this.DirectoryNameBox.Name = "DirectoryNameBox";
            this.DirectoryNameBox.Size = new System.Drawing.Size(255, 20);
            this.DirectoryNameBox.TabIndex = 9;
            // 
            // FtpPortLabel
            // 
            this.FtpPortLabel.AutoSize = true;
            this.FtpPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtpPortLabel.Location = new System.Drawing.Point(229, 294);
            this.FtpPortLabel.Name = "FtpPortLabel";
            this.FtpPortLabel.Size = new System.Drawing.Size(34, 13);
            this.FtpPortLabel.TabIndex = 13;
            this.FtpPortLabel.Text = "Port:";
            // 
            // FtpStartLabel
            // 
            this.FtpStartLabel.AutoSize = true;
            this.FtpStartLabel.Location = new System.Drawing.Point(15, 313);
            this.FtpStartLabel.Name = "FtpStartLabel";
            this.FtpStartLabel.Size = new System.Drawing.Size(32, 13);
            this.FtpStartLabel.TabIndex = 11;
            this.FtpStartLabel.Text = "ftp://";
            // 
            // FtpPortBox
            // 
            this.FtpPortBox.Enabled = false;
            this.FtpPortBox.Location = new System.Drawing.Point(230, 310);
            this.FtpPortBox.Name = "FtpPortBox";
            this.FtpPortBox.Size = new System.Drawing.Size(149, 20);
            this.FtpPortBox.TabIndex = 14;
            // 
            // DirectoryNameLabel
            // 
            this.DirectoryNameLabel.AutoSize = true;
            this.DirectoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryNameLabel.Location = new System.Drawing.Point(15, 54);
            this.DirectoryNameLabel.Name = "DirectoryNameLabel";
            this.DirectoryNameLabel.Size = new System.Drawing.Size(96, 13);
            this.DirectoryNameLabel.TabIndex = 8;
            this.DirectoryNameLabel.Text = "Directory name:";
            // 
            // SaveImageCheck
            // 
            this.SaveImageCheck.AutoSize = true;
            this.SaveImageCheck.Location = new System.Drawing.Point(18, 247);
            this.SaveImageCheck.Name = "SaveImageCheck";
            this.SaveImageCheck.Size = new System.Drawing.Size(245, 17);
            this.SaveImageCheck.TabIndex = 7;
            this.SaveImageCheck.Text = "Save the amiibo\'s image along with the amiibo.";
            this.SaveImageCheck.UseVisualStyleBackColor = true;
            // 
            // FtpAddressBox
            // 
            this.FtpAddressBox.Enabled = false;
            this.FtpAddressBox.Location = new System.Drawing.Point(53, 310);
            this.FtpAddressBox.Name = "FtpAddressBox";
            this.FtpAddressBox.Size = new System.Drawing.Size(149, 20);
            this.FtpAddressBox.TabIndex = 12;
            // 
            // FtpAddressLabel
            // 
            this.FtpAddressLabel.AutoSize = true;
            this.FtpAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtpAddressLabel.Location = new System.Drawing.Point(55, 294);
            this.FtpAddressLabel.Name = "FtpAddressLabel";
            this.FtpAddressLabel.Size = new System.Drawing.Size(56, 13);
            this.FtpAddressLabel.TabIndex = 11;
            this.FtpAddressLabel.Text = "Address:";
            // 
            // FtpSaveCheck
            // 
            this.FtpSaveCheck.AutoSize = true;
            this.FtpSaveCheck.Location = new System.Drawing.Point(18, 270);
            this.FtpSaveCheck.Name = "FtpSaveCheck";
            this.FtpSaveCheck.Size = new System.Drawing.Size(184, 17);
            this.FtpSaveCheck.TabIndex = 11;
            this.FtpSaveCheck.Text = "Upload generated amiibos to FTP";
            this.FtpSaveCheck.UseVisualStyleBackColor = true;
            this.FtpSaveCheck.CheckedChanged += new System.EventHandler(this.FtpSaveCheck_CheckedChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(15, 61);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(361, 34);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create virtual amiibo";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RandomMiiLabel
            // 
            this.RandomMiiLabel.AutoSize = true;
            this.RandomMiiLabel.BackColor = System.Drawing.SystemColors.Control;
            this.RandomMiiLabel.ForeColor = System.Drawing.Color.DimGray;
            this.RandomMiiLabel.Location = new System.Drawing.Point(473, 530);
            this.RandomMiiLabel.Name = "RandomMiiLabel";
            this.RandomMiiLabel.Size = new System.Drawing.Size(291, 13);
            this.RandomMiiLabel.TabIndex = 8;
            this.RandomMiiLabel.Text = "In console, emuiibo will generate a random mii for the amiibo.";
            // 
            // GenerationBox
            // 
            this.GenerationBox.Controls.Add(this.LastPathCheck);
            this.GenerationBox.Controls.Add(this.LastPathLabel);
            this.GenerationBox.Controls.Add(this.CreateButton);
            this.GenerationBox.Location = new System.Drawing.Point(418, 358);
            this.GenerationBox.Name = "GenerationBox";
            this.GenerationBox.Size = new System.Drawing.Size(396, 112);
            this.GenerationBox.TabIndex = 9;
            this.GenerationBox.TabStop = false;
            this.GenerationBox.Text = "3 - Generate the virtual amiibo";
            // 
            // LastPathCheck
            // 
            this.LastPathCheck.AutoSize = true;
            this.LastPathCheck.Checked = true;
            this.LastPathCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastPathCheck.Location = new System.Drawing.Point(15, 34);
            this.LastPathCheck.Name = "LastPathCheck";
            this.LastPathCheck.Size = new System.Drawing.Size(155, 17);
            this.LastPathCheck.TabIndex = 17;
            this.LastPathCheck.Text = "Create in the last used path\n";
            this.LastPathCheck.UseVisualStyleBackColor = true;
            this.LastPathCheck.Visible = false;
            // 
            // LastPathLabel
            // 
            this.LastPathLabel.AutoSize = true;
            this.LastPathLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LastPathLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LastPathLabel.Location = new System.Drawing.Point(12, 18);
            this.LastPathLabel.Name = "LastPathLabel";
            this.LastPathLabel.Size = new System.Drawing.Size(42, 13);
            this.LastPathLabel.TabIndex = 16;
            this.LastPathLabel.Text = "Dummy";
            this.LastPathLabel.Visible = false;
            // 
            // APIStatusStrip
            // 
            this.APIStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.APIStatusLabel });
            this.APIStatusStrip.Location = new System.Drawing.Point(0, 567);
            this.APIStatusStrip.Name = "APIStatusStrip";
            this.APIStatusStrip.Size = new System.Drawing.Size(826, 22);
            this.APIStatusStrip.SizingGrip = false;
            this.APIStatusStrip.TabIndex = 10;
            this.APIStatusStrip.Text = "APIStatusStrip";
            // 
            // APIStatusLabel
            // 
            this.APIStatusLabel.Image = global::emutool.Properties.Resources.OkIcon;
            this.APIStatusLabel.Name = "APIStatusLabel";
            this.APIStatusLabel.Size = new System.Drawing.Size(35, 17);
            this.APIStatusLabel.Text = "    ";
            this.APIStatusLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // AmiiboPictureBox
            // 
            this.AmiiboPictureBox.Location = new System.Drawing.Point(17, 63);
            this.AmiiboPictureBox.Name = "AmiiboPictureBox";
            this.AmiiboPictureBox.Size = new System.Drawing.Size(362, 434);
            this.AmiiboPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AmiiboPictureBox.TabIndex = 0;
            this.AmiiboPictureBox.TabStop = false;
            // 
            // SeriesComboBox
            // 
            this.SeriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesComboBox.FormattingEnabled = true;
            this.SeriesComboBox.Location = new System.Drawing.Point(17, 29);
            this.SeriesComboBox.Name = "SeriesComboBox";
            this.SeriesComboBox.Size = new System.Drawing.Size(177, 21);
            this.SeriesComboBox.TabIndex = 1;
            this.SeriesComboBox.SelectedIndexChanged += new System.EventHandler(this.SeriesComboBox_SelectedIndexChanged);
            // 
            // AmiiboComboBox
            // 
            this.AmiiboComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmiiboComboBox.FormattingEnabled = true;
            this.AmiiboComboBox.Location = new System.Drawing.Point(202, 29);
            this.AmiiboComboBox.Name = "AmiiboComboBox";
            this.AmiiboComboBox.Size = new System.Drawing.Size(177, 21);
            this.AmiiboComboBox.TabIndex = 2;
            this.AmiiboComboBox.SelectedIndexChanged += new System.EventHandler(this.AmiiboComboBox_SelectedIndexChanged);
            // 
            // AmiiboSelectBox
            // 
            this.AmiiboSelectBox.Controls.Add(this.CreateAllCheck);
            this.AmiiboSelectBox.Controls.Add(this.AmiiboComboBox);
            this.AmiiboSelectBox.Controls.Add(this.SeriesComboBox);
            this.AmiiboSelectBox.Controls.Add(this.AmiiboPictureBox);
            this.AmiiboSelectBox.Location = new System.Drawing.Point(12, 12);
            this.AmiiboSelectBox.Name = "AmiiboSelectBox";
            this.AmiiboSelectBox.Size = new System.Drawing.Size(396, 547);
            this.AmiiboSelectBox.TabIndex = 3;
            this.AmiiboSelectBox.TabStop = false;
            this.AmiiboSelectBox.Text = "1 - Choose a virtual amiibo";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(437, 494);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(362, 28);
            this.AboutButton.TabIndex = 12;
            this.AboutButton.Text = "About emuiibo and emutool";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 589);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.APIStatusStrip);
            this.Controls.Add(this.GenerationBox);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.AmiiboSelectBox);
            this.Controls.Add(this.RandomMiiLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy";
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.GenerationBox.ResumeLayout(false);
            this.GenerationBox.PerformLayout();
            this.APIStatusStrip.ResumeLayout(false);
            this.APIStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmiiboPictureBox)).EndInit();
            this.AmiiboSelectBox.ResumeLayout(false);
            this.AmiiboSelectBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AmiiboNameBox;
        private System.Windows.Forms.Label AmiiboNameLabel;
        private System.Windows.Forms.CheckBox RandomizeUuidCheck;
        private System.Windows.Forms.Label RandomUuidLabel;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label RandomMiiLabel;
        private System.Windows.Forms.GroupBox GenerationBox;
        private System.Windows.Forms.StatusStrip APIStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel APIStatusLabel;
        private System.Windows.Forms.CheckBox UseNameCheck;
        private System.Windows.Forms.TextBox DirectoryNameBox;
        private System.Windows.Forms.Label DirectoryNameLabel;
        private System.Windows.Forms.CheckBox SaveImageCheck;
        private System.Windows.Forms.PictureBox AmiiboPictureBox;
        private System.Windows.Forms.ComboBox SeriesComboBox;
        private System.Windows.Forms.ComboBox AmiiboComboBox;
        private System.Windows.Forms.GroupBox AmiiboSelectBox;
        private System.Windows.Forms.Label FtpAddressLabel;
        private System.Windows.Forms.CheckBox FtpSaveCheck;
        private System.Windows.Forms.TextBox FtpAddressBox;
        private System.Windows.Forms.Label FtpPortLabel;
        private System.Windows.Forms.TextBox FtpPortBox;
        private System.Windows.Forms.Label FtpStartLabel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label LastPathLabel;
        private System.Windows.Forms.CheckBox LastPathCheck;
        private System.Windows.Forms.CheckBox CreateAllCheck;
    }
}

