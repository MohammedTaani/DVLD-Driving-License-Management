using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Driving_License_Management
{
    public partial class frmShowUserDetails : Form
    {
        public frmShowUserDetails()
        {
            InitializeComponent();
        }


        public frmShowUserDetails(int UserID , int PersonID)
        {

            InitializeComponent();

            showPersonInfoControl1.GetPersonData(BusinessLayer.PeopleBusiness.FindPersonInfoByID(PersonID));

            showUserInformationControl1.GetUserInfo(BusinessLayer.clsUsersBusinessLayer.GetUserInfoByUserID(UserID));

        }
    }
}
