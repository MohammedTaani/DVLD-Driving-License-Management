using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DVLD_Driving_License_Management
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();

            _RefrishGridView();

        }

        private DataTable AlleDrivers = new DataTable();
        private void _RefrishGridView()
        {

            AlleDrivers = BusinessLayer.clsDriversBusinessLayer.GetAllDrivers();

            dataGridView1.DataSource = AlleDrivers;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colName = comboFilterby.Text;

            if (!string.IsNullOrEmpty(colName) && dataGridView1.Columns.Contains(colName))
            {
                dataGridView1.Sort(dataGridView1.Columns[colName], ListSortDirection.Ascending);
            }

            tbFilterby.Visible = true;
        }

        private void tbFilterby_TextChanged(object sender, EventArgs e)
        {
            object search;

            if (tbFilterby.Text.Length <= 0)
            {

                _RefrishGridView();

                return;
            }


            if (comboFilterby.SelectedItem?.ToString() == "PersonID" || comboFilterby.SelectedItem?.ToString() == "DriverID")
            {
                if (tbFilterby.Text.Length > 0)
                {
                    char lastChar = tbFilterby.Text[tbFilterby.Text.Length - 1];

                    if (!char.IsDigit(lastChar))
                    {
                        tbFilterby.Text = tbFilterby.Text.Substring(0, tbFilterby.Text.Length - 1);

                        tbFilterby.SelectionStart = tbFilterby.Text.Length;

                        return;
                    }
                }


                search = Convert.ToInt32(tbFilterby.Text);

            }
            else
            {
                search = tbFilterby.Text.ToString();
            }



            string columnName = comboFilterby.SelectedItem.ToString();

            if (AlleDrivers != null && AlleDrivers.Columns.Contains(columnName))
            {
                DataView dv = new DataView(AlleDrivers);

                if (int.TryParse(search.ToString(), out int result) && (comboFilterby.SelectedItem?.ToString() == "PersonID" || comboFilterby.SelectedItem?.ToString() == "DriverID"))
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


    }
}
