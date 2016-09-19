﻿using System;
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
    public partial class Exercise_2 : Form
    {
        public Exercise_2()
        {
            InitializeComponent();
        }

        private void Exercise_2_Load(object sender, EventArgs e)
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            lblDirectory.Text = dir;

            lstFiles.Items.AddRange(System.IO.Directory.GetFiles(dir));
        }
    }
}
