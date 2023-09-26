using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint1.Task4.V21.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10, y = 1, wait = Math.Sqrt(10) / 30, res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
