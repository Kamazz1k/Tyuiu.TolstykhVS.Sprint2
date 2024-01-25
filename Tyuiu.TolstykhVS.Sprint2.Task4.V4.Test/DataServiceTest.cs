using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint2.Task4.V4.Lib;

namespace Tyuiu.TolstykhVS.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 2);

            Assert.AreEqual(3.583, res, 0.001);
        }
    }
}
