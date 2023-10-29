using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint3.Task4.V11.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopvalue = 5;

            double res = ds.Calculate(startValue, stopvalue);

            double wait =-0.917;
            Assert.AreEqual(wait, res);
        }
    }
}
