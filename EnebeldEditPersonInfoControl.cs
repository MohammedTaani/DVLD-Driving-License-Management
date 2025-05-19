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
using System.IO;

namespace DVLD_Driving_License_Management
{
    public partial class EnebeldEditPersonInfoControl : UserControl
    {

        // New Person Form Constructor1
        public EnebeldEditPersonInfoControl()
        {
            InitializeComponent();

            _LoadAllCountries();

            comboCountries.SelectedIndex = 0;


            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);


        }


        // To Update Form Constructor2
        public EnebeldEditPersonInfoControl(int PersonID)
        {
            InitializeComponent();

            _LoadAllCountries();

            _LoadDataToUpdate(PersonID);

        }

        public event EventHandler SomethingHappened;


        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        private void _LoadAllCountries()
        {

            DataTable dt = CountriesBusiness.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                comboCountries.Items.Add(row["CountryName"].ToString());
            }


        }

        private bool _CheckIfAllesRichtig()
        {

            bool istEtwasFalsch = false;

            if (tbNationalNo.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAddress.Text == "")
            {
                istEtwasFalsch = true;
            }
            else if (tbFirstName.Text == "" || tbLastName.Text == "")
            {
                istEtwasFalsch = true;
            }
            else if (tbSecondName.Text == "" || tbThirdName.Text == "")
            {
                istEtwasFalsch = true;
            }


            if (istEtwasFalsch)
            {

                MessageBox.Show("Fullen sie alle Lucken aus!");


            }

            return istEtwasFalsch;


        }


        PeopleBusiness _NewPerson = new PeopleBusiness();

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_CheckIfAllesRichtig())
            {
                return;
            }

            if (int.TryParse(tbPhone.Text , out int result))
            {
                _NewPerson.Phone = result.ToString();
            }
            else
            {
                MessageBox.Show("Ihre Phone Nummer ist falsch . sie sollen nur Nummer schreiben und keine Buchstanben");
                return;
            }

            if (rbMale.Checked || rdFemale.Checked)
            {
                if (rbMale.Checked)
                    _NewPerson.Gendor = false;
                else
                    _NewPerson.Gendor = true;
            }
            else
            {
                MessageBox.Show("Sie haben vergessen , ihre Gendor zu wahlen");
                return;
            }


            _NewPerson.NationalNo = tbNationalNo.Text;
            _NewPerson.Email = tbEmail.Text;
            _NewPerson.Address = tbAddress.Text;
            _NewPerson.FirstName = tbFirstName.Text;
            _NewPerson.SecondName = tbSecondName.Text;
            _NewPerson.ThirdName = tbThirdName.Text;
            _NewPerson.LastName = tbLastName.Text;
            _NewPerson.CountryNationalID = (short)CountriesBusiness.FindCountryIDByName(comboCountries.SelectedItem.ToString());
            _NewPerson.DateOfBirth = (DateTime)dtpDateOfBirth.Value;

            if (pictureBox1.ImageLocation != null)
                _NewPerson.ImagePath = pictureBox1.ImageLocation;
            else
                _NewPerson.ImagePath = "";


            if (_NewPerson.Save())
            {
                MessageBox.Show("Person Information wurde erfolgreich gespeichert");


                if (DataBack != null)
                {
                    DataBack?.Invoke(this, _NewPerson.PersonID);
                }

                SomethingHappened?.Invoke(this, EventArgs.Empty);





                //refresch list and close the form one deleget with tow forms waitings the event

            }
            else
            {
                MessageBox.Show("Etwas falsch");
            }



        }

        public void _LoadDataToUpdate(int PersonID)
        {

            _NewPerson = PeopleBusiness.FindPersonInfoByID(PersonID);

            tbPersonID.Text = _NewPerson.PersonID.ToString();
            tbFirstName.Text = _NewPerson.FirstName.ToString();
            tbSecondName.Text = _NewPerson.SecondName.ToString();
            tbThirdName.Text = _NewPerson.ThirdName.ToString();
            tbLastName.Text = _NewPerson.LastName.ToString();
            tbNationalNo.Text = _NewPerson.NationalNo.ToString();
            tbNationalNo.Enabled = false;
            tbEmail.Text = _NewPerson.Email.ToString();
            tbAddress.Text = _NewPerson.Address.ToString();
            tbPhone.Text = _NewPerson.Phone.ToString();

            if(_NewPerson.Gendor)
            {
                rbMale.Checked = true;

            }
            else
            {
                rdFemale.Checked = true;
            }

            dtpDateOfBirth.Value = _NewPerson.DateOfBirth;

            comboCountries.SelectedIndex = _NewPerson.CountryNationalID - 1;


            if (!string.IsNullOrEmpty(_NewPerson.ImagePath) && File.Exists(_NewPerson.ImagePath))
            {
                pictureBox1.Load(_NewPerson.ImagePath);
            }
            else
            {

                if (_NewPerson.Gendor == true)
                    pictureBox1.Load("C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultMan1.png");
                else
                    pictureBox1.Load("C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultFrau1.png");


            }


        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Load(rdFemale.Checked ? "C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultFrau1.png" : "C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultMan1.png");

        }

        private void lb_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                lb_Remove.Visible = true;
                // ...
            }

        }

        private void lb_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            lb_Remove.Visible = false;
        }

    }
}
