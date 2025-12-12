using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KazachekI.Sprint6.Task7.V2.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempPath = Path.GetTempFileName();

            string csv =
                "-19;-8;-5;17;13;-6;20;3;8;3\n" +
                "-8;-14;20;11;-8;12;-13;-13;-11;-6\n" +
                "-8;20;14;-8;-8;10;-13;8;-10;-15\n" +
                "17;16;-20;-16;-9;20;-13;-15;-12;3\n" +
                "-18;-16;-16;-18;1;8;8;2;-3;1\n" +
                "-7;0;-5;4;-19;-11;-18;20;16;-1\n" +
                "6;7;1;-8;-19;17;-11;0;15;18\n" +
                "6;15;1;-5;-4;-6;12;-11;-19;-19\n" +
                "15;-10;16;16;6;0;16;17;-10;-10\n" +
                "19;7;5;-9;-4;12;19;-20;8;10";

            File.WriteAllText(tempPath, csv);

            DataService ds = new DataService();
            int[,] result = ds.GetMatrix(tempPath);

            int[,] expected =
            {
                { -19,-8,-5,17,13,-6,20,3,8,3 },
                { 555,555,555,11,555,555,-13,-13,-11,555 },
                { -8,20,14,-8,-8,10,-13,8,-10,-15 },
                { 17,16,-20,-16,-9,20,-13,-15,-12,3 },
                { -18,-16,-16,-18,1,8,8,2,-3,1 },
                { -7,0,-5,4,-19,-11,-18,20,16,-1 },
                { 6,7,1,-8,-19,17,-11,0,15,18 },
                { 6,15,1,-5,-4,-6,12,-11,-19,-19 },
                { 15,-10,16,16,6,0,16,17,-10,-10 },
                { 19,7,5,-9,-4,12,19,-20,8,10 }
            };

            for (int i = 0; i < expected.GetLength(0); i++)
                for (int j = 0; j < expected.GetLength(1); j++)
                    Assert.AreEqual(expected[i, j], result[i, j]);
        }
    }
}
