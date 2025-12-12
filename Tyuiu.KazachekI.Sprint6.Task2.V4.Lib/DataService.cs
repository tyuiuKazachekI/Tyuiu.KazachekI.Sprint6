using System;

namespace Tyuiu.KazachekI.Sprint6.Task2.V4.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;

                if (Math.Abs(denominator) < 1e-10)
                {
                    result[index] = 0;
                }
                else
                {
                    double value = ((5 * x + 2.5) / denominator) + (2 * x + 2);
                    result[index] = Math.Round(value, 2);
                }

                index++;
            }

            return result;
        }
    }
}
