namespace DVLD_Driving_License_Management
{
    partial class frmNewLDLApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.comboFilterby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabApplicationInfo = new System.Windows.Forms.TabPage();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.labelFees = new System.Windows.Forms.Label();
            this.comboLicenseClass = new System.Windows.Forms.ComboBox();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.labelApplicationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.showPersonInfoControl1 = new DVLD_Driving_License_Management.ShowPersonInfoControl();
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tabApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.btnSearch);
            this.tabPersonInfo.Controls.Add(this.tbFilter);
            this.tabPersonInfo.Controls.Add(this.comboFilterby);
            this.tabPersonInfo.Controls.Add(this.label2);
            this.tabPersonInfo.Controls.Add(this.showPersonInfoControl1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(840, 385);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "PersonInfo";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(733, 338);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 41);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(530, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(356, 59);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(158, 20);
            this.tbFilter.TabIndex = 13;
            this.tbFilter.Tag = "";
            // 
            // comboFilterby
            // 
            this.comboFilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterby.FormattingEnabled = true;
            this.comboFilterby.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.comboFilterby.Location = new System.Drawing.Point(145, 58);
            this.comboFilterby.Name = "comboFilterby";
            this.comboFilterby.Size = new System.Drawing.Size(205, 21);
            this.comboFilterby.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter by :";
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.Controls.Add(this.labelCreatedBy);
            this.tabApplicationInfo.Controls.Add(this.labelFees);
            this.tabApplicationInfo.Controls.Add(this.comboLicenseClass);
            this.tabApplicationInfo.Controls.Add(this.labelApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.labelApplicationID);
            this.tabApplicationInfo.Controls.Add(this.label7);
            this.tabApplicationInfo.Controls.Add(this.label6);
            this.tabApplicationInfo.Controls.Add(this.label5);
            this.tabApplicationInfo.Controls.Add(this.label4);
            this.tabApplicationInfo.Controls.Add(this.label3);
            this.tabApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationInfo.Size = new System.Drawing.Size(840, 385);
            this.tabApplicationInfo.TabIndex = 1;
            this.tabApplicationInfo.Text = "ApplicationInfo";
            this.tabApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(259, 311);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(31, 16);
            this.labelCreatedBy.TabIndex = 9;
            this.labelCreatedBy.Text = "???";
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.Location = new System.Drawing.Point(259, 240);
            this.labelFees.Name = "labelFees";
            this.labelFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFees.Size = new System.Drawing.Size(23, 16);
            this.labelFees.TabIndex = 8;
            this.labelFees.Text = "15";
            // 
            // comboLicenseClass
            // 
            this.comboLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLicenseClass.FormattingEnabled = true;
            this.comboLicenseClass.Location = new System.Drawing.Point(262, 168);
            this.comboLicenseClass.Name = "comboLicenseClass";
            this.comboLicenseClass.Size = new System.Drawing.Size(249, 21);
            this.comboLicenseClass.TabIndex = 7;
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationDate.Location = new System.Drawing.Point(259, 111);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(31, 16);
            this.labelApplicationDate.TabIndex = 6;
            this.labelApplicationDate.Text = "???";
            // 
            // labelApplicationID
            // 
            this.labelApplicationID.AutoSize = true;
            this.labelApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationID.Location = new System.Drawing.Point(259, 45);
            this.labelApplicationID.Name = "labelApplicationID";
            this.labelApplicationID.Size = new System.Drawing.Size(31, 16);
            this.labelApplicationID.TabIndex = 5;
            this.labelApplicationID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Created By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Application Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "License Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Application Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "D.L.Application ID :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(768, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(665, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // showPersonInfoControl1
            // 
            this.showPersonInfoControl1.Location = new System.Drawing.Point(3, 44);
            this.showPersonInfoControl1.Name = "showPersonInfoControl1";
            this.showPersonInfoControl1.Size = new System.Drawing.Size(848, 340);
            this.showPersonInfoControl1.TabIndex = 0;
            // 
            // frmNewLDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmNewLDLApplication";
            this.Text = "frmNewLDLApplication";
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabPersonInfo.PerformLayout();
            this.tabApplicationInfo.ResumeLayout(false);
            this.tabApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private ShowPersonInfoControl showPersonInfoControl1;
        private System.Windows.Forms.TabPage tabApplicationInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox comboFilterby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelApplicationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.ComboBox comboLicenseClass;
        private System.Windows.Forms.Label labelApplicationDate;
    }
}