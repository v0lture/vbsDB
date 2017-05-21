namespace vbsDB
{
    partial class LeaderList
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
            this.lstLeaders = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContactTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmContactHow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAllergies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBirthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHelpWith = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditLeader = new System.Windows.Forms.Button();
            this.btnDropLeader = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeaders
            // 
            this.lstLeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmAddress,
            this.clmCity,
            this.clmPhone,
            this.clmCell,
            this.clmEmail,
            this.clmContactTime,
            this.clmContactHow,
            this.clmAllergies,
            this.clmBirthdate,
            this.clmAge,
            this.clmHelpWith,
            this.clmID});
            this.lstLeaders.Location = new System.Drawing.Point(0, 0);
            this.lstLeaders.Margin = new System.Windows.Forms.Padding(4);
            this.lstLeaders.Name = "lstLeaders";
            this.lstLeaders.Size = new System.Drawing.Size(1019, 341);
            this.lstLeaders.TabIndex = 1;
            this.lstLeaders.UseCompatibleStateImageBehavior = false;
            this.lstLeaders.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            // 
            // clmCity
            // 
            this.clmCity.Text = "City";
            // 
            // clmPhone
            // 
            this.clmPhone.Text = "Phone";
            // 
            // clmCell
            // 
            this.clmCell.Text = "Cell Phone";
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            // 
            // clmContactTime
            // 
            this.clmContactTime.Text = "Best time to contact";
            // 
            // clmContactHow
            // 
            this.clmContactHow.Text = "Method of contact";
            // 
            // clmAllergies
            // 
            this.clmAllergies.Text = "Allergies";
            // 
            // clmBirthdate
            // 
            this.clmBirthdate.Text = "Birthdate";
            // 
            // clmAge
            // 
            this.clmAge.Text = "Age";
            // 
            // clmHelpWith
            // 
            this.clmHelpWith.Text = "Helping with";
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            // 
            // btnEditLeader
            // 
            this.btnEditLeader.Location = new System.Drawing.Point(1028, 113);
            this.btnEditLeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditLeader.Name = "btnEditLeader";
            this.btnEditLeader.Size = new System.Drawing.Size(113, 28);
            this.btnEditLeader.TabIndex = 2;
            this.btnEditLeader.Text = "Edit Leader";
            this.btnEditLeader.UseVisualStyleBackColor = true;
            this.btnEditLeader.Click += new System.EventHandler(this.btnEditLeader_Click);
            // 
            // btnDropLeader
            // 
            this.btnDropLeader.Location = new System.Drawing.Point(1028, 149);
            this.btnDropLeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropLeader.Name = "btnDropLeader";
            this.btnDropLeader.Size = new System.Drawing.Size(113, 28);
            this.btnDropLeader.TabIndex = 3;
            this.btnDropLeader.Text = "Drop Leader";
            this.btnDropLeader.UseVisualStyleBackColor = true;
            this.btnDropLeader.Click += new System.EventHandler(this.btnDropLeader_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1028, 185);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 342);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDropLeader);
            this.Controls.Add(this.btnEditLeader);
            this.Controls.Add(this.lstLeaders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeaderList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.LeaderList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLeaders;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.ColumnHeader clmCity;
        private System.Windows.Forms.ColumnHeader clmPhone;
        private System.Windows.Forms.ColumnHeader clmCell;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmContactTime;
        private System.Windows.Forms.ColumnHeader clmContactHow;
        private System.Windows.Forms.ColumnHeader clmAllergies;
        private System.Windows.Forms.ColumnHeader clmBirthdate;
        private System.Windows.Forms.ColumnHeader clmAge;
        private System.Windows.Forms.ColumnHeader clmHelpWith;
        private System.Windows.Forms.Button btnEditLeader;
        private System.Windows.Forms.Button btnDropLeader;
        private System.Windows.Forms.Button btnRefresh;

    }
}