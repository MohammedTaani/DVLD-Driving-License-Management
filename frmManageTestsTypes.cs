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
    public partial class frmManageTestsTypes : Form
    {
        public frmManageTestsTypes()
        {
            InitializeComponent();

            _RefreshGridView();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshGridView()
        {

            dataGridView1.DataSource = BusinessLayer.clsTestsTypesBusiness.GetAllTestsTypes();

        }

        private void _RefreshGridView(object sender, EventArgs e)
        {

            _RefreshGridView();

        }

        private void editTestTypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTypeInfo frm = new frmEditTestTypeInfo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            frm.SomethingHappened += _RefreshGridView;


            frm.ShowDialog();

        }


    }
}
