using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint1.Task7.V8.Lib;
namespace Tyuiu.MartysevichAD.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 4.832;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
