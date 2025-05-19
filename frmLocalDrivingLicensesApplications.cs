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
    public partial class frmLocalDrivingLicensesApplications : Form
    {

        public frmLocalDrivingLicensesApplications()
        {
            InitializeComponent();
        }

        private int _UserID = 0;

        public frmLocalDrivingLicensesApplications(int UserID)
        {
            InitializeComponent();

            comboFilter.SelectedIndex = 0;

            _RefreshGridView();

            _UserID = UserID;

        }

        private void _RefreshGridView()
        {

            AllApplications = BusinessLayer.LDLApplicationsBusinessLayer.GetAllApplications();

            dataGridView1.DataSource = AllApplications;

        }

        private void _RefreshGridView(object sender, EventArgs e)
        {

            _RefreshGridView();

        }

        private void comboFilter_TextChanged(object sender, EventArgs e)
        {

            string colName = comboFilter.Text;

            if (!string.IsNullOrEmpty(colName) && dataGridView1.Columns.Contains(colName))
            {
                dataGridView1.Sort(dataGridView1.Columns[colName], ListSortDirection.Ascending);
            }


        }

        private DataTable AllApplications = new DataTable();

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            object search;

            if (tbFilter.Text.Length <= 0)
            {

                _RefreshGridView();

                return;
            }


            if (comboFilter.SelectedItem?.ToString() == "LocalDrivingLicenseApplicationID")
            {
                if (tbFilter.Text.Length > 0)
                {
                    char lastChar = tbFilter.Text[tbFilter.Text.Length - 1];

                    if (!char.IsDigit(lastChar))
                    {
                        tbFilter.Text = tbFilter.Text.Substring(0, tbFilter.Text.Length - 1);

                        tbFilter.SelectionStart = tbFilter.Text.Length;

                        return;
                    }
                }


                search = Convert.ToInt32(tbFilter.Text);

            }
            else
            {
                search = tbFilter.Text.ToString();
            }



            string columnName = comboFilter.SelectedItem.ToString();

            if (AllApplications != null && AllApplications.Columns.Contains(columnName))
            {
                DataView dv = new DataView(AllApplications);

                if (int.TryParse(search.ToString(), out int result) && (comboFilter.SelectedItem?.ToString() == "LocalDrivingLicenseApplicationID"))
                {
                    dv.RowFilter = $"{columnName} = {result}";

                }
                else
                {
                    dv.RowFilter = $"{columnName} LIKE '{search}%'";
                }

                dataGridView1.DataSource = dv;
            }
        }

        private void btnNewLicense_Click(object sender, EventArgs e)
        {

            
            frmNewLDLApplication frm = new frmNewLDLApplication(_UserID);
            frm.SomethingHappened += _RefreshGridView;
            frm.ShowDialog();

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                MessageBox.Show("Diese Application wurde schon Completed also sie konnen sie nicht Cancel");
                return;
            }else if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Diese Application wurde schon Cancelled also sie konnen sie nicht Cancel");
                return;
            }

            BusinessLayer.LDLApplicationsBusinessLayer.CancelTheApplication((int)dataGridView1.CurrentRow.Cells[0].Value);

            _RefreshGridView();

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessLayer.LDLApplicationsBusinessLayer.DeleteLokalApplication((int)dataGridView1.CurrentRow.Cells[0].Value);

            _RefreshGridView();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                MessageBox.Show("Diese Application wurde schon Completed also sie haben schon alle Test durchgefuhrt");
                return;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Diese Application wurde schon Cancelled also sie konnen nicht mehr weiter");
                return;
            }


            int ApplicationID = BusinessLayer.clsApplicationsLayer.GetApplicationIDByLokalApplicatoinID((int)dataGridView1.CurrentRow.Cells[0].Value);

            frmVisionTestAppointments frm = new frmVisionTestAppointments(ApplicationID , dataGridView1.CurrentRow.Cells[1].Value.ToString() , Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) , (int)dataGridView1.CurrentRow.Cells[0].Value , _UserID);
            frm.FormClosedEvent += _RefreshGridView;
            frm.ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;

            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {

                showApplicationDetailsToolStripMenuItem.Enabled=false;
                editApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;


            }

            if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "New" && Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) == 1)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

            }
            else if(dataGridView1.CurrentRow.Cells[6].Value.ToString() == "New" && Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) == 2)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

            }


        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {

            showApplicationDetailsToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = true;
            sechduleTestsToolStripMenuItem.Enabled = true;
            scheduleVisionTestToolStripMenuItem.Enabled = true;
            scheduleWrittenTestToolStripMenuItem.Enabled = true;
            scheduleStreetTestToolStripMenuItem.Enabled = true;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = true;

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                MessageBox.Show("Diese Application wurde schon Completed also sie haben schon alle Test durchgefuhrt");
                return;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Diese Application wurde schon Cancelled also sie konnen nicht mehr weiter");
                return;
            }


            int ApplicationID = BusinessLayer.clsApplicationsLayer.GetApplicationIDByLokalApplicatoinID((int)dataGridView1.CurrentRow.Cells[0].Value);

            frmWrittenTestAppointments frm = new frmWrittenTestAppointments(ApplicationID, dataGridView1.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value), (int)dataGridView1.CurrentRow.Cells[0].Value, _UserID);
            frm.FormClosedEvent += _RefreshGridView;
            frm.ShowDialog();


        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                MessageBox.Show("Diese Application wurde schon Completed also sie haben schon alle Test durchgefuhrt");
                return;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Diese Application wurde schon Cancelled also sie konnen nicht mehr weiter");
                return;
            }


            int ApplicationID = BusinessLayer.clsApplicationsLayer.GetApplicationIDByLokalApplicatoinID((int)dataGridView1.CurrentRow.Cells[0].Value);

            frmStreetTestsAppointments frm = new frmStreetTestsAppointments(ApplicationID, dataGridView1.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value), (int)dataGridView1.CurrentRow.Cells[0].Value, _UserID);
            frm.FormClosedEvent += _RefreshGridView;
            frm.ShowDialog();


        }
    



    }
}
