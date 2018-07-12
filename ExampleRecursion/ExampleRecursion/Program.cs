using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number For factorial:: ");
            double num = int.Parse(Console.ReadLine());
            double fact = CalculateFact(num);
            Console.WriteLine("Factorial is:: " + fact);
            Console.ReadKey();


        }
        static double CalculateFact(double number)
        {

            if (number == 0)
            {

                return 1;
            }
            return number * CalculateFact(number - 1);

        } 
    }
}
