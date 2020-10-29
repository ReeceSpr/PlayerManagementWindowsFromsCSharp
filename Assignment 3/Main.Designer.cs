namespace Assignment_3
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signAPlayerToATeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightAndWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.listViewTeam = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioBPlace = new System.Windows.Forms.RadioButton();
            this.radioAge = new System.Windows.Forms.RadioButton();
            this.radioTeamName = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.folderSave = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.addToolStripMenuItem,
            this.signToolStripMenuItem,
            this.plotToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1888, 40);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "File";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersFileToolStripMenuItem1,
            this.teamFileToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // playersFileToolStripMenuItem1
            // 
            this.playersFileToolStripMenuItem1.Name = "playersFileToolStripMenuItem1";
            this.playersFileToolStripMenuItem1.Size = new System.Drawing.Size(232, 38);
            this.playersFileToolStripMenuItem1.Text = "Players File";
            this.playersFileToolStripMenuItem1.Click += new System.EventHandler(this.playersFileToolStripMenuItem1_Click);
            // 
            // teamFileToolStripMenuItem1
            // 
            this.teamFileToolStripMenuItem1.Name = "teamFileToolStripMenuItem1";
            this.teamFileToolStripMenuItem1.Size = new System.Drawing.Size(232, 38);
            this.teamFileToolStripMenuItem1.Text = "Team File";
            this.teamFileToolStripMenuItem1.Click += new System.EventHandler(this.teamFileToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersFileToolStripMenuItem,
            this.teamFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // playersFileToolStripMenuItem
            // 
            this.playersFileToolStripMenuItem.Name = "playersFileToolStripMenuItem";
            this.playersFileToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.playersFileToolStripMenuItem.Text = "Players File";
            this.playersFileToolStripMenuItem.Click += new System.EventHandler(this.playersFileToolStripMenuItem_Click);
            // 
            // teamFileToolStripMenuItem
            // 
            this.teamFileToolStripMenuItem.Name = "teamFileToolStripMenuItem";
            this.teamFileToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.teamFileToolStripMenuItem.Text = "Team File";
            this.teamFileToolStripMenuItem.Click += new System.EventHandler(this.teamFileToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPlayerToolStripMenuItem,
            this.addNewTeamToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewPlayerToolStripMenuItem
            // 
            this.addNewPlayerToolStripMenuItem.Name = "addNewPlayerToolStripMenuItem";
            this.addNewPlayerToolStripMenuItem.Size = new System.Drawing.Size(283, 38);
            this.addNewPlayerToolStripMenuItem.Text = "Add New Player";
            this.addNewPlayerToolStripMenuItem.Click += new System.EventHandler(this.addNewPlayerToolStripMenuItem_Click);
            // 
            // addNewTeamToolStripMenuItem
            // 
            this.addNewTeamToolStripMenuItem.Name = "addNewTeamToolStripMenuItem";
            this.addNewTeamToolStripMenuItem.Size = new System.Drawing.Size(283, 38);
            this.addNewTeamToolStripMenuItem.Text = "Add New Team";
            this.addNewTeamToolStripMenuItem.Click += new System.EventHandler(this.addNewTeamToolStripMenuItem_Click);
            // 
            // signToolStripMenuItem
            // 
            this.signToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signAPlayerToATeamToolStripMenuItem});
            this.signToolStripMenuItem.Name = "signToolStripMenuItem";
            this.signToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.signToolStripMenuItem.Text = "Sign";
            // 
            // signAPlayerToATeamToolStripMenuItem
            // 
            this.signAPlayerToATeamToolStripMenuItem.Name = "signAPlayerToATeamToolStripMenuItem";
            this.signAPlayerToATeamToolStripMenuItem.Size = new System.Drawing.Size(372, 38);
            this.signAPlayerToATeamToolStripMenuItem.Text = "Sign A Player To A Team";
            this.signAPlayerToATeamToolStripMenuItem.Click += new System.EventHandler(this.signAPlayerToATeamToolStripMenuItem_Click);
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heightAndWeightToolStripMenuItem,
            this.ageGroupsToolStripMenuItem});
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.plotToolStripMenuItem.Text = "Plot";
            // 
            // heightAndWeightToolStripMenuItem
            // 
            this.heightAndWeightToolStripMenuItem.Name = "heightAndWeightToolStripMenuItem";
            this.heightAndWeightToolStripMenuItem.Size = new System.Drawing.Size(316, 38);
            this.heightAndWeightToolStripMenuItem.Text = "Height and Weight";
            // 
            // ageGroupsToolStripMenuItem
            // 
            this.ageGroupsToolStripMenuItem.Name = "ageGroupsToolStripMenuItem";
            this.ageGroupsToolStripMenuItem.Size = new System.Drawing.Size(316, 38);
            this.ageGroupsToolStripMenuItem.Text = "Age Groups";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(25, 59);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(334, 31);
            this.textSearch.TabIndex = 2;
            this.textSearch.Text = "Search";
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnSecondName,
            this.columnBirth,
            this.columnHeight,
            this.columnWeight,
            this.columnBirthPlace,
            this.columnTeam});
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.Location = new System.Drawing.Point(25, 96);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(1801, 364);
            this.listViewPlayers.TabIndex = 5;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 120;
            // 
            // columnSecondName
            // 
            this.columnSecondName.Text = "Second Name";
            this.columnSecondName.Width = 120;
            // 
            // columnBirth
            // 
            this.columnBirth.Text = "BirthDate";
            this.columnBirth.Width = 120;
            // 
            // columnHeight
            // 
            this.columnHeight.Text = "Height";
            this.columnHeight.Width = 120;
            // 
            // columnWeight
            // 
            this.columnWeight.Text = "Weight";
            this.columnWeight.Width = 120;
            // 
            // columnBirthPlace
            // 
            this.columnBirthPlace.Text = "Birth Place";
            this.columnBirthPlace.Width = 120;
            // 
            // columnTeam
            // 
            this.columnTeam.Text = "Team Name";
            this.columnTeam.Width = 417;
            // 
            // openFile
            // 
            this.openFile.InitialDirectory = "C:\\Users\\Reece\\OneDrive - Massey University\\Second Year\\App and Soft\\Assignment 3" +
    "\\Assignment 3";
            // 
            // listViewTeam
            // 
            this.listViewTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnRegion,
            this.columnCoach,
            this.columnYear});
            this.listViewTeam.FullRowSelect = true;
            this.listViewTeam.Location = new System.Drawing.Point(25, 522);
            this.listViewTeam.Name = "listViewTeam";
            this.listViewTeam.Size = new System.Drawing.Size(1801, 480);
            this.listViewTeam.TabIndex = 6;
            this.listViewTeam.UseCompatibleStateImageBehavior = false;
            this.listViewTeam.View = System.Windows.Forms.View.Details;
            this.listViewTeam.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTeam_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Team Name";
            this.columnName.Width = 218;
            // 
            // columnRegion
            // 
            this.columnRegion.Text = "Region";
            this.columnRegion.Width = 224;
            // 
            // columnCoach
            // 
            this.columnCoach.Text = "Coach";
            this.columnCoach.Width = 254;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Founded";
            this.columnYear.Width = 406;
            // 
            // radioBPlace
            // 
            this.radioBPlace.AutoSize = true;
            this.radioBPlace.Location = new System.Drawing.Point(365, 59);
            this.radioBPlace.Name = "radioBPlace";
            this.radioBPlace.Size = new System.Drawing.Size(147, 29);
            this.radioBPlace.TabIndex = 7;
            this.radioBPlace.TabStop = true;
            this.radioBPlace.Text = "Birth Place";
            this.radioBPlace.UseVisualStyleBackColor = true;
            // 
            // radioAge
            // 
            this.radioAge.AutoSize = true;
            this.radioAge.Location = new System.Drawing.Point(536, 59);
            this.radioAge.Name = "radioAge";
            this.radioAge.Size = new System.Drawing.Size(81, 29);
            this.radioAge.TabIndex = 8;
            this.radioAge.TabStop = true;
            this.radioAge.Text = "Age";
            this.radioAge.UseVisualStyleBackColor = true;
            // 
            // radioTeamName
            // 
            this.radioTeamName.AutoSize = true;
            this.radioTeamName.Location = new System.Drawing.Point(623, 61);
            this.radioTeamName.Name = "radioTeamName";
            this.radioTeamName.Size = new System.Drawing.Size(159, 29);
            this.radioTeamName.TabIndex = 9;
            this.radioTeamName.TabStop = true;
            this.radioTeamName.Text = "Team Name";
            this.radioTeamName.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1703, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 47);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(1579, 50);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(118, 47);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Show All";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1888, 1086);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioTeamName);
            this.Controls.Add(this.radioAge);
            this.Controls.Add(this.radioBPlace);
            this.Controls.Add(this.listViewTeam);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Assignment 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signAPlayerToATeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightAndWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageGroupsToolStripMenuItem;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnSecondName;
        private System.Windows.Forms.ColumnHeader columnBirth;
        private System.Windows.Forms.ColumnHeader columnHeight;
        private System.Windows.Forms.ColumnHeader columnWeight;
        private System.Windows.Forms.ColumnHeader columnBirthPlace;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem playersFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamFileToolStripMenuItem;
        private System.Windows.Forms.ListView listViewTeam;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnRegion;
        private System.Windows.Forms.ColumnHeader columnCoach;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnTeam;
        private System.Windows.Forms.RadioButton radioBPlace;
        private System.Windows.Forms.RadioButton radioAge;
        private System.Windows.Forms.RadioButton radioTeamName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ToolStripMenuItem playersFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teamFileToolStripMenuItem1;
        private System.Windows.Forms.FolderBrowserDialog folderSave;
    }
}

