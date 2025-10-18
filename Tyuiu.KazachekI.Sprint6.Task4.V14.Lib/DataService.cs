using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] values = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double fx;

                try
                {
                    double denominator = Math.Sin(x) + 1;
                    if (Math.Abs(denominator) < 1e-10) fx = 0; // проверка деления на ноль
                    else fx = 2 * x - 4 + (2 * x - 1) / denominator;
                }
                catch
                {
                    fx = 0;
                }

                values[i] = Math.Round(fx, 2);
            }

            return values;
        }

        public void SaveToFile(double[] values, string fileName)
        {
            using StreamWriter sw = new StreamWriter(fileName);
            foreach (var val in values)
            {
                sw.WriteLine(val);
            }
        }
    }
}
