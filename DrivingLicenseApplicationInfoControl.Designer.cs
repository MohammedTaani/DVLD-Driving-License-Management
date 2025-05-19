namespace DVLD_Driving_License_Management
{
    partial class DrivingLicenseApplicationInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApplicationID = new System.Windows.Forms.Label();
            this.labelAppliedForLicense = new System.Windows.Forms.Label();
            this.labelPassedTests = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.App ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applied for Lincense :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passed Tests:";
            // 
            // labelApplicationID
            // 
            this.labelApplicationID.AutoSize = true;
            this.labelApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationID.Location = new System.Drawing.Point(148, 11);
            this.labelApplicationID.Name = "labelApplicationID";
            this.labelApplicationID.Size = new System.Drawing.Size(31, 16);
            this.labelApplicationID.TabIndex = 3;
            this.labelApplicationID.Text = "???";
            // 
            // labelAppliedForLicense
            // 
            this.labelAppliedForLicense.AutoSize = true;
            this.labelAppliedForLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppliedForLicense.Location = new System.Drawing.Point(473, 15);
            this.labelAppliedForLicense.Name = "labelAppliedForLicense";
            this.labelAppliedForLicense.Size = new System.Drawing.Size(31, 16);
            this.labelAppliedForLicense.TabIndex = 4;
            this.labelAppliedForLicense.Text = "???";
            // 
            // labelPassedTests
            // 
            this.labelPassedTests.AutoSize = true;
            this.labelPassedTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassedTests.Location = new System.Drawing.Point(473, 60);
            this.labelPassedTests.Name = "labelPassedTests";
            this.labelPassedTests.Size = new System.Drawing.Size(31, 16);
            this.labelPassedTests.TabIndex = 5;
            this.labelPassedTests.Text = "???";
            // 
            // DrivingLicenseApplicationInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPassedTests);
            this.Controls.Add(this.labelAppliedForLicense);
            this.Controls.Add(this.labelApplicationID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DrivingLicenseApplicationInfoControl";
            this.Size = new System.Drawing.Size(858, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApplicationID;
        private System.Windows.Forms.Label labelAppliedForLicense;
        private System.Windows.Forms.Label labelPassedTests;
    }
}
