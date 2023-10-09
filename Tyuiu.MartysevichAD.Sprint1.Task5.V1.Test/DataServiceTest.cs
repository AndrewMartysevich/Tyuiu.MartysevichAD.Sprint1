using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint1.Task5.V1.Lib;

namespace Tyuiu.MartysevichAD.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double x2 = 1;
            double y1 = 0;
            double y2 = 0;
            double res = ds.DistanceBetweenDots(x1, x2, y1, y2);
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
