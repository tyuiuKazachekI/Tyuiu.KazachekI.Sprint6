using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint6.Task2.V4.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;

            double[] expected = new double[]
            {
                -15.6, -12.35, -10.72, -8.88, -2.16,
                 3.25, 6.64, 10.3, 16.17, 28.1, 38.41
            };

            double[] actual = ds.GetMassFunction(start, stop);

            Assert.AreEqual(expected.Length, actual.Length, "Количество элементов не совпадает");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01, $"Элемент {i} не совпадает. Ожидалось {expected[i]}, получено {actual[i]}");
            }
        }
    }
}
