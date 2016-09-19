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
    public partial class Exercise_7 : Form
    {
        public Exercise_7()
        {
            InitializeComponent();
        }

        private void Exercise_7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDS.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDS.Books);

        }
    }
}
