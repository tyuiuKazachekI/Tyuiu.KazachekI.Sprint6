using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint6.Task0.V29.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double expected = Math.Round((Math.Pow(3, 3) - 1) / (4 * Math.Pow(3, 2)), 3);
            Assert.AreEqual(expected, res);
        }
    }
}
