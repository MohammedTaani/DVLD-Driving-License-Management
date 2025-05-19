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
    public partial class frmEditTestTypeInfo : Form
    {
        public frmEditTestTypeInfo()
        {
            InitializeComponent();
        }

        private int _TestTypID = -1;

        public frmEditTestTypeInfo(int ID)
        {

            InitializeComponent();

            _TestTypID = ID;

            _AusFullenVonInfo();

        }

        public event EventHandler SomethingHappened;

        private void _AusFullenVonInfo()
        {

            string TestTypeTitle = "";
            string TestTypeDescription = "";
            int TestTypeFees = 0;

            if (BusinessLayer.clsTestsTypesBusiness.GetTestTypeInfoByID(_TestTypID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {

                tbID.Text = _TestTypID.ToString();
                tbTitle.Text = TestTypeTitle;
                tbDiscription.Text = TestTypeDescription;
                tbFees.Text = TestTypeFees.ToString();

            }
            else
            {
                MessageBox.Show("Die Informationen von dieser Test Typ sind nicht verfugbar. Es gibt ein Fehler");
                this.Close();
            }


        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (tbTitle.Text == "" || tbDiscription.Text == "" || tbFees.Text == "")
            {

                MessageBox.Show("Fullen Sie alle Lucken aus !!!");
                return;

            }

            if(BusinessLayer.clsTestsTypesBusiness.UpdateTestTypeInfo(_TestTypID , tbTitle.Text.ToString() , tbDiscription.Text.ToString() , Convert.ToInt32(tbFees.Text)))
            {
                MessageBox.Show("Test Typ Informaiton wurden erfolgreich aktualisiert");

                if (SomethingHappened != null)
                {

                    SomethingHappened?.Invoke(this, EventArgs.Empty);

                }

            }
            else
            {
                MessageBox.Show("Etwas Falsch !!! . Es wurde nicht aktaulisiert");
            }

            this.Close();

        }
    



    }
}
