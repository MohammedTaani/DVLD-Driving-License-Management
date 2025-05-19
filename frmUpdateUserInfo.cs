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
    public partial class frmUpdateUserInfo : Form
    {
        public frmUpdateUserInfo()
        {
            InitializeComponent();
        }

        public frmUpdateUserInfo(int UserID , int PersonID)
        {

            InitializeComponent();

            _LoadUserData(UserID , PersonID);

        }

        public event EventHandler SomethingHappened;

        private int _UserID;
        private bool _ToUpdate = false;

        private void _LoadUserData(int UserID , int PersonID)
        {

            clsUsersBusinessLayer UserInfo = clsUsersBusinessLayer.GetUserInfoToUpdate(UserID);

            if(UserInfo == null)
            {
                MessageBox.Show("User wurde nicht gefunden , etwas falsch");
            }

            tbUserID.Text = UserID.ToString();
            tbUserName.Text = UserInfo.UserName.ToString();
            tbPassword.Text = UserInfo.Password.ToString();
            tbConfirmPassword.Text = UserInfo.Password.ToString();
            chkbISActive.Checked = UserInfo.IsActive;

            this._UserID = UserID;
            this._ToUpdate = true;

            showPersonInfoControl1.GetPersonData(BusinessLayer.PeopleBusiness.FindPersonInfoByID(PersonID));


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!showPersonInfoControl1.IstAlleLuckenGefullt())
            {

                MessageBox.Show("Falsch fugen sie zuerst ein Person hinzu , um ein User zu erstellen");

                return;
            }
            else if (tbUserName.Text.ToString() == "" || tbPassword.Text.ToString() == "" || tbConfirmPassword.Text.ToString() == "")
            {
                MessageBox.Show("Fullen sie bitte alle Lucken!!!");
                return;
            }
            else if (tbPassword.Text.ToString() != tbConfirmPassword.Text.ToString())
            {

                MessageBox.Show("Die Passworter sind nicht gleich");

                return;
            }



            clsUsersBusinessLayer User = new clsUsersBusinessLayer();

            if (_ToUpdate)
            {

                User = clsUsersBusinessLayer.GetUserInfoToUpdate(_UserID);

            }


            User.UserName = tbUserName.Text.ToString();
            User.Password = tbPassword.Text.ToString();
            User.PersonID = showPersonInfoControl1.GetPersonID();
            User.IsActive = (chkbISActive.Checked ? true : false);






            if (User.Save())
            {
                MessageBox.Show("New User wurde erfolgreich hinzugefugt");

                this.Close();

            }
            else
            {
                MessageBox.Show("Etwas Falsch , User wurde nicht hinzugefugt");
            }

            if (SomethingHappened != null)
            {

                SomethingHappened?.Invoke(this, EventArgs.Empty);

            }

        }
    

    
    }
}
