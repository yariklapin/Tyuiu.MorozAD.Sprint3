using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozAD.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
           double multyplaySeries = 1;
           int k;
           for (k = startValue; k <= stopValue; k++)
            {
                multyplaySeries = multyplaySeries*(k / Math.Pow(Math.Sin(1), -10));
            }
            return Math.Round(multyplaySeries,3);
        }
    }
}
