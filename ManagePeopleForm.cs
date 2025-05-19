using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Driving_License_Management
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();

            comboFilterby.SelectedIndex = 0;

            _RefreshGridView();

            tbFilter.Visible = false;

        }

        private void _AddNewPerson()
        {
            AddNewPersonForm AddNewPersonForm1 = new AddNewPersonForm();

            AddNewPersonForm1.SomethingHappened += _RefreshGridView;

            AddNewPersonForm1.ShowDialog();



        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {

            _AddNewPerson();


        }


        private void _RefreshGridView(object sender, EventArgs e)
        {

            _RefreshGridView();

        }

        private void _RefreshGridView()
        {

            AllPeople = BusinessLayer.PeopleBusiness.GetAllPeopleInfo();

            dataGridView1.DataSource = AllPeople;

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPersonDetailsForm frm = new ShowPersonDetailsForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.TheFormClosing += _RefreshGridView;
            frm.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPersonInformation frm = new EditPersonInformation((int)dataGridView1.CurrentRow.Cells[0].Value);

            frm.PersonInformationChanged += _RefreshGridView;

            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            PeopleBusiness.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value);

            _RefreshGridView();

        }

        private void comboFilterby_TextChanged(object sender, EventArgs e)
        {

            string colName = comboFilterby.Text;

            if (!string.IsNullOrEmpty(colName) && dataGridView1.Columns.Contains(colName))
            {
                dataGridView1.Sort(dataGridView1.Columns[colName], ListSortDirection.Ascending);
            }

            tbFilter.Visible = true;
        }

        private DataTable AllPeople = new DataTable();

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            string search = tbFilter.Text.ToString();
            string columnName = comboFilterby.SelectedItem.ToString();

            if (AllPeople != null && AllPeople.Columns.Contains(columnName))
            {
                DataView dv = new DataView(AllPeople);
                dv.RowFilter = $"{columnName} LIKE '{search}%'";
                dataGridView1.DataSource = dv;
            }

        }

        private void comboFilterby_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboFilterby.SelectedItem.ToString() == "Gendor")
            {
                tbFilter.Visible = false;
            }

        }



    }
}
