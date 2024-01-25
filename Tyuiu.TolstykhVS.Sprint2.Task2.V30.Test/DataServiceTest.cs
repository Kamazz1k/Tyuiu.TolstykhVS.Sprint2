using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint2.Task2.V30.Lib;

namespace Tyuiu.TolstykhVS.Sprint2.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4, y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }

}
