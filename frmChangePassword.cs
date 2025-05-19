using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Driving_License_Management
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private string _CurrentPasswordVonDataBase = "";
        private int _UserID = 0;

        public frmChangePassword(int PersonID , int UserID)
        {
            InitializeComponent();

            showPersonInfoControl1.GetPersonData(BusinessLayer.PeopleBusiness.FindPersonInfoByID(PersonID));

            showUserInformationControl1.GetUserInfo(clsUsersBusinessLayer.GetUserInfoByUserID(UserID));

            _CurrentPasswordVonDataBase = clsUsersBusinessLayer.GetCurrentPasswordVonDB(UserID);

            _UserID = UserID;

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_CurrentPasswordVonDataBase != tbCurrentPassword.Text)
            {

                MessageBox.Show("Current Password ist falsch");

                tbCurrentPassword.Text = "";

                tbCurrentPassword.Focus();

                return;

            }

            if(tbNewPassword.Text == "")
            {
                return;
            }

            if( tbCurrentPassword.Text == tbNewPassword.Text)
            {
                MessageBox.Show("Sie haben den Password nicht geandert . Es ist die gleiche");

                return;
            }

            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {

                MessageBox.Show("New Password und ihre confirmation sind nicht gleich");

                tbConfirmPassword.Text = "";

                tbConfirmPassword.Focus();

                return;


            }

            if (clsUsersBusinessLayer.SaveNewPassword(_UserID, tbNewPassword.Text))
            {

                MessageBox.Show("Password wurde erfolgreich geandert");

                this.Close();

            }
            else
            {

                MessageBox.Show("Password wurde nicht erfolgreich geandert  :( !!!");

            }


        }



    }
}
