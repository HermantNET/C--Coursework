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
    public partial class Exercise_7 : Form
    {
        public Exercise_7()
        {
            InitializeComponent();
        }

        private void Exercise_7_Load(object sender, EventArgs e)
        {
            string path = "../../Exercises/Ex7/";
            List<string[]> NameScores = new List<string[]>();

            using (var reader = new System.IO.StreamReader(path + "NameScores.txt"))
            {
                while (!reader.EndOfStream)
                {
                    NameScores.Add(reader.ReadLine().Split('/'));
                }
            }

            using (var writer = new System.IO.StreamWriter(path + "NameAverage.txt"))
            {
                double[] scores = new double[3];
                for (int i = 0; i < NameScores.Count; i++)
                {
                    for (int score = 0; score < 3; score++)
                    {
                        try
                        {
                            scores[score] = double.Parse(NameScores[i][score + 1]);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Error processing scores.\n" + ex.Message);
                        }
                    }
                    writer.WriteLine(NameScores[i][0] + "/" + scores.Average().ToString("N2"));
                }
            }

            using (var reader = new System.IO.StreamReader(@"../../Exercises/Ex7/NameAverage.txt"))
            {
                while (!reader.EndOfStream)
                {
                    ListViewItem nameAvg = new ListViewItem(reader.ReadLine().Split('/'));
                    lsvAverages.Items.Add(nameAvg);
                }
            }
        }
    }
}
