using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.WriteLine("*******************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                         *");
                Console.WriteLine("*******************************************");

                
                int startValue = 1;
                int stopValue = 10;

                
                Console.WriteLine("Старт Шага = " + startValue);
                Console.WriteLine("Конец Шага = " + stopValue);

                Console.WriteLine("*******************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                               *");
                Console.WriteLine("*******************************************");

                Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(startValue, stopValue));

                Console.ReadKey();
            }
        }
}
