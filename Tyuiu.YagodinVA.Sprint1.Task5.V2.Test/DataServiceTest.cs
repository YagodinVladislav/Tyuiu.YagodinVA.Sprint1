using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int k = 23, wait = 2, res = dataService.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
