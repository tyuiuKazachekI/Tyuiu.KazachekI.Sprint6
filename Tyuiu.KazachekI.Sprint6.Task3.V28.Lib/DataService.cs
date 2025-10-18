using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        // Исходный массив
        private int[,] initialMatrix = new int[,]
        {
            { -9,  8,  9, 16, -18 },
            { -13, -11, -20, -15, 9 },
            { 18, 13, -12, -15, -11 },
            { 10, -2, 19, -4, -10 },
            { 6, -20, -4, 13, -14 }
        };

        public int[,] Calculate(int[,] matrix)
        {
            // Если matrix пустой, возвращаем исходный массив
            if (matrix == null)
                return (int[,])initialMatrix.Clone();

            // Иначе заменяем четные значения в 4-й строке
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[3, j] % 2 == 0)
                    matrix[3, j] = 0;
            }
            return matrix;
        }
    }
}
