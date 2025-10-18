using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint6.Task1.V14.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length); // [-5..5] = 11 элементов
            // Проверка деления на ноль для конкретного значения
            for (int i = 0; i < result.Length; i++)
            {
                double x = -5 + i;
                double denom = Math.Cos(x) + x;
                if (Math.Abs(denom) < 1e-10)
                {
                    Assert.AreEqual(0, result[i]);
                }
            }
        }
    }
}
