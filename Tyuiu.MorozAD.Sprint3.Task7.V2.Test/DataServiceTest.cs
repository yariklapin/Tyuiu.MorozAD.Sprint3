using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint3.Task7.V2.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task7.V2.Test
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

            int len = stopvalue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 58.78;
            valueWaitArray[1] = 37.79;
            valueWaitArray[2] = -3.45;
            valueWaitArray[3] = -20.32;
            valueWaitArray[4] = -9.34;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -8.26;
            valueWaitArray[7] = -20.73;
            valueWaitArray[8] = -4.11;
            valueWaitArray[9] = 37.46;
            valueWaitArray[10] = 58.89;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopvalue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
