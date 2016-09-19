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
    public partial class Exercise_1 : Form
    {
        public Exercise_1()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                // Throws divide by zero arithmetic exception
                //for (int i = 0; i < 1; i++)
                //   i = 5 / i;

                // Throws FormatException stating input string was not in correct format
                //string test = "55f";
                //double.Parse(test);

                // Throws index out of range exception
                //double[] array = new double[2];
                //array[2] = 5;

                // Throws null value exception
                string str = null;
                double.Parse(str);
            }
            catch (ArithmeticException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch (FormatException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch (IndexOutOfRangeException ex)
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
