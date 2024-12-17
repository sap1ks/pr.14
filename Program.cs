using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Function();
            Console.ReadKey();
        }
        static void Function()
        {
            for(int y=1;y<=25;y++)
            {
                Console.WriteLine("*");
            }
        }
        static void Func()
        {
            for(int x=1;x<=18;x++)
            {
                Console.Write("*");
            }
        }
    }
}
