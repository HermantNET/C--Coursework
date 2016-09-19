using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_13.Exercises
{
    public partial class Exercise_1 : Form
    {
        public Exercise_1()
        {
            InitializeComponent();
        }

        private void Exercise_1_Load(object sender, EventArgs e)
        {
            using (var StreamReader = new System.IO.StreamReader(@"../../Exercises/Ex1/numbers.txt"))
            {
                List<double> numbers = new List<double>();

                while (!StreamReader.EndOfStream)
                    numbers.Add(double.Parse(StreamReader.ReadLine()));

                StreamReader.Close();

                numbers.ForEach(number => lstNumbers.Items.Add(number));
                lblAverage.Text = numbers.Average().ToString();
            }
        }
    }
}
