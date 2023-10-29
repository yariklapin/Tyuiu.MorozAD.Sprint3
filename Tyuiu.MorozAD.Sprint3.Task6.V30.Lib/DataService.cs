using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozAD.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int k = 0;
            for(x = startValue; x <= stopValue; x++)
            {
                for(int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        k += 1;
                    }
                }
            }
            return k;
        }
    }
}
