namespace CheckerUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.buttonBrowseDownload = new System.Windows.Forms.Button();
            this.buttonBrowseCheckerDirectory = new System.Windows.Forms.Button();
            this.textDownloads = new System.Windows.Forms.TextBox();
            this.textHomework = new System.Windows.Forms.TextBox();
            this.textCheckerDir = new System.Windows.Forms.TextBox();
            this.labelDownload = new System.Windows.Forms.Label();
            this.labelHomework = new System.Windows.Forms.Label();
            this.labelCheckerDir = new System.Windows.Forms.Label();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tabTests = new System.Windows.Forms.TabPage();
            this.tabBuil = new System.Windows.Forms.TabPage();
            this.tabGrading = new System.Windows.Forms.TabPage();
            this.tabStrings = new System.Windows.Forms.TabPage();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabGeneral);
            this.tabMain.Controls.Add(this.tabTests);
            this.tabMain.Controls.Add(this.tabBuil);
            this.tabMain.Controls.Add(this.tabGrading);
            this.tabMain.Controls.Add(this.tabStrings);
            this.tabMain.Controls.Add(this.tabMisc);
            this.tabMain.Location = new System.Drawing.Point(12, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(668, 376);
            this.tabMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.buttonBrowseDownload);
            this.tabGeneral.Controls.Add(this.buttonBrowseCheckerDirectory);
            this.tabGeneral.Controls.Add(this.textDownloads);
            this.tabGeneral.Controls.Add(this.textHomework);
            this.tabGeneral.Controls.Add(this.textCheckerDir);
            this.tabGeneral.Controls.Add(this.labelDownload);
            this.tabGeneral.Controls.Add(this.labelHomework);
            this.tabGeneral.Controls.Add(this.labelCheckerDir);
            this.tabGeneral.Controls.Add(this.textZip);
            this.tabGeneral.Controls.Add(this.textSubject);
            this.tabGeneral.Controls.Add(this.labelZip);
            this.tabGeneral.Controls.Add(this.labelSubject);
            this.tabGeneral.Controls.Add(this.textPassword);
            this.tabGeneral.Controls.Add(this.labelPassword);
            this.tabGeneral.Controls.Add(this.textEmail);
            this.tabGeneral.Controls.Add(this.labelEmail);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(660, 350);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            this.tabGeneral.Click += new System.EventHandler(this.tabGeneral_Click);
            // 
            // buttonBrowseDownload
            // 
            this.buttonBrowseDownload.Location = new System.Drawing.Point(249, 162);
            this.buttonBrowseDownload.Name = "buttonBrowseDownload";
            this.buttonBrowseDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDownload.TabIndex = 15;
            this.buttonBrowseDownload.Text = "Browse";
            this.buttonBrowseDownload.UseVisualStyleBackColor = true;
            this.buttonBrowseDownload.Click += new System.EventHandler(this.buttonBrowseDownload_Click);
            // 
            // buttonBrowseCheckerDirectory
            // 
            this.buttonBrowseCheckerDirectory.Location = new System.Drawing.Point(249, 136);
            this.buttonBrowseCheckerDirectory.Name = "buttonBrowseCheckerDirectory";
            this.buttonBrowseCheckerDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseCheckerDirectory.TabIndex = 14;
            this.buttonBrowseCheckerDirectory.Text = "Browse";
            this.buttonBrowseCheckerDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseCheckerDirectory.Click += new System.EventHandler(this.buttonBrowseCheckerDirectory_Click);
            // 
            // textDownloads
            // 
            this.textDownloads.Location = new System.Drawing.Point(104, 164);
            this.textDownloads.Name = "textDownloads";
            this.textDownloads.Size = new System.Drawing.Size(139, 20);
            this.textDownloads.TabIndex = 13;
            // 
            // textHomework
            // 
            this.textHomework.Location = new System.Drawing.Point(104, 112);
            this.textHomework.Name = "textHomework";
            this.textHomework.Size = new System.Drawing.Size(220, 20);
            this.textHomework.TabIndex = 12;
            // 
            // textCheckerDir
            // 
            this.textCheckerDir.Location = new System.Drawing.Point(104, 138);
            this.textCheckerDir.Name = "textCheckerDir";
            this.textCheckerDir.Size = new System.Drawing.Size(139, 20);
            this.textCheckerDir.TabIndex = 11;
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Location = new System.Drawing.Point(6, 167);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(80, 13);
            this.labelDownload.TabIndex = 10;
            this.labelDownload.Text = "Download Path";
            this.labelDownload.Click += new System.EventHandler(this.labelDownload_Click);
            // 
            // labelHomework
            // 
            this.labelHomework.AutoSize = true;
            this.labelHomework.Location = new System.Drawing.Point(6, 115);
            this.labelHomework.Name = "labelHomework";
            this.labelHomework.Size = new System.Drawing.Size(58, 13);
            this.labelHomework.TabIndex = 9;
            this.labelHomework.Text = "Homework";
            // 
            // labelCheckerDir
            // 
            this.labelCheckerDir.AutoSize = true;
            this.labelCheckerDir.Location = new System.Drawing.Point(6, 141);
            this.labelCheckerDir.Name = "labelCheckerDir";
            this.labelCheckerDir.Size = new System.Drawing.Size(92, 13);
            this.labelCheckerDir.TabIndex = 8;
            this.labelCheckerDir.Text = "Checker Directory";
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(104, 86);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(220, 20);
            this.textZip.TabIndex = 7;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(104, 59);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(220, 20);
            this.textSubject.TabIndex = 6;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(6, 89);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(22, 13);
            this.labelZip.TabIndex = 5;
            this.labelZip.Text = "Zip";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(6, 62);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Subject";
            this.labelSubject.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(104, 32);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(220, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(104, 6);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(220, 20);
            this.textEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabTests
            // 
            this.tabTests.Location = new System.Drawing.Point(4, 22);
            this.tabTests.Name = "tabTests";
            this.tabTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabTests.Size = new System.Drawing.Size(660, 350);
            this.tabTests.TabIndex = 1;
            this.tabTests.Text = "Tests";
            this.tabTests.UseVisualStyleBackColor = true;
            // 
            // tabBuil
            // 
            this.tabBuil.Location = new System.Drawing.Point(4, 22);
            this.tabBuil.Name = "tabBuil";
            this.tabBuil.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuil.Size = new System.Drawing.Size(660, 350);
            this.tabBuil.TabIndex = 2;
            this.tabBuil.Text = "Build";
            this.tabBuil.UseVisualStyleBackColor = true;
            this.tabBuil.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabGrading
            // 
            this.tabGrading.Location = new System.Drawing.Point(4, 22);
            this.tabGrading.Name = "tabGrading";
            this.tabGrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrading.Size = new System.Drawing.Size(660, 350);
            this.tabGrading.TabIndex = 3;
            this.tabGrading.Text = "Grading";
            this.tabGrading.UseVisualStyleBackColor = true;
            this.tabGrading.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabStrings
            // 
            this.tabStrings.Location = new System.Drawing.Point(4, 22);
            this.tabStrings.Name = "tabStrings";
            this.tabStrings.Padding = new System.Windows.Forms.Padding(3);
            this.tabStrings.Size = new System.Drawing.Size(660, 350);
            this.tabStrings.TabIndex = 4;
            this.tabStrings.Text = "Strings";
            this.tabStrings.UseVisualStyleBackColor = true;
            this.tabStrings.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabMisc
            // 
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(660, 350);
            this.tabMisc.TabIndex = 5;
            this.tabMisc.Text = "Misc";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 415);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Checker Configuration Utility";
            this.tabMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabTests;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabBuil;
        private System.Windows.Forms.TabPage tabGrading;
        private System.Windows.Forms.TabPage tabStrings;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.Label labelHomework;
        private System.Windows.Forms.Label labelCheckerDir;
        private System.Windows.Forms.Button buttonBrowseDownload;
        private System.Windows.Forms.Button buttonBrowseCheckerDirectory;
        private System.Windows.Forms.TextBox textDownloads;
        private System.Windows.Forms.TextBox textHomework;
        private System.Windows.Forms.TextBox textCheckerDir;
    }
}

