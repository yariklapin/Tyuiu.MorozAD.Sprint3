using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint3.Task0.V30.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task0.V30
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
            int stopValue = 20;

            
            Console.WriteLine("Старт Шага = " + startValue);
            Console.WriteLine("Конец Шага = " + stopValue);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                               *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(startValue,stopValue));

            Console.ReadKey();
        }
    }
}
