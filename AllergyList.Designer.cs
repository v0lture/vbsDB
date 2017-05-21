namespace vbsDB
{
    partial class AllergyList
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
            this.lstAllergies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAllergies
            // 
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.ItemHeight = 16;
            this.lstAllergies.Location = new System.Drawing.Point(16, 15);
            this.lstAllergies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.Size = new System.Drawing.Size(345, 292);
            this.lstAllergies.TabIndex = 0;
            // 
            // AllergyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lstAllergies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllergyList";
            this.Text = "Allergies";
            this.Load += new System.EventHandler(this.AllergyList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllergies;

    }
}