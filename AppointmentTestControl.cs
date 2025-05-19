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
    public partial class AppointmentTestControl : UserControl
    {
        public AppointmentTestControl()
        {
            InitializeComponent();
        }

        private int _ApplicationID = 0;
        private int _TestTypeID = 0;
        private int _UserID = 0;
        private bool _TestResult = false;

        public AppointmentTestControl(int ApplicationID, int TestTypeID) {

            InitializeComponent();

            _ApplicationID = ApplicationID;
            _TestTypeID = TestTypeID;

            _RefreshGridView();


        }


        public void LoadData(int ApplicationID , int TestTypeID , int UserID)
        {

            _ApplicationID = ApplicationID;
            _TestTypeID = TestTypeID;

            _UserID = UserID;

            _RefreshGridView();

        }

        private void _RefreshGridView()
        {

            dataGridView1.DataSource = BusinessLayer.clsTestsAppointmentsBusinessLayer.GetTestAppointment(_ApplicationID , _TestTypeID);

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {

            if (_TestResult)
            {
                MessageBox.Show("Dieser Person hat schon diese Prufung bestanden");

                return;

            }
            else
            {


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Sicherstellen, dass es keine leere "NewRow" ist
                    if (!row.IsNewRow)
                    {
                        object zellenwert = row.Cells[0].Value;

                        if (int.TryParse(zellenwert?.ToString(), out int AppointmentID))
                        {

                            if (BusinessLayer.clsTestsBusinessLayer.HatErPrufungBestandenByAppointmentID(AppointmentID))
                            {
                                MessageBox.Show("Dieser Person hat schon diese Prufung bestanden");
                                return;
                            }

                        }


                    }

                }



            }

            if (dataGridView1.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    bool isChecked = Convert.ToBoolean(row.Cells[3].Value);

                    if (!isChecked)
                    {
                        MessageBox.Show("Dieser Person hat noch einen Termin");
                        return;
                    }

                }

            }


            string TestTypeName = "";

            if (_TestTypeID == 1)
            {
                TestTypeName = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                TestTypeName = "Written Test";
            }
            else if (_TestTypeID == 3)
            {
                TestTypeName = "Practical Test";
            }

            frmScheduleTestAppointment frm = new frmScheduleTestAppointment(_ApplicationID, _TestTypeID, TestTypeName, _UserID);

            frm.ShowDialog();


            _RefreshGridView();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_TestResult)
            {
                MessageBox.Show("Dieser Person hat schon diese Prufung bestanden");

                return;

            }
            else
            {

                if ((bool)dataGridView1.CurrentRow.Cells[3].Value)
                {
                    MessageBox.Show("Dieser Person hat diese Prufung schon gemacht also sie konnen es nicht andern");

                    return;
                }

            }

            string TestTypeName = "";

            if (_TestTypeID == 1)
            {
                TestTypeName = "Edit Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                TestTypeName = "Edit Written Test";
            }
            else if (_TestTypeID == 3)
            {
                TestTypeName = "Edit Practical Test";
            }

            frmScheduleTestAppointment frm = new frmScheduleTestAppointment();

            frm._LoadDataToUpdate((int)dataGridView1.CurrentRow.Cells[0].Value);

            frm.ShowDialog();


            _RefreshGridView();


        }

        private void TestGenommen(object sender, bool Result)
        {

            _TestResult = Result;

            int letzteZeilenIndex = dataGridView1.AllowUserToAddRows ? dataGridView1.Rows.Count - 2 : dataGridView1.Rows.Count - 1;

            // Zugriff auf Zelle in Spalte 0 der letzten Zeile
            int TestAppointmentID = (int)dataGridView1.Rows[letzteZeilenIndex].Cells[0].Value;



            if (BusinessLayer.clsTestsAppointmentsBusinessLayer.LockTheAppointment(TestAppointmentID)) {

                _RefreshGridView();

            }



        }

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if ((bool)dataGridView1.CurrentRow.Cells[3].Value)
            {

                MessageBox.Show("Sie haben dieser Prufung schon gemacht");

                return;

            }



            string TestTypeName = "";

            if (_TestTypeID == 1)
            {
                TestTypeName = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                TestTypeName = "Written Test";
            }
            else if (_TestTypeID == 3)
            {
                TestTypeName = "Practical Test";
            }

            frmTakeTest frm = new frmTakeTest(_ApplicationID , _TestTypeID , (int)dataGridView1.CurrentRow.Cells[0].Value , _UserID , TestTypeName , (DateTime)dataGridView1.CurrentRow.Cells[1].Value);

            frm.DataBack += TestGenommen;

            frm.ShowDialog();

        }



    }
}
