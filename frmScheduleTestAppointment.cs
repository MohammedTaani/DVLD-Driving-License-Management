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
    public partial class frmScheduleTestAppointment : Form
    {
        public frmScheduleTestAppointment()
        {
            InitializeComponent();

        }

        private int _TestTypeID = 0;
        private int _LokalDrivingLicense = 0;
        private bool _isLocked = false;
        private int _CreatedByUserID = 0;


        private BusinessLayer.clsTestsAppointmentsBusinessLayer Test;
        private bool _ToUpdate = false;

        public frmScheduleTestAppointment(int ApplicationID, int TestTypeID, string TestTypeName, int CreatedByUserID)
        {

            InitializeComponent();

            appointmentsTestsControl1.LoadData(ApplicationID, TestTypeID);

            labelTestType.Text = TestTypeName;

            _TestTypeID = TestTypeID;

            _CreatedByUserID = CreatedByUserID;

            _LokalDrivingLicense = BusinessLayer.LDLApplicationsBusinessLayer.GetLokalApplicationIDByApplicationID(ApplicationID);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DateTime TestDate = appointmentsTestsControl1.GetTestDate();

            if (_ToUpdate)
            {

                Test.AppointmentDate = TestDate;

                if (Test.Save())
                {
                    MessageBox.Show("Test Appointment wurde erflogreich aktualisiert");
                }
                else
                {
                    MessageBox.Show("Error");
                }



            }
            else
            {

                int PaidFees = appointmentsTestsControl1.GetPaidFees();

                BusinessLayer.clsTestsAppointmentsBusinessLayer NewTestAppointment = new clsTestsAppointmentsBusinessLayer();

                NewTestAppointment.TestTypeID = _TestTypeID;
                NewTestAppointment.LokalDrivingLicenseApplicationID = _LokalDrivingLicense;
                NewTestAppointment.AppointmentDate = TestDate;
                NewTestAppointment.PaidFees = PaidFees;
                NewTestAppointment.CreatedByUserID = _CreatedByUserID;
                NewTestAppointment.IsLocked = false;

                if (NewTestAppointment.Save())
                {
                    MessageBox.Show("Test Appointment wurde erfolgreich gespeichert");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }

            this.Close();

        }
    
        public void _LoadDataToUpdate(int TestAppointment)
        {


            Test = BusinessLayer.clsTestsAppointmentsBusinessLayer.GetDataToUpdate(TestAppointment);

            int ApplicationID = BusinessLayer.clsApplicationsLayer.GetApplicationIDByLokalApplicatoinID(Test.LokalDrivingLicenseApplicationID);
            appointmentsTestsControl1.LoadData(ApplicationID, Test.TestTypeID);
            appointmentsTestsControl1.SetTestDate(Test.AppointmentDate);


            _ToUpdate = true;

        }


    }
}
