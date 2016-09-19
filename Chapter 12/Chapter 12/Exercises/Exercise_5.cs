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
    public partial class Exercise_5 : Form
    {
        public Exercise_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton convertFrom in groupBox1.Controls)
            {
                if (convertFrom.Checked)
                {
                    foreach (RadioButton convertTo in groupBox2.Controls)
                    {
                        if (convertTo.Checked)
                        {
                            lblResult.Text = string.Format("{0:###,##0.####} {1}", Ex5.WeightConverter.ConvertWeightTo(convertFrom.Text, convertTo.Text, textBox1.Text), convertTo.Text);
                            break;
                        }   
                    }
                    break;
                }
            }
        }

        private void radSelection_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
