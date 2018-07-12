using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number for Fib Series:: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                long fib = Fib(i);
                Console.Write(" " + fib);

            }
            Console.ReadKey();

        }
        static long Fib(int n)
        {

            if (n < 2)
            {


                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);


        }
    }
}
