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
    public partial class Exercise_8 : Form
    {
        public Exercise_8()
        {
            InitializeComponent();
        }

        private void courseBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseBooksDS);

        }

        private void Exercise_8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseBooksDS.CourseBooks' table. You can move, or remove it, as needed.
            this.courseBooksTableAdapter.Fill(this.courseBooksDS.CourseBooks);

        }
    }
}
