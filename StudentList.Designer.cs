namespace vbsDB
{
    partial class StudentList
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
            this.lstStudents = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.clmGroupWith = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCrew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDropStudent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmParent,
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
            this.clmGroupWith,
            this.clmCrew,
            this.clmID});
            this.lstStudents.Location = new System.Drawing.Point(0, 0);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(765, 278);
            this.lstStudents.TabIndex = 1;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            // 
            // clmParent
            // 
            this.clmParent.Text = "Parent";
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
            // clmGroupWith
            // 
            this.clmGroupWith.Text = "Group with";
            // 
            // clmCrew
            // 
            this.clmCrew.Text = "Crew";
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(771, 92);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(85, 23);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDropStudent
            // 
            this.btnDropStudent.Location = new System.Drawing.Point(771, 121);
            this.btnDropStudent.Name = "btnDropStudent";
            this.btnDropStudent.Size = new System.Drawing.Size(85, 23);
            this.btnDropStudent.TabIndex = 3;
            this.btnDropStudent.Text = "Drop Student";
            this.btnDropStudent.UseVisualStyleBackColor = true;
            this.btnDropStudent.Click += new System.EventHandler(this.btnDropStudent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(771, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 278);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDropStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.lstStudents);
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmParent;
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
        private System.Windows.Forms.ColumnHeader clmGroupWith;
        private System.Windows.Forms.ColumnHeader clmCrew;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDropStudent;
        private System.Windows.Forms.Button btnRefresh;

    }
}