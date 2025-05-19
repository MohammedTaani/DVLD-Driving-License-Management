namespace DVLD_Driving_License_Management
{
    partial class frmAddNewUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.comboFilterby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showPersonInfoControl1 = new DVLD_Driving_License_Management.ShowPersonInfoControl();
            this.tabUserInfo = new System.Windows.Forms.TabPage();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbISActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tabUserInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 478);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.btnSave);
            this.tabPersonInfo.Controls.Add(this.btnSearch);
            this.tabPersonInfo.Controls.Add(this.btnAddNewPerson);
            this.tabPersonInfo.Controls.Add(this.tbFilter);
            this.tabPersonInfo.Controls.Add(this.comboFilterby);
            this.tabPersonInfo.Controls.Add(this.label2);
            this.tabPersonInfo.Controls.Add(this.showPersonInfoControl1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(783, 452);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "PersonInfo";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(702, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(535, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(636, 54);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(105, 23);
            this.btnAddNewPerson.TabIndex = 9;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(361, 54);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(158, 20);
            this.tbFilter.TabIndex = 8;
            this.tbFilter.Tag = "";
            // 
            // comboFilterby
            // 
            this.comboFilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterby.FormattingEnabled = true;
            this.comboFilterby.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.comboFilterby.Location = new System.Drawing.Point(150, 53);
            this.comboFilterby.Name = "comboFilterby";
            this.comboFilterby.Size = new System.Drawing.Size(205, 21);
            this.comboFilterby.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter by :";
            // 
            // showPersonInfoControl1
            // 
            this.showPersonInfoControl1.Location = new System.Drawing.Point(6, 77);
            this.showPersonInfoControl1.Name = "showPersonInfoControl1";
            this.showPersonInfoControl1.Size = new System.Drawing.Size(735, 320);
            this.showPersonInfoControl1.TabIndex = 1;
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.Controls.Add(this.btnSave2);
            this.tabUserInfo.Controls.Add(this.label6);
            this.tabUserInfo.Controls.Add(this.label5);
            this.tabUserInfo.Controls.Add(this.label4);
            this.tabUserInfo.Controls.Add(this.label3);
            this.tabUserInfo.Controls.Add(this.chkbISActive);
            this.tabUserInfo.Controls.Add(this.tbConfirmPassword);
            this.tabUserInfo.Controls.Add(this.tbPassword);
            this.tabUserInfo.Controls.Add(this.tbUserName);
            this.tabUserInfo.Controls.Add(this.tbUserID);
            this.tabUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserInfo.Size = new System.Drawing.Size(783, 452);
            this.tabUserInfo.TabIndex = 1;
            this.tabUserInfo.Text = "UserInfo";
            this.tabUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(702, 423);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 9;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confim Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID";
            // 
            // chkbISActive
            // 
            this.chkbISActive.AutoSize = true;
            this.chkbISActive.Checked = true;
            this.chkbISActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbISActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbISActive.Location = new System.Drawing.Point(206, 275);
            this.chkbISActive.Name = "chkbISActive";
            this.chkbISActive.Size = new System.Drawing.Size(85, 20);
            this.chkbISActive.TabIndex = 4;
            this.chkbISActive.Text = "Is Active";
            this.chkbISActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(215, 220);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(191, 20);
            this.tbConfirmPassword.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(215, 174);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(215, 128);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(191, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // tbUserID
            // 
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(215, 76);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(191, 20);
            this.tbUserID.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabPersonInfo.PerformLayout();
            this.tabUserInfo.ResumeLayout(false);
            this.tabUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShowPersonInfoControl showPersonInfoControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabUserInfo;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox comboFilterby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbISActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}