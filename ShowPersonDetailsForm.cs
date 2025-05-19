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
    public partial class ShowPersonDetailsForm : Form
    {
        public ShowPersonDetailsForm()
        {
            InitializeComponent();
        }

        PeopleBusiness _PersonInfo;

        private int _PersonId;

        public event EventHandler TheFormClosing;


        public ShowPersonDetailsForm(int PersonID)
        {

            InitializeComponent();

            this._PersonId = PersonID;

            _LoadInfo();

        }

        private void _LoadInfo()
        {

            _PersonInfo = PeopleBusiness.FindPersonInfoByID(_PersonId);

            showPersonInfoControl1.GetPersonData(this._PersonInfo);

            

        }

        private void ShowPersonDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            TheFormClosing?.Invoke(this, EventArgs.Empty);

        }

        private void showPersonInfoControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
