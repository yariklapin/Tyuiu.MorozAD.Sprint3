using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint3.Task1.V29.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*******************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                         *");
            Console.WriteLine("*******************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт Шага = " + startValue);
            Console.WriteLine("Конец Шага = " + stopValue);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                               *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value,startValue, stopValue)); 

            Console.ReadKey();
        }
    }
}
