using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string content = File.ReadAllText(path);
            string[] parts = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = new List<double>();
            foreach (string p in parts)
            {
                if (double.TryParse(p, out double val))
                {
                    numbers.Add(Math.Round(val, 3));
                }
            }

            return numbers.ToArray();
        }

        public double[] GetPositiveNumbers(double[] data)
        {
            return data.Where(x => x > 0).ToArray();
        }
    }
}
