namespace DVLD_Driving_License_Management
{
    partial class frmShowUserDetails
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
            this.showPersonInfoControl1 = new DVLD_Driving_License_Management.ShowPersonInfoControl();
            this.label1 = new System.Windows.Forms.Label();
            this.showUserInformationControl1 = new DVLD_Driving_License_Management.ShowUserInformationControl();
            this.SuspendLayout();
            // 
            // showPersonInfoControl1
            // 
            this.showPersonInfoControl1.Location = new System.Drawing.Point(24, -16);
            this.showPersonInfoControl1.Name = "showPersonInfoControl1";
            this.showPersonInfoControl1.Size = new System.Drawing.Size(787, 324);
            this.showPersonInfoControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Details";
            // 
            // showUserInformationControl1
            // 
            this.showUserInformationControl1.Location = new System.Drawing.Point(46, 312);
            this.showUserInformationControl1.Name = "showUserInformationControl1";
            this.showUserInformationControl1.Size = new System.Drawing.Size(692, 127);
            this.showUserInformationControl1.TabIndex = 2;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.showUserInformationControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPersonInfoControl1);
            this.Name = "frmShowUserDetails";
            this.Text = "frmShowUserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowPersonInfoControl showPersonInfoControl1;
        private System.Windows.Forms.Label label1;
        private ShowUserInformationControl showUserInformationControl1;
    }
}