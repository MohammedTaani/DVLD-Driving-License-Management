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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();

            _RefreshGridView();

            comboFilterby.SelectedIndex = 0;
        }


        private void _RefreshGridView()
        {

            AllPeople = clsUsersBusinessLayer.GetAllUsers();

            dataGridView1.DataSource = AllPeople;

        }

        private void _RefreshGridView(object sender ,  EventArgs e)
        {

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

            object search;

            if (tbFilter.Text.Length <= 0)
            {

                _RefreshGridView();

                return;
            }


            if (comboFilterby.SelectedItem?.ToString() == "PersonID" || comboFilterby.SelectedItem?.ToString() == "UserID")
            {
                if (tbFilter.Text.Length > 0)
                {
                    char lastChar = tbFilter.Text[tbFilter.Text.Length - 1];

                    if (!char.IsDigit(lastChar))
                    {
                        tbFilter.Text = tbFilter.Text.Substring(0, tbFilter.Text.Length - 1);

                        tbFilter.SelectionStart = tbFilter.Text.Length;

                        return;
                    }
                }


                search = Convert.ToInt32(tbFilter.Text);

            }
            else
            {
                search = tbFilter.Text.ToString();
            }



            string columnName = comboFilterby.SelectedItem.ToString();

            if (AllPeople != null && AllPeople.Columns.Contains(columnName))
            {
                DataView dv = new DataView(AllPeople);

                if(int.TryParse(search.ToString() , out int result) && (comboFilterby.SelectedItem?.ToString() == "PersonID" || comboFilterby.SelectedItem?.ToString() == "UserID") )
                {
                    dv.RowFilter = $"{columnName} = {result}";

                }
                else
                {
                    dv.RowFilter = $"{columnName} LIKE '{search}%'";
                }

                dataGridView1.DataSource = dv;
            }

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm1 = new frmAddNewUser();
            frm1.SomethingHappened += _RefreshGridView;
            frm1.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowUserDetails frm = new frmShowUserDetails((int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[1].Value);

            frm.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUserInfo frm = new frmUpdateUserInfo((int)dataGridView1.CurrentRow.Cells[0].Value , (int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.SomethingHappened += _RefreshGridView;

            frm.ShowDialog();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsUsersBusinessLayer.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
                MessageBox.Show("Der User wird erfolgreich geloscht");
            else
                MessageBox.Show("Der User wird leider nicht geloscht!!!");



            _RefreshGridView();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChangePassword frm1 = new frmChangePassword((int)dataGridView1.CurrentRow.Cells[1].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);

            frm1.ShowDialog();

        }


    }
}
