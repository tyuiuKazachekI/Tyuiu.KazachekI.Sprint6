using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {


        public double[] GetPositiveNumbers(double[] array)
        {
            List<double> positive = new List<double>();
            foreach (var val in array)
            {
                if (val > 0) positive.Add(val);
            }
            return positive.ToArray();
        }

        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllText(path).Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> values = new List<double>();

            foreach (var line in lines)
            {
                if (double.TryParse(line, out double val))
                    values.Add(Math.Round(val, 3));
            }

            return values.ToArray();
        }
    }
}
