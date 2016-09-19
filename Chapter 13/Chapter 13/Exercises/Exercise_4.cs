using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter_13.Exercises
{
    public partial class Exercise_4 : Form
    {
        public Exercise_4()
        {
            InitializeComponent();
        }

        char seperator = '/';

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\people.txt";
            StreamWriter writer = null;

            try
            {
                CheckForSeperator();
                writer = new StreamWriter(path, true);
                writer.WriteLine("{1}{0}{2}{0}{3}", seperator, txtName.Text, txtAddress.Text, txtPhone.Text);
                lblStatus.Text = "Saved " + txtName.Text;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void CheckForSeperator()
        {
            TextBox[] fields = { txtAddress, txtName, txtPhone };
            Array.ForEach(fields, txt => {
                if (txt.Text.Contains(seperator))
                    throw new InvalidDataException("Fields cannot include " + seperator);
            });
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}
