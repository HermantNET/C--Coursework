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
    public partial class Exercise_2 : Form
    {
        public Exercise_2()
        {
            InitializeComponent();
        }

        private void Exercise_2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDS.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDS.Customers);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Adapter.Update(this.customersDS.GetChanges());
                this.customersDS.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
