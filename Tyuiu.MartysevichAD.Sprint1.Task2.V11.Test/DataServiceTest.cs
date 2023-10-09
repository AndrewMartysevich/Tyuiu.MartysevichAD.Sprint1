using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint1.Task2.V11.Lib;

namespace Tyuiu.MartysevichAD.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(3660, res);

        }
    }
}
