using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
/// </summary>
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Number("Введите число");
            Func(n);
           Console.ReadKey();
        }
        static int Number(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static void Func(int n)
        {
            for (int x=1;x <= n;x++)
            {
                Console.WriteLine(x);
            }
        }
        
    }
}
