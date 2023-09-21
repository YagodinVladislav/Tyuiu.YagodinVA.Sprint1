using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.YagodinVA.Sprint1.Task2.V1.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 1;
            var res = ds.ConvertKmToM(value);
            Assert.AreEqual(1.609, res);
        }
    }
}