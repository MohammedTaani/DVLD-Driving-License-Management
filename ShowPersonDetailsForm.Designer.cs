namespace DVLD_Driving_License_Management
{
    partial class ShowPersonDetailsForm
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
            this.SuspendLayout();
            // 
            // showPersonInfoControl1
            // 
            this.showPersonInfoControl1.Location = new System.Drawing.Point(12, 84);
            this.showPersonInfoControl1.Name = "showPersonInfoControl1";
            this.showPersonInfoControl1.Size = new System.Drawing.Size(787, 354);
            this.showPersonInfoControl1.TabIndex = 0;
            this.showPersonInfoControl1.Load += new System.EventHandler(this.showPersonInfoControl1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(213, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // ShowPersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPersonInfoControl1);
            this.Name = "ShowPersonDetailsForm";
            this.Text = "ShowPersonDetailsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowPersonDetailsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowPersonInfoControl showPersonInfoControl1;
        private System.Windows.Forms.Label label1;
    }
}