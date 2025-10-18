using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KazachekI.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double denominator = Math.Cos(x) + x;
                if (Math.Abs(denominator) < 1e-10)
                {
                    arr[i] = 0; // защита от деления на ноль
                }
                else
                {
                    arr[i] = Math.Round((2 * x + 6) / denominator - 3, 2);
                }
            }

            return arr;
        }
    }
}
