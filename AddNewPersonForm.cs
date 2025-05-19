using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Driving_License_Management
{
    public partial class AddNewPersonForm : Form
    {
        public AddNewPersonForm(bool addNewUser = false)
        {
            
            InitializeComponent();


            addNewPersonControl1.SomethingHappened += CloseForm;

            if (addNewUser)
            {

                addNewPersonControl1.DataBack += Resive_PersonID_To_CreateUser;

            }

        }

        public delegate void DataBackEventHandler(object sender, int Number);

        public event DataBackEventHandler DataBack;


        public event EventHandler SomethingHappened;

        private int _PersonID;
        private void Resive_PersonID_To_CreateUser(object sender , int PersonID)
        {

             _PersonID = PersonID;

        }




        public void CloseForm(object sender, EventArgs e)
        {



            this.Close();

            SomethingHappened?.Invoke(this, EventArgs.Empty);

            if (DataBack != null)
            {

                DataBack?.Invoke(this, _PersonID);
            }


        }


    }
}
