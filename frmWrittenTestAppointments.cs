using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Driving_License_Management
{
    public partial class frmWrittenTestAppointments : Form
    {
        public frmWrittenTestAppointments()
        {
            InitializeComponent();
        }

        public event Action FormClosedEvent;

        public frmWrittenTestAppointments(int ApplicationID, string ClassName, int PassedTests, int LokalApplicationID, int UserID) {
            
            InitializeComponent();

            drivingLicenseApplicationInfoControl1.AusFullenAlleLucken(ApplicationID, ClassName, PassedTests);

            applicationBasicInfoControl1.AusFullenAlleLucken(LokalApplicationID);

            // Written Test hat nummer 2 in DataBase

            appointmentTestControl1.LoadData(ApplicationID, 2, UserID);

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            FormClosedEvent?.Invoke();

        }


    }
}
