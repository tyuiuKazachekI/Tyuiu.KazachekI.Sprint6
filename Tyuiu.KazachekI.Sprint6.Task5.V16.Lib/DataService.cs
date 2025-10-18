using System;
using System.IO;
using System.Collections.Generic;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16.Lib
{
    public class DataService
    {
        public double[] LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> positives = new List<double>();
            foreach (string part in parts)
            {
                if (double.TryParse(part, out double num) && num > 0)
                {
                    positives.Add(Math.Round(num, 3));
                }
            }

            return positives.ToArray();
        }
    }
}
