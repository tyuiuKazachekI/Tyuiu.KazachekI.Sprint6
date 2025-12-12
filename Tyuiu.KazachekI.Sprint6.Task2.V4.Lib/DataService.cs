using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double denominator = Math.Sin(x + 2) + 2 * x + 2;

                if (Math.Abs(denominator) < 1e-10)
                {
                    result[i] = 0;  // защита от деления на 0
                }
                else
                {
                    result[i] = Math.Round((5 * x + 2.5) / denominator, 2);
                }
            }

            return result;
        }
    }
}
