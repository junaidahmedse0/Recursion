using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NUMBER:: ");
            int num = int.Parse(Console.ReadLine());
            int result = Factorial(num);
            Console.WriteLine("Result of this is:: "+result);
            Console.ReadKey();

        }
        static int  Factorial(int num)
        {
            Console.WriteLine("i am Calculating (" + "<" + num + ">" + ")");
            if (num == 0)
            {

                return 1;

            }
            int F = num * Factorial(num - 1);

            Console.WriteLine("Done ! F(" + "<" + num + ">" + ")");
            return F;


        }
    }
}
