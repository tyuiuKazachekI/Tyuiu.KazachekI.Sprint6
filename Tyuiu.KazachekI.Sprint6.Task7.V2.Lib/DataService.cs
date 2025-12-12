using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2.Lib
{
    public class DataService : ISprint6Task7V2
    {
        public int[,] GetMatrix(string path)
        {
            // Чтение всех строк CSV
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу из CSV
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(parts[j]);
                }
            }

            // === ГЛАВНАЯ ЛОГИКА ===
            // ВО ВТОРОЙ строке (индекс 1)
            // заменить ЧЁТНЫЕ числа на 555
            for (int j = 0; j < cols; j++)
            {
                if (matrix[1, j] % 2 == 0) // чётное
                {
                    matrix[1, j] = 555;
                }
            }

            return matrix;
        }
    }
}
