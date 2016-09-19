using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_13.Exercises
{
    public partial class Exercise_10 : Form
    {
        public Exercise_10()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] numbersText = { txtNum1, txtNum2, txtNum3, txtNum4, txtNum5 };
            double[] numbers = new double[numbersText.Length];

            int i = 0;
            Array.ForEach(numbersText, txt =>
            {
                double.TryParse(txt.Text, out numbers[i]);
                i++;
            });

            using (var fileStream = new FileStream("./numbers.txt", FileMode.Append, FileAccess.Write))
            using (var writer = new System.IO.BinaryWriter(fileStream))
            {
                writer.Write('/');
                Array.ForEach(numbers, num =>
                {
                    writer.Write(num);
                    writer.Write(' ');
                });
                writer.Write(numbers.Average());
                writer.Write('/');
            }

            ReadBinaryFile();
        }

        private void ReadBinaryFile()
        {
            string stream = "";

            using (var reader = new BinaryReader(new FileStream("./numbers.txt", FileMode.Open,FileAccess.Read)))
            {

                while (reader.BaseStream.Length > reader.BaseStream.Position)
                {
                    stream += reader.ReadChar();
                    for (int i = 0; i < 5; i++)
                    {
                        stream += reader.ReadDouble();
                        stream += reader.ReadChar();
                    }
                    stream += reader.ReadDouble();
                    stream += reader.ReadChar();
                }
            }

            string[] result = stream.Split('/');
            for (int i = 0; i < result.Length; i++ )
            {
                string[] split = result[i].Split(' ');
                result[i] = string.Join(", ", split);
            }

            lstNumbers.Items.Clear();
            lstNumbers.Items.AddRange(result);
        }

        private void Exercise_10_Load(object sender, EventArgs e)
        {
            if (File.Exists("./numbers.txt"))
                ReadBinaryFile();
        }
    }
}
