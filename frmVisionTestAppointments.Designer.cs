namespace DVLD_Driving_License_Management
{
    partial class frmVisionTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisionTestAppointments));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.appointmentTestControl1 = new DVLD_Driving_License_Management.AppointmentTestControl();
            this.applicationBasicInfoControl1 = new DVLD_Driving_License_Management.ApplicationBasicInfoControl();
            this.drivingLicenseApplicationInfoControl1 = new DVLD_Driving_License_Management.DrivingLicenseApplicationInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vision Test Appointments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 612);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // appointmentTestControl1
            // 
            this.appointmentTestControl1.Location = new System.Drawing.Point(12, 345);
            this.appointmentTestControl1.Name = "appointmentTestControl1";
            this.appointmentTestControl1.Size = new System.Drawing.Size(718, 258);
            this.appointmentTestControl1.TabIndex = 4;
            // 
            // applicationBasicInfoControl1
            // 
            this.applicationBasicInfoControl1.Location = new System.Drawing.Point(12, 191);
            this.applicationBasicInfoControl1.Name = "applicationBasicInfoControl1";
            this.applicationBasicInfoControl1.Size = new System.Drawing.Size(666, 164);
            this.applicationBasicInfoControl1.TabIndex = 3;
            // 
            // drivingLicenseApplicationInfoControl1
            // 
            this.drivingLicenseApplicationInfoControl1.Location = new System.Drawing.Point(12, 107);
            this.drivingLicenseApplicationInfoControl1.Name = "drivingLicenseApplicationInfoControl1";
            this.drivingLicenseApplicationInfoControl1.Size = new System.Drawing.Size(704, 112);
            this.drivingLicenseApplicationInfoControl1.TabIndex = 2;
            // 
            // frmVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 647);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.appointmentTestControl1);
            this.Controls.Add(this.applicationBasicInfoControl1);
            this.Controls.Add(this.drivingLicenseApplicationInfoControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmVisionTestAppointments";
            this.Text = "frmVisionTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DrivingLicenseApplicationInfoControl drivingLicenseApplicationInfoControl1;
        private ApplicationBasicInfoControl applicationBasicInfoControl1;
        private AppointmentTestControl appointmentTestControl1;
        private System.Windows.Forms.Button btnClose;
    }
}