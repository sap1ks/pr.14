using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
/// </summary>
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
