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
    public partial class frmStreetTestsAppointments : Form
    {
        public frmStreetTestsAppointments()
        {
            InitializeComponent();
        }


        public frmStreetTestsAppointments(int ApplicationID, string ClassName, int PassedTests, int LokalApplicationID, int UserID)
        {

            InitializeComponent();

            drivingLicenseApplicationInfoControl1.AusFullenAlleLucken(ApplicationID, ClassName, PassedTests);

            applicationBasicInfoControl1.AusFullenAlleLucken(LokalApplicationID);

            // Street Test hat nummer 3 in DataBase

            appointmentTestControl1.LoadData(ApplicationID, 3, UserID);

        }

        public event Action FormClosedEvent;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            FormClosedEvent?.Invoke();
        }


    }
}
