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
    public partial class frmTakeTest : Form
    {
        public frmTakeTest()
        {
            InitializeComponent();
        }

        int _TestAppointmentID = 0;
        int _CreatedByUserID = 0;


        public delegate void DataBackEventHandler(object sender, bool Result);

        public event DataBackEventHandler DataBack;

        public frmTakeTest(int ApplicationID, int TestTypeID, int TestAppointmentID, int CreatedByUserID , string TestTypeName , DateTime Date)
        {

            InitializeComponent();

            labelTestTypeName.Text = TestTypeName;

            appointmentsTestsControl1.LoadData(ApplicationID, TestTypeID);

            appointmentsTestsControl1.SetTestDate(Date);

            _TestAppointmentID = TestAppointmentID;
            _CreatedByUserID = CreatedByUserID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (rdbPass.Checked == false && rdbFall.Checked == false)
            {

                MessageBox.Show("Hat er durchgefallen oder noch nicht !!!");

            }


            if (tbNotes.Text.Length == 0)
            {
                tbNotes.Text = "";
            }

            int TestID = BusinessLayer.clsTestsBusinessLayer.AddNewTestResult(_TestAppointmentID, rdbPass.Checked, tbNotes.Text, _CreatedByUserID);


            if (TestID == -1)
            {

                MessageBox.Show("Error , Test Result wurde nicht gespeichert!!!");

            }
            else
            {

                MessageBox.Show("Test Result wurde erfolgreich gespeichert");



                if(DataBack != null)
                {

                    if (TestID != -1)
                    {

                        if (rdbPass.Checked)
                        {
                            DataBack?.Invoke(this, true);
                        }
                        else
                        {
                            DataBack?.Invoke(this, false);
                        }

                    }
                    else
                    {
                        DataBack?.Invoke(this, false);
                    }


                }

            }

            this.Close();

        }
    


    }
}
