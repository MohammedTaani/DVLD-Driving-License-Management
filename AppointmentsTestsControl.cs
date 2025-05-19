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
    public partial class AppointmentsTestsControl : UserControl
    {
        public AppointmentsTestsControl()
        {
            InitializeComponent();

            //dtpDate.MinDate = DateTime.Now;

        }


        public void LoadData(int ApplicationID , int TestTypeID)
        {

            string DrivingClass = "";
            string Name = "";
            int Trial = 0;
            int Fees = 0;

            if(BusinessLayer.clsTestsAppointmentsBusinessLayer.GetDataToScheduleTest(ApplicationID, TestTypeID, ref DrivingClass, ref Name, ref Trial, ref Fees))
            {

                labelID.Text = ApplicationID.ToString();
                labelName.Text = Name.ToString();
                labelFees.Text = Fees.ToString();
                labelClass.Text = DrivingClass.ToString();
                labelTrial.Text = Trial.ToString();

            }


        }

        public DateTime GetTestDate()
        {
            return dtpDate.Value;
        }

        public int GetPaidFees()
        {
            return Convert.ToInt32(labelFees.Text);
        }

        public void SetTestDate(DateTime testDate)
        {
            dtpDate.Value = testDate;
        }


    }
}
