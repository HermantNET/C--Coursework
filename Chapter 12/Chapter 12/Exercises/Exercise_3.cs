using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_12.Exercises
{
    public partial class Exercise_3 : Form
    {
        List<double> grades = new List<double>();
        
        public Exercise_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                grades.Add(double.Parse(txtInput.Text));
                lblResult.Text = "Last Grade Entered: " + grades.Last().ToString();
            }
            catch (FormatException ex)
            {
                lblResult.Text = "Please enter only numeric values.\n" + ex.Message;
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = Mallem.Convert.Grade.ToLetterGrade(grades.Average()).ToString();
            }
            catch (ArithmeticException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}
