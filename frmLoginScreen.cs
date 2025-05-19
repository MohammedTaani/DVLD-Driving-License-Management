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
    public partial class frmLoginScreen : Form
    {

        public frmLoginScreen()
        {
            InitializeComponent();

            string UserName = "";
            string Password = "";

            clsUsersBusinessLayer.GetUserInfoVonFile(ref UserName, ref Password);

            tbUserName.Text = UserName;
            tbPassword.Text = Password;



        }

        private int _LoginVersuche = 3;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(tbUserName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Sie haben UserName oder Password nicht geschrieben (-_-) ");

                return;
            }


            int UserID = clsUsersBusinessLayer.CheckLoginUser(tbUserName.Text, tbPassword.Text);

            if (UserID == -1)
            {

                MessageBox.Show("Sie haben UserName oder Password falsch geschrieben. Sie haben noch " + (_LoginVersuche - 1) + " Versuche");

                _LoginVersuche--;

                if(_LoginVersuche == 0)
                {

                    MessageBox.Show("Sie haben 3 mal versucht. Sie konnen leider nicht mehr");

                    this.Close();

                }

                return;

            }
            else
            {


                if (chkboxButton.Checked)
                {

                    clsUsersBusinessLayer.SaveCurrentUserLoginInfoInFile(tbUserName.Text , tbPassword.Text);

                }
                else
                {
                    clsUsersBusinessLayer.SaveCurrentUserLoginInfoInFile("", "");

                }

                Main frm = new Main(UserID);

                frm.ShowDialog();

            }

                

        }
    


    
    }
}
