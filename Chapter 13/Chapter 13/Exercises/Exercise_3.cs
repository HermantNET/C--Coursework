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
    public partial class Exercise_3 : Form
    {
        public Exercise_3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory() + @"\MyInfo.txt";

                var write = new System.IO.StreamWriter(path);

                write.WriteLine(txtName.Text);
                write.WriteLine(txtAddress.Text);
                write.WriteLine(string.Format("*{0}*", txtPhone.Text));

                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
