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
    public partial class frmEditApplicationType : Form
    {
        public frmEditApplicationType()
        {
            InitializeComponent();
        }

        public frmEditApplicationType(int ID, string ApplicationType, int Fees)
        {

            InitializeComponent();

            tbID.Text = ID.ToString();
            tbTitel.Text = ApplicationType.ToString();
            tbFees.Text = Fees.ToString();

            tbTitel.Focus();

        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public event EventHandler SomethingHappened;
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (tbTitel.Text.Length == 0 || tbFees.Text.Length == 0)
            {

                MessageBox.Show("Fullen Sie bitte alle Lucken aus !");

                return;

            }

            if(BusinessLayer.clsBusinessApplicationTypes.UpdateApplicationInfo(Convert.ToInt32(tbID.Text) , tbTitel.Text.ToString() , Convert.ToInt32(tbFees.Text)))
            {

                MessageBox.Show("Application Type wurde erfolgreich aktaulisiert");

                if (SomethingHappened != null)
                {

                    SomethingHappened?.Invoke(this, EventArgs.Empty);

                }


            }
            else
            {
                MessageBox.Show("Etwas falsch !!! . Application Type wurde nicht aktaulisiert");
            }


            this.Close();


        }
    


    }
}
