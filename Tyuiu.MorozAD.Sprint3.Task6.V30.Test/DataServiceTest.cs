﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint3.Task6.V30.Lib;
namespace Tyuiu.MorozAD.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}
