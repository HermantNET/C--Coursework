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
    public partial class Exercise_1 : Form
    {
        public Exercise_1()
        {
            InitializeComponent();
        }

        private void Exercise_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDS.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDS.Customers);

        }
    }
}
