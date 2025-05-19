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
    public partial class EditPersonInformation : Form
    {
        public EditPersonInformation()
        {
            InitializeComponent();
        }

        public event EventHandler PersonInformationChanged;

        public EditPersonInformation(int PersonID)
        {
            InitializeComponent();

            enebeldEditPersonInfoControl1.SomethingHappened += _Close;

            enebeldEditPersonInfoControl1._LoadDataToUpdate(PersonID);

            

        }

        public void _Close(object sender, EventArgs e)
        {

            this.Close();

            PersonInformationChanged?.Invoke(this, EventArgs.Empty);

        }

        

    }
}
