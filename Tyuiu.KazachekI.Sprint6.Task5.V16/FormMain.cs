using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task5.V16.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private double[] positives = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\Sprint6Task5\InPutDataFileTask5V16.txt";
                positives = ds.LoadFromDataFile(path);

                dataGridViewAll.Rows.Clear();
                dataGridViewPositive.Rows.Clear();

                foreach (double val in positives)
                {
                    dataGridViewAll.Rows.Add(val);      // Все положительные в первой таблице
                    dataGridViewPositive.Rows.Add(val); // Положительные в отдельной таблице
                }

                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (positives.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = 20, y = 20;
            int barHeight = 20;
            int maxWidth = pictureBoxChart.Width - 60;

            double max = positives.Max();
            if (max == 0) max = 1;

            foreach (double val in positives)
            {
                int barWidth = (int)((val / max) * maxWidth);
                g.FillRectangle(Brushes.LightGreen, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                g.DrawString(val.ToString("0.###"), this.Font, Brushes.Black, x + barWidth + 5, y);
                y += barHeight + 5;
            }
        }
    }
}
