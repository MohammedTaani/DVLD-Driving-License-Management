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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();

            _RefreshGridView();

        }


        private void _RefreshGridView()
        {

            dataGridView1.DataSource = BusinessLayer.clsBusinessApplicationTypes.GetAllApplicationTypes();

        }

        private void _RefreshGridView(object sender, EventArgs e)
        {

            _RefreshGridView();

        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEditApplicationType frm = new frmEditApplicationType(
                Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)
            );

            frm.SomethingHappened += _RefreshGridView;


            frm.ShowDialog();


        }
    


    
    }
}
