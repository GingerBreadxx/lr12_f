using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr12_1
{
    public partial class Form1 : Form
    {
        private string fileName = "vectors.txt";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddVector_Click(object sender, EventArgs e)
        {
            int length;
            double coordinate;

            // Проверка введенных значений на корректность
            if (!int.TryParse(tbLength.Text, out length) || length <= 0)
            {
                MessageBox.Show("Введите корректную длину вектора (целое положительное число).");
                return;
            }

            string[] coordinates = tbCoordinates.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (coordinates.Length != length)
            {
                MessageBox.Show("Количество координат вектора не соответствует указанной длине.");
                return;
            }

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write(length + " ");
                foreach (string coord in coordinates)
                {
                    if (!double.TryParse(coord, out coordinate))
                    {
                        MessageBox.Show("Введите корректные координаты вектора (вещественные числа, разделенные пробелами или запятыми).");
                        return;
                    }
                    writer.Write(coordinate + " ");
                }
                writer.WriteLine();
            }

            MessageBox.Show("Вектор успешно добавлен в файл.");
            tbLength.Clear();
            tbCoordinates.Clear();
            MessageBox.Show($"Длина: {length}\nКоординаты: {string.Join(", ", coordinates)}\n\n");
        }

        private void btnShowVectors_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл с векторами не найден.");
                return;
            }

            listBoxVectors.Items.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listBoxVectors.Items.Add(line);
                }
            }
        }


    }
}

