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
    public partial class frmNewLDLApplication : Form
    {


        public frmNewLDLApplication()
        {

            InitializeComponent();



        }

        private int _UserID = -1;

        public frmNewLDLApplication(int UserID)
        {
            InitializeComponent();

            comboFilterby.SelectedIndex = 0;

            labelApplicationDate.Text = DateTime.Now.ToString();

            _GetAllApplicationClasses();

            labelCreatedBy.Text = BusinessLayer.clsUsersBusinessLayer.GetUserNameByUserID(UserID);

            _UserID = UserID;

        }

        private void _GetAllApplicationClasses()
        {

            DataTable dt = BusinessLayer.LDLApplicationsBusinessLayer.GetAllLicenseClasses();

            foreach (DataRow row in dt.Rows)
            {
                comboLicenseClass.Items.Add(row["ClassName"].ToString());
            }

            comboLicenseClass.SelectedIndex = 0;

        }

        public event EventHandler SomethingHappened;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbFilter.Text.Length == 0)
            {

                return;

            }


            if (comboFilterby.SelectedItem.ToString() == "PersonID")
            {


                if (int.TryParse(tbFilter.Text, out int PersonID))
                {


                    if (BusinessLayer.PeopleBusiness.IstPersonExistByPersonID(PersonID))
                    {
                        showPersonInfoControl1.GetPersonData(PeopleBusiness.FindPersonInfoByID(PersonID));
                    }
                    else
                    {
                        MessageBox.Show("Person existiert nicht!!! , sie haben vielleicht etwas flash getippt");
                    }

                }
                else
                {
                    MessageBox.Show("Person ID muss ein Nummer sein also kein Buchstaben");
                }


            }
            else
            {

                if (BusinessLayer.PeopleBusiness.IstPersonExistByNationalNo(tbFilter.Text.ToString()))
                {
                    showPersonInfoControl1.GetPersonData(PeopleBusiness.FindPersonInfoByNoationalNo(tbFilter.Text.ToString()));
                }
                else
                {
                    MessageBox.Show("Person existiert nicht!!! , sie haben vielleicht etwas flash getippt");
                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Sind Sie Sicher ? " , "" , MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {

                return;

            }


            if(showPersonInfoControl1.GetPersonID() < 1)
            {
                MessageBox.Show("Person existiert nicht");
                return;
            }

            int LicenseClassID = comboLicenseClass.SelectedIndex + 1;

            int ApplicationID = BusinessLayer.clsApplicationsLayer.IstApplicationDa(showPersonInfoControl1.GetPersonID(), LicenseClassID);

            if(ApplicationID != -1)
            {

                MessageBox.Show("Dieser Application ist in DataBase unter ID : " + ApplicationID + " , Also sie konnen nicht new Application hinzufugen");

                return;

            }

            // New Application but not new Local Application hier general Application

            BusinessLayer.clsApplicationsLayer NewApplication = new BusinessLayer.clsApplicationsLayer();

            NewApplication.userID = _UserID;
            NewApplication.PersonID = showPersonInfoControl1.GetPersonID();
            NewApplication.ApplicationTypeID = 1; // New ApplicationType ID is 1 in DataBase
            NewApplication.LastStatusDate = Convert.ToDateTime(labelApplicationDate.Text);
            NewApplication.ApplicationDate = Convert.ToDateTime(labelApplicationDate.Text);


            if (!NewApplication.Save())
            {
                MessageBox.Show("Es gibt ein Fehler.");

                return;
            }


            // Jetzt beginnt die neue Lokale Application zu generieren


            if (BusinessLayer.LDLApplicationsBusinessLayer.SaveNewLocalApplication(NewApplication.ApplicationID , LicenseClassID) == -1)
            {

                MessageBox.Show("New Lokale Application wurde nicht gespeichert . Es gibt ein Fehler");


            }
            else
            {
                MessageBox.Show("Es wurde eine lokale Application erfolgreich gespeichert.");
            }


            if (SomethingHappened != null)
            {

                SomethingHappened?.Invoke(this, EventArgs.Empty);

            }

            this.Close();


        }
    

    
    }
}
