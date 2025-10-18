using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            // Разбиваем текст на числа
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> positives = new List<double>();

            foreach (string part in parts)
            {
                if (double.TryParse(part.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    // Добавляем только положительные
                    if (num > 0)
                        positives.Add(Math.Round(num, 3));
                }
            }

            return positives.ToArray();
        }

        public double[] GetPositiveNumbers(double[] array)
        {
            List<double> positive = new List<double>();
            foreach (var val in array)
            {
                if (val > 0)
                    positive.Add(val);
            }
            return positive.ToArray();
        }
    }
}
