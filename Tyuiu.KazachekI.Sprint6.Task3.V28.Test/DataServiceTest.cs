using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint6.Task3.V28.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestEvenReplaceInFourthRow()
        {
            int[,] matrix = new int[5, 5]
            {
                { -9, 8, 9, 16, -18 },
                { -13, -11, -20, -15, 9 },
                { 18, 13, -12, -15, -11 },
                { 10, -2, 19, -4, -10 },
                { 6, -20, -4, 13, -14 }
            };

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            // Проверяем: четные значения в 4-й строке заменены на 0
            Assert.AreEqual(0, result[3, 0]);
            Assert.AreEqual(0, result[3, 1]);
            Assert.AreEqual(19, result[3, 2]);
            Assert.AreEqual(0, result[3, 3]);
            Assert.AreEqual(0, result[3, 4]);
        }
    }
}
