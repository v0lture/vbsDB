namespace vbsDB
{
    partial class vbsDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vbsDB));
            this.btnAllergies = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLeaders = new System.Windows.Forms.Button();
            this.btnCrews = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCrewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailingLabelsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newYearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllergies
            // 
            this.btnAllergies.Location = new System.Drawing.Point(15, 246);
            this.btnAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllergies.Name = "btnAllergies";
            this.btnAllergies.Size = new System.Drawing.Size(93, 34);
            this.btnAllergies.TabIndex = 0;
            this.btnAllergies.Text = "Allergies";
            this.btnAllergies.UseVisualStyleBackColor = true;
            this.btnAllergies.Click += new System.EventHandler(this.btnAllergies_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(163, 246);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(93, 34);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(459, 246);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(93, 34);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLeaders
            // 
            this.btnLeaders.Location = new System.Drawing.Point(607, 246);
            this.btnLeaders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaders.Name = "btnLeaders";
            this.btnLeaders.Size = new System.Drawing.Size(93, 34);
            this.btnLeaders.TabIndex = 3;
            this.btnLeaders.Text = "Leaders";
            this.btnLeaders.UseVisualStyleBackColor = true;
            this.btnLeaders.Click += new System.EventHandler(this.btnLeaders_Click);
            // 
            // btnCrews
            // 
            this.btnCrews.Location = new System.Drawing.Point(315, 246);
            this.btnCrews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrews.Name = "btnCrews";
            this.btnCrews.Size = new System.Drawing.Size(93, 34);
            this.btnCrews.TabIndex = 4;
            this.btnCrews.Text = "Crews";
            this.btnCrews.UseVisualStyleBackColor = true;
            this.btnCrews.Visible = false;
            this.btnCrews.Click += new System.EventHandler(this.btnCrews_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(237, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "vbsDB: Keeping Track of Students";
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMainLogo.Image")));
            this.pbMainLogo.Location = new System.Drawing.Point(163, 55);
            this.pbMainLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(389, 185);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainLogo.TabIndex = 6;
            this.pbMainLogo.TabStop = false;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(716, 28);
            this.mainMenu.TabIndex = 7;
            this.mainMenu.Text = "mainMenu";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLeaderToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.editCrewsToolStripMenuItem,
            this.mailingLabelsToolStripMenuItem1,
            this.newYearToolStripMenuItem1,
            this.setUpDatabaseToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addLeaderToolStripMenuItem
            // 
            this.addLeaderToolStripMenuItem.Name = "addLeaderToolStripMenuItem";
            this.addLeaderToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.addLeaderToolStripMenuItem.Text = "Add Leader";
            this.addLeaderToolStripMenuItem.Click += new System.EventHandler(this.addLeaderToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editCrewsToolStripMenuItem
            // 
            this.editCrewsToolStripMenuItem.Name = "editCrewsToolStripMenuItem";
            this.editCrewsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.editCrewsToolStripMenuItem.Text = "Edit Crews";
            this.editCrewsToolStripMenuItem.Click += new System.EventHandler(this.editCrewsToolStripMenuItem_Click);
            // 
            // mailingLabelsToolStripMenuItem1
            // 
            this.mailingLabelsToolStripMenuItem1.Name = "mailingLabelsToolStripMenuItem1";
            this.mailingLabelsToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.mailingLabelsToolStripMenuItem1.Text = "Mailing Labels";
            this.mailingLabelsToolStripMenuItem1.Visible = false;
            this.mailingLabelsToolStripMenuItem1.Click += new System.EventHandler(this.mailingLabelsToolStripMenuItem1_Click);
            // 
            // newYearToolStripMenuItem1
            // 
            this.newYearToolStripMenuItem1.Name = "newYearToolStripMenuItem1";
            this.newYearToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.newYearToolStripMenuItem1.Text = "New Year";
            this.newYearToolStripMenuItem1.Visible = false;
            this.newYearToolStripMenuItem1.Click += new System.EventHandler(this.newYearToolStripMenuItem1_Click);
            // 
            // setUpDatabaseToolStripMenuItem
            // 
            this.setUpDatabaseToolStripMenuItem.Name = "setUpDatabaseToolStripMenuItem";
            this.setUpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.setUpDatabaseToolStripMenuItem.Text = "Set up database";
            this.setUpDatabaseToolStripMenuItem.Click += new System.EventHandler(this.setUpDatabaseToolStripMenuItem_Click);
            // 
            // vbsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 293);
            this.Controls.Add(this.pbMainLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCrews);
            this.Controls.Add(this.btnLeaders);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnAllergies);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vbsDB";
            this.Text = "vbsDB";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllergies;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLeaders;
        private System.Windows.Forms.Button btnCrews;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbMainLogo;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCrewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailingLabelsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newYearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpDatabaseToolStripMenuItem;
    }
}

