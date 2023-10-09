using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint1.Task3.V7.Lib;

namespace Tyuiu.MartysevichAD.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double verst = 1;
            double wait = 1.0668;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);
        }
    }
}
