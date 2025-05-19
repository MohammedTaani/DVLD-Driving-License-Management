using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.IO;
using System.Resources;

namespace DVLD_Driving_License_Management
{
    public partial class ShowPersonInfoControl : UserControl
    {
        public ShowPersonInfoControl()
        {
            InitializeComponent();

            linkbtnEdit.Visible = false;

        }

        
        private void _LoadAllCountries()
        {

            DataTable dt = CountriesBusiness.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                comboCountries.Items.Add(row["CountryName"].ToString());
            }


        }

        private bool _IstAlleLuckenGefullt = false;
        public void GetPersonData(PeopleBusiness PersonInfo)
        {

            _LoadAllCountries();

            tbPersonID.Text = PersonInfo.PersonID.ToString();

            tbPersonID.ReadOnly = true;

            tbName.Text = (PersonInfo.FirstName + " " + PersonInfo.SecondName + " " + PersonInfo.ThirdName + " " + PersonInfo.LastName).ToString();

            tbName.ReadOnly = true;

            tbNationalNo.Text = PersonInfo.NationalNo.ToString();

            tbNationalNo.ReadOnly = true;

            if (PersonInfo.Gendor == true)
                tbGendor.Text = "Male";
            else
                tbGendor.Text = "Female";

            tbGendor.ReadOnly = true;

            tbEmail.Text = PersonInfo.Email.ToString();

            tbEmail.ReadOnly = true;

            tbAddress.Text = PersonInfo.Address.ToString();

            tbAddress.ReadOnly = true;

            tbPhone.Text = PersonInfo.Phone.ToString();

            tbPhone.ReadOnly = true;

            comboCountries.SelectedIndex = comboCountries.FindString(CountriesBusiness.FindCountryNameByID(PersonInfo.CountryNationalID));

            comboCountries.Enabled = false;


            dtpDateOfBirth.Value = PersonInfo.DateOfBirth;

            dtpDateOfBirth.Enabled = false;

            if (!string.IsNullOrEmpty(PersonInfo.ImagePath) && File.Exists(PersonInfo.ImagePath))
            {
                pictureBox1.Load(PersonInfo.ImagePath);
            }
            else
            {

                if (PersonInfo.Gendor == true)
                    pictureBox1.Load("C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultMan1.png");
                else
                    pictureBox1.Load("C:\\Users\\moham\\OneDrive\\Desktop\\Projekt\\Fotos\\DefaultFrau1.png");
                

            }

            linkbtnEdit.Visible = true;

            _IstAlleLuckenGefullt = true;

        }

        private void lb_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            

            EditPersonInformation frm = new EditPersonInformation(Convert.ToInt32(tbPersonID.Text));
            
            frm.ShowDialog();

            PeopleBusiness _PersonInfo = PeopleBusiness.FindPersonInfoByID(Convert.ToInt32(tbPersonID.Text));

            GetPersonData(_PersonInfo);


        }
    
        public bool IstAlleLuckenGefullt()
        {
            return _IstAlleLuckenGefullt;
        }
        
        public int GetPersonID()
        {
            try
            {
                return Convert.ToInt32(tbPersonID.Text);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

    }
}
