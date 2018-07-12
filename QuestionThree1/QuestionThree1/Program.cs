using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <= k-i+i; j++)
                {
                    Console.Write("( {0} {1} )", i, j);


                }
            }

            Console.ReadKey();

        }
    }
}
