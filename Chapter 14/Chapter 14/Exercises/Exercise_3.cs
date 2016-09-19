using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_14.Exercises
{
    public partial class Exercise_3 : Form
    {
        public Exercise_3()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDS);

        }

        private void Exercise_3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDS.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDS.Customers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 2)
            {
                var cust = customersDS.Customers.FindBycustomer_ID(long.Parse(dataGridView1[0, e.RowIndex].Value.ToString()));
                lblArea.Text = (cust.customer_Area != null) ? "" : cust.customer_Area;
            }
            else
            {
                lblArea.Text = "";
            }
        }
    }
}
