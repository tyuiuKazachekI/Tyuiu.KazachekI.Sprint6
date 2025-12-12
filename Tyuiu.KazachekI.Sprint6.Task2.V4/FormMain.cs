using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task2.V4.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        private DataService dataService_IK = new DataService();
        private double[] functionValues_IK = Array.Empty<double>();
        private int startX_IK = -5;
        private int endX_IK = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            functionValues_IK = dataService_IK.GetMassFunction(startX_IK, endX_IK);

            dataGridViewResult_IK.Rows.Clear();
            for (int i = 0; i < functionValues_IK.Length; i++)
            {
                dataGridViewResult_IK.Rows.Add(startX_IK + i, functionValues_IK[i]);
            }

            pictureBoxChart_IK.Refresh();
        }

        private void pictureBoxChart_IK_Paint(object sender, PaintEventArgs e)
        {
            if (functionValues_IK.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int width = pictureBoxChart_IK.Width - 40;
            int height = pictureBoxChart_IK.Height - 40;

            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                g.DrawLine(axisPen, 20, height / 2 + 20, width + 20, height / 2 + 20); // X
                g.DrawLine(axisPen, 20, 20, 20, height + 20); // Y
            }

            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (double v in functionValues_IK)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }
            if (Math.Abs(max - min) < 0.0001) { max = min + 2; min = min - 2; }

            double dx = width / (double)(functionValues_IK.Length - 1);
            double scaleY = height / (max - min);

            using (Pen graphPen = new Pen(Color.Blue, 2))
            {
                for (int i = 0; i < functionValues_IK.Length - 1; i++)
                {
                    float x1 = (float)(20 + i * dx);
                    float x2 = (float)(20 + (i + 1) * dx);
                    float y1 = (float)(20 + height - (functionValues_IK[i] - min) * scaleY);
                    float y2 = (float)(20 + height - (functionValues_IK[i + 1] - min) * scaleY);
                    g.DrawLine(graphPen, x1, y1, x2, y2);
                }
            }

            using (Font labelFont = new Font("Arial", 8))
            {
                for (int i = 0; i < functionValues_IK.Length; i++)
                {
                    float x = (float)(20 + i * dx);
                    float y = (float)(20 + height - (functionValues_IK[i] - min) * scaleY);
                    g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
                    g.DrawString($"({startX_IK + i}, {functionValues_IK[i]:F2})", labelFont, Brushes.DarkBlue, x + 5, y - 15);
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 2 выполнил студент группы ИСТНб-25-1 Казачек И.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
