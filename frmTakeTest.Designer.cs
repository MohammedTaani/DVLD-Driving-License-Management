namespace DVLD_Driving_License_Management
{
    partial class frmTakeTest
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
            this.appointmentsTestsControl1 = new DVLD_Driving_License_Management.AppointmentsTestsControl();
            this.labelTestTypeName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbPass = new System.Windows.Forms.RadioButton();
            this.rdbFall = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentsTestsControl1
            // 
            this.appointmentsTestsControl1.Location = new System.Drawing.Point(12, 50);
            this.appointmentsTestsControl1.Name = "appointmentsTestsControl1";
            this.appointmentsTestsControl1.Size = new System.Drawing.Size(488, 254);
            this.appointmentsTestsControl1.TabIndex = 0;
            // 
            // labelTestTypeName
            // 
            this.labelTestTypeName.AutoSize = true;
            this.labelTestTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestTypeName.Location = new System.Drawing.Point(211, 9);
            this.labelTestTypeName.Name = "labelTestTypeName";
            this.labelTestTypeName.Size = new System.Drawing.Size(62, 31);
            this.labelTestTypeName.TabIndex = 1;
            this.labelTestTypeName.Text = "???";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbPass
            // 
            this.rdbPass.AutoSize = true;
            this.rdbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPass.Location = new System.Drawing.Point(84, 24);
            this.rdbPass.Name = "rdbPass";
            this.rdbPass.Size = new System.Drawing.Size(72, 28);
            this.rdbPass.TabIndex = 3;
            this.rdbPass.TabStop = true;
            this.rdbPass.Text = "Pass";
            this.rdbPass.UseVisualStyleBackColor = true;
            // 
            // rdbFall
            // 
            this.rdbFall.AutoSize = true;
            this.rdbFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFall.Location = new System.Drawing.Point(285, 24);
            this.rdbFall.Name = "rdbFall";
            this.rdbFall.Size = new System.Drawing.Size(62, 28);
            this.rdbFall.TabIndex = 4;
            this.rdbFall.TabStop = true;
            this.rdbFall.Text = "Fall";
            this.rdbFall.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Controls.Add(this.rdbPass);
            this.result.Controls.Add(this.rdbFall);
            this.result.Location = new System.Drawing.Point(12, 310);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(488, 71);
            this.result.TabIndex = 5;
            this.result.TabStop = false;
            this.result.Text = "Result";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(12, 422);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(488, 118);
            this.tbNotes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notes:";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTestTypeName);
            this.Controls.Add(this.appointmentsTestsControl1);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppointmentsTestsControl appointmentsTestsControl1;
        private System.Windows.Forms.Label labelTestTypeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbPass;
        private System.Windows.Forms.RadioButton rdbFall;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label1;
    }
}