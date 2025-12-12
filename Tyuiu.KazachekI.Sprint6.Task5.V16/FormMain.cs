using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task5.V16.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        private DataService ds_KI;
        private double[] allValues_KI = Array.Empty<double>();
        private double[] positiveValues_KI = Array.Empty<double>();

        private string textPath_KI;
        private string imagePath_KI;

        public FormMain()
        {
            InitializeComponent();
            ds_KI = new DataService();

            textPath_KI = Path.Combine(Directory.GetCurrentDirectory(), "Output_Task5_KI.txt");
            imagePath_KI = Path.Combine(Directory.GetCurrentDirectory(), "TempChart_KI.png");
        }

        private void buttonExecute_KI_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\Sprint6Task5\InPutDataFileTask5V16.txt";

                allValues_KI = ds_KI.LoadFromDataFile(filePath);
                positiveValues_KI = allValues_KI.Where(v => v > 0).ToArray();

                dataGridViewValues_KI.Rows.Clear();
                dataGridViewValues_KI.Columns.Clear();

                dataGridViewValues_KI.Columns.Add("colAll", "Все значения");
                dataGridViewValues_KI.Columns.Add("colPositive", "> 0");

                int rowCount = Math.Max(allValues_KI.Length, positiveValues_KI.Length);
                for (int i = 0; i < rowCount; i++)
                {
                    string allVal = i < allValues_KI.Length ? allValues_KI[i].ToString("0.###") : "";
                    string posVal = i < positiveValues_KI.Length ? positiveValues_KI[i].ToString("0.###") : "";
                    dataGridViewValues_KI.Rows.Add(allVal, posVal);
                }

                pictureBoxChart_KI.Refresh();

                File.WriteAllText(textPath_KI, GenerateText_KI(), Encoding.UTF8);

                Bitmap bmp = new Bitmap(pictureBoxChart_KI.Width, pictureBoxChart_KI.Height);
                pictureBoxChart_KI.DrawToBitmap(bmp, pictureBoxChart_KI.ClientRectangle);
                bmp.Save(imagePath_KI, System.Drawing.Imaging.ImageFormat.Png);
                bmp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateText_KI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("************* Все значения *************");

            foreach (var v in allValues_KI)
                sb.AppendLine(v.ToString("0.###"));

            sb.AppendLine("\n************* Значения > 0 *************");

            foreach (var v in positiveValues_KI)
                sb.AppendLine(v.ToString("0.###"));

            return sb.ToString();
        }

        private void pictureBoxChart_KI_Paint(object sender, PaintEventArgs e)
        {
            if (positiveValues_KI.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 40;
            int width = pictureBoxChart_KI.Width - 2 * margin;
            int height = pictureBoxChart_KI.Height - 2 * margin;

            Pen axis = new Pen(Color.Black, 2);
            g.DrawLine(axis, margin, margin, margin, margin + height);
            g.DrawLine(axis, margin, margin + height, margin + width, margin + height);

            Font font = new Font("Arial", 9);
            g.DrawString("> 0", font, Brushes.Black, 5, margin);
            g.DrawString("Значения", font, Brushes.Black, margin + width / 2 - 30, margin + height + 5);

            double maxVal = positiveValues_KI.Max();
            if (maxVal == 0) maxVal = 1;

            int barWidth = Math.Min(40, width / Math.Max(1, positiveValues_KI.Length) - 5);

            for (int i = 0; i < positiveValues_KI.Length; i++)
            {
                double val = positiveValues_KI[i];
                int barHeight = (int)((val / maxVal) * (height - 20));
                int x = margin + 10 + i * (barWidth + 10);
                int y = margin + height - barHeight;

                int red = Math.Clamp(100 + i * 15, 0, 255);
                int green = 100;
                int blue = Math.Clamp(150 + i * 5, 0, 255);
                Brush bar = new SolidBrush(Color.FromArgb(red, green, blue));

                g.FillRectangle(bar, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.DarkBlue, x, y, barWidth, barHeight);

                string label = val.ToString("0.###");
                SizeF size = g.MeasureString(label, font);
                g.DrawString(label, font, Brushes.Black,
                    x + barWidth / 2 - size.Width / 2, y - size.Height - 2);

                g.DrawString((i + 1).ToString(), font, Brushes.Black,
                    x + barWidth / 2 - 5, margin + height + 2);

                bar.Dispose();
            }

            axis.Dispose();
            font.Dispose();
        }

        private void buttonOpen_KI_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textPath_KI) || !File.Exists(imagePath_KI))
            {
                MessageBox.Show("Сначала выполните сохранение данных через кнопку «Выполнить».",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form infoForm = new Form
            {
                Text = "Файлы сохранены",
                Size = new Size(450, 220),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            TextBox infoBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Top,
                Height = 100,
                Text = $"Файлы сохранены:\r\nТекст: {textPath_KI}\r\nГрафик: {imagePath_KI}"
            };

            Button btnOpenText = new Button
            {
                Text = "Открыть текст",
                Width = 200,
                BackColor = Color.LightBlue,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnOpenText.Click += (_, __) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = textPath_KI,
                    UseShellExecute = true
                });
            };

            Button btnOpenImage = new Button
            {
                Text = "Открыть график",
                Width = 200,
                BackColor = Color.LightGreen,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnOpenImage.Click += (_, __) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = imagePath_KI,
                    UseShellExecute = true
                });
            };

            FlowLayoutPanel panelButtons = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 50
            };
            panelButtons.Controls.Add(btnOpenText);
            panelButtons.Controls.Add(btnOpenImage);

            infoForm.Controls.Add(infoBox);
            infoForm.Controls.Add(panelButtons);

            infoForm.ShowDialog();
        }

        private void buttonInfo_KI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнил студент группы ИСТНб-25-1 Казачек Иван",
                "Сообщение"
            );
        }
    }
}
