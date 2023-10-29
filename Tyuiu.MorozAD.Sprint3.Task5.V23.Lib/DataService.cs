using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozAD.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;

            for (i = startValue1; i <= startValue1; i++)
            {
                for(j = startValue2; j <= startValue2; j++)
                {
                    res = res + ((Math.Pow(x, j) + 2) * (Math.Cos(j)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
