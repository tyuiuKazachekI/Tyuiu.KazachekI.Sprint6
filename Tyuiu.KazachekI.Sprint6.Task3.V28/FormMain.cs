using System;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task3.V28.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private int[,] matrix;

        public FormMain()
        {
            InitializeComponent();
            LoadInitialMatrix();
        }

        private void LoadInitialMatrix()
        {
            matrix = ds.Calculate(null); // Получаем исходный массив
            DisplayMatrix(matrix);
        }

        private void DisplayMatrix(int[,] mat)
        {
            dataGridViewResult.ColumnCount = mat.GetLength(1);
            dataGridViewResult.RowCount = mat.GetLength(0);

            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    dataGridViewResult.Rows[i].Cells[j].Value = mat[i, j];
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix); // Заменяем четные в 4-й строке
            DisplayMatrix(matrix);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, Вариант 28 выполнен студентом Казачек И.\nЗадача: заменить четные значения в четвертой строке на 0 и вывести массив в DataGridView.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
