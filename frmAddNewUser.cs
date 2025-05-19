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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();

            comboFilterby.SelectedIndex = 0;

        }

        private void Get_PersonId(object sender, int PersonID)
        {

            showPersonInfoControl1.GetPersonData(BusinessLayer.PeopleBusiness.FindPersonInfoByID(PersonID));
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {

            // Hier true weil wir die Info von der Person bringen wollen
            // aber ohne true wird DataBack null sein
            AddNewPersonForm frm = new AddNewPersonForm(true);
            frm.DataBack += Get_PersonId;
            frm.ShowDialog();

        }

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

        public event EventHandler SomethingHappened;
        private void btnSave2_Click(object sender, EventArgs e)
        {

            if (!showPersonInfoControl1.IstAlleLuckenGefullt())
            {

                MessageBox.Show("Falsch fugen sie zuerst ein Person hinzu , um ein User zu erstellen");

                return;
            }else if(tbUserName.Text.ToString() == "" || tbPassword.Text.ToString() == "" || tbConfirmPassword.Text.ToString() == "")
            {
                MessageBox.Show("Fullen sie bitte alle Lucken!!!");
                return;
            }
            else if (tbPassword.Text.ToString() != tbConfirmPassword.Text.ToString())
            {

                MessageBox.Show("Die Passworter sind nicht gleich");

                return;
            }

            clsUsersBusinessLayer newUser = new clsUsersBusinessLayer();

            newUser.UserName = tbUserName.Text.ToString();
            newUser.Password = tbPassword.Text.ToString();
            newUser.PersonID = showPersonInfoControl1.GetPersonID();
            newUser.IsActive = (chkbISActive.Checked ? true : false);

            if (newUser.Save())
            {
                MessageBox.Show("New User wurde erfolgreich hinzugefugt");

                this.Close();

            }
            else
            {
                MessageBox.Show("Etwas Falsch , User wurde nicht hinzugefugt");
            }

            if (SomethingHappened != null)
            {

                SomethingHappened?.Invoke(this, EventArgs.Empty);

            }

        }
    


    
    }

}
