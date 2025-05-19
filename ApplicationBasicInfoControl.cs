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
    public partial class ApplicationBasicInfoControl : UserControl
    {
        public ApplicationBasicInfoControl()
        {
            InitializeComponent();
        }

        private int _PersonID = 0;
        public void AusFullenAlleLucken(int LokalApplicationID)
        {

            string Status = "";
            int Fees = 0;
            string Type = "";
            string FullName = "";
            DateTime Date = DateTime.Now;
            DateTime StatusDate = DateTime.Now;
            string CreatedBy = "";
            int PersonID = 0;

            if(BusinessLayer.LDLApplicationsBusinessLayer.GetInfoToBasicInfoControl(LokalApplicationID , ref Status , ref Fees, ref Type, ref FullName, ref Date, ref StatusDate , ref CreatedBy , ref PersonID))
            {

                labelID.Text = LokalApplicationID.ToString();
                labelStatus.Text = Status.ToString();
                labelType.Text = Type.ToString();
                labelFees.Text = Fees.ToString();
                labelApplicant.Text = FullName.ToString();
                labelDate.Text = Date.ToString();
                labelStatusDate.Text = StatusDate.ToString();
                labelCreatedBy.Text = CreatedBy.ToString();

                _PersonID = PersonID;

            }

        }

        private void linkLabelViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowPersonDetailsForm frm = new ShowPersonDetailsForm(_PersonID);
            frm.ShowDialog();

        }
    }
}
