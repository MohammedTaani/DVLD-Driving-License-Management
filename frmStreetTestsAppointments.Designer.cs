namespace DVLD_Driving_License_Management
{
    partial class frmStreetTestsAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStreetTestsAppointments));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applicationBasicInfoControl1 = new DVLD_Driving_License_Management.ApplicationBasicInfoControl();
            this.appointmentTestControl1 = new DVLD_Driving_License_Management.AppointmentTestControl();
            this.drivingLicenseApplicationInfoControl1 = new DVLD_Driving_License_Management.DrivingLicenseApplicationInfoControl();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Street Test Appointments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // applicationBasicInfoControl1
            // 
            this.applicationBasicInfoControl1.Location = new System.Drawing.Point(12, 203);
            this.applicationBasicInfoControl1.Name = "applicationBasicInfoControl1";
            this.applicationBasicInfoControl1.Size = new System.Drawing.Size(754, 158);
            this.applicationBasicInfoControl1.TabIndex = 2;
            // 
            // appointmentTestControl1
            // 
            this.appointmentTestControl1.Location = new System.Drawing.Point(12, 367);
            this.appointmentTestControl1.Name = "appointmentTestControl1";
            this.appointmentTestControl1.Size = new System.Drawing.Size(707, 258);
            this.appointmentTestControl1.TabIndex = 3;
            // 
            // drivingLicenseApplicationInfoControl1
            // 
            this.drivingLicenseApplicationInfoControl1.Location = new System.Drawing.Point(12, 110);
            this.drivingLicenseApplicationInfoControl1.Name = "drivingLicenseApplicationInfoControl1";
            this.drivingLicenseApplicationInfoControl1.Size = new System.Drawing.Size(776, 86);
            this.drivingLicenseApplicationInfoControl1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(640, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStreetTestsAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 657);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.drivingLicenseApplicationInfoControl1);
            this.Controls.Add(this.appointmentTestControl1);
            this.Controls.Add(this.applicationBasicInfoControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmStreetTestsAppointments";
            this.Text = "frmStreetTestsAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ApplicationBasicInfoControl applicationBasicInfoControl1;
        private AppointmentTestControl appointmentTestControl1;
        private DrivingLicenseApplicationInfoControl drivingLicenseApplicationInfoControl1;
        private System.Windows.Forms.Button btnClose;
    }
}