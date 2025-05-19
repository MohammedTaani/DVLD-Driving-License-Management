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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int _UserID = -1;
        private int _PersonID = -1;

        public Main(int UserID) {

            InitializeComponent();

            this._UserID = UserID;

            this._PersonID = clsUsersBusinessLayer.GetPersonID(this._UserID);


        }


        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManagePeopleForm ManagePeopleForm1 = new ManagePeopleForm();

            ManagePeopleForm1.ShowDialog();

            

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm1 = new frmManageUsers();
            frm1.ShowDialog();
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmShowUserDetails frm = new frmShowUserDetails(_UserID , _PersonID);

            frm.ShowDialog();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChangePassword frm = new frmChangePassword(_PersonID , _UserID);
            frm.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestsTypes frm = new frmManageTestsTypes();
            frm.ShowDialog();
        }

        private void localDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicensesApplications frm = new frmLocalDrivingLicensesApplications(_UserID);
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLDLApplication frm = new frmNewLDLApplication(_UserID);
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
        }
    }
}
