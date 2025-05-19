namespace DVLD_Driving_License_Management
{
    partial class frmScheduleTestAppointment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.labelTestType = new System.Windows.Forms.Label();
            this.appointmentsTestsControl1 = new DVLD_Driving_License_Management.AppointmentsTestsControl();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelTestType
            // 
            this.labelTestType.AutoSize = true;
            this.labelTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestType.ForeColor = System.Drawing.Color.Red;
            this.labelTestType.Location = new System.Drawing.Point(154, 28);
            this.labelTestType.Name = "labelTestType";
            this.labelTestType.Size = new System.Drawing.Size(43, 24);
            this.labelTestType.TabIndex = 2;
            this.labelTestType.Text = "???";
            // 
            // appointmentsTestsControl1
            // 
            this.appointmentsTestsControl1.Location = new System.Drawing.Point(12, 69);
            this.appointmentsTestsControl1.Name = "appointmentsTestsControl1";
            this.appointmentsTestsControl1.Size = new System.Drawing.Size(395, 254);
            this.appointmentsTestsControl1.TabIndex = 0;
            // 
            // frmScheduleTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 505);
            this.Controls.Add(this.labelTestType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.appointmentsTestsControl1);
            this.Name = "frmScheduleTestAppointment";
            this.Text = "frmScheduleTestAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppointmentsTestsControl appointmentsTestsControl1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelTestType;
    }
}