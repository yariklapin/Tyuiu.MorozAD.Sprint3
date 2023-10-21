using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint3.Task3.V26.Lib;

namespace Tyuiu.MorozAD.Sprint3.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                        *");
            Console.WriteLine("*******************************************");

            string value = "have a nice time";
            char chr = 'e';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                             *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Коллво символов = " + ds.GetCharCount(value,chr));

            Console.ReadKey();




        }
    }
}
