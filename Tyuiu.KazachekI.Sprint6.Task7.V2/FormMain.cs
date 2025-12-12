using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task7.V2.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private int[,] matrix;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                matrix = ds.GetMatrix(ofd.FileName);
                FillGrid(dataGridViewIn, matrix);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (matrix == null)
                return;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            // ¬“ќ–јя строка Ч индекс 1
            for (int j = 0; j < cols; j++)
            {
                if (result[1, j] % 2 == 0) // четное
                {
                    result[1, j] = 555;
                }
            }

            FillGrid(dataGridViewOut, result);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut.Rows.Count == 0) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    for (int i = 0; i < dataGridViewOut.Rows.Count; i++)
                    {
                        string line = "";
                        for (int j = 0; j < dataGridViewOut.Columns.Count; j++)
                        {
                            line += dataGridViewOut.Rows[i].Cells[j].Value.ToString();
                            if (j < dataGridViewOut.Columns.Count - 1) line += ";";
                        }
                        sw.WriteLine(line);
                    }
                }
            }
        }

        private void FillGrid(DataGridView dgv, int[,] data)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int j = 0; j < cols; j++)
                dgv.Columns.Add($"col{j}", $"Col {j + 1}");

            for (int i = 0; i < rows; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dgv.Rows[i].Cells[j].Value = data[i, j];
                }
            }
        }
    }
}
