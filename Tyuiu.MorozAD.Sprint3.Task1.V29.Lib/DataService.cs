using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozAD.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * ((Math.Pow(value, 2) *startValue) + 2);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
