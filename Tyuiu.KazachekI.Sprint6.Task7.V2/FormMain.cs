using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task7.V2.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        private string selectedFile = "";
        private int[,] matrix;
        private int[,] resultMatrix;

        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        // ╔══════════════════════════════════════════════╗
        // ║                  ЗАГРУЗКА CSV                ║
        // ╚══════════════════════════════════════════════╝
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    Title = "Выберите CSV файл"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;

                    matrix = LoadMatrix(selectedFile);

                    dataGridViewIn.DataSource = ConvertToTable(matrix);
                    FormatGrid(dataGridViewIn);

                    buttonProcess.Enabled = true;
                    buttonSave.Enabled = false;

                    labelFileInfo.Text = "Файл: " + Path.GetFileName(selectedFile);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ╔══════════════════════════════════════════════╗
        // ║               ЗАГРУЗКА МАТРИЦЫ              ║
        // ╚══════════════════════════════════════════════╝
        private int[,] LoadMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] m = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(';').Select(s => s.Trim()).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = int.Parse(values[j]);
                }
            }

            return m;
        }

        // ╔══════════════════════════════════════════════╗
        // ║                 ОБРАБОТКА CSV                ║
        // ╚══════════════════════════════════════════════╝
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Чётные числа во 2-й строке заменяем на 555
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            resultMatrix = (int[,])matrix.Clone();

            for (int j = 0; j < cols; j++)
            {
                if (resultMatrix[1, j] % 2 == 0)
                {
                    resultMatrix[1, j] = 555;
                }
            }

            dataGridViewOut.DataSource = ConvertToTable(resultMatrix);
            FormatGrid(dataGridViewOut);

            buttonSave.Enabled = true;
        }

        // ╔══════════════════════════════════════════════╗
        // ║                 СОХРАНЕНИЕ CSV               ║
        // ╚══════════════════════════════════════════════╝
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (resultMatrix == null)
            {
                MessageBox.Show("Нет данных для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = "OutMatrixV2.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveMatrix(resultMatrix, sfd.FileName);
                MessageBox.Show("Файл успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveMatrix(int[,] m, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                int rows = m.GetLength(0);
                int cols = m.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < cols; j++)
                    {
                        line += m[i, j].ToString();
                        if (j < cols - 1) line += ";";
                    }
                    sw.WriteLine(line);
                }
            }
        }

        // ╔══════════════════════════════════════════════╗
        // ║                   О ПРОГРАММЕ                ║
        // ╚══════════════════════════════════════════════╝
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form f = new Form
            {
                Text = "О программе",
                Size = new Size(580, 300),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\autor.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(140, 180),
                Location = new Point(20, 20)
            };

            Label lbl = new Label
            {
                Text =
                    "Казачек Иван\n" +
                    "ИСТнб-25-1\n" +
                    "Спринт 6 — Task 7 — Вариант 2\n" +
                    "ТИУ, 2025",
                Location = new Point(180, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 11)
            };

            Button ok = new Button
            {
                Text = "OK",
                Size = new Size(80, 30),
                Location = new Point(450, 210),
                DialogResult = DialogResult.OK
            };

            f.Controls.Add(pic);
            f.Controls.Add(lbl);
            f.Controls.Add(ok);
            f.AcceptButton = ok;

            f.ShowDialog();
        }

        // ╔══════════════════════════════════════════════╗
        // ║         ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ             ║
        // ╚══════════════════════════════════════════════╝

        private DataTable ConvertToTable(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            DataTable dt = new DataTable();

            for (int c = 0; c < cols; c++)
                dt.Columns.Add("C" + (c + 1).ToString());

            for (int r = 0; r < rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 0; c < cols; c++)
                    dr[c] = arr[r, c];
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void FormatGrid(DataGridView d)
        {
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.RowHeadersVisible = true;

            for (int i = 0; i < d.Rows.Count; i++)
                d.Rows[i].HeaderCell.Value = (i + 1).ToString();

            d.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
