using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MartysevichAD.Sprint1.Task0.V6.Lib;
namespace Tyuiu.MartysevichAD.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
    }
}
