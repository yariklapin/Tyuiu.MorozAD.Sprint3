using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint3.Task1.V29.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DatServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 13051.34;

            Assert.AreEqual(wait, res);

        }
    }
}
