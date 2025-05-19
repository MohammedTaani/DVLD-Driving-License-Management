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
    public partial class ShowUserInformationControl : UserControl
    {
        public ShowUserInformationControl()
        {
            InitializeComponent();
        }


        public void GetUserInfo(clsUsersBusinessLayer newUser)
        {
            
            tbUserID.Text = newUser.UserID.ToString();
            tbUserID.ReadOnly = true;
            tbUserName.Text = newUser.UserName.ToString();
            tbUserName.ReadOnly = true;
            chkBoxIsAcitve.Checked = newUser.IsActive;
            chkBoxIsAcitve.AutoCheck = false;
        }

    }
}
