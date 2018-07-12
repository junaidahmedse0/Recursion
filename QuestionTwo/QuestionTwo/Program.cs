using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= k; j++)
                {

                    Console.WriteLine("( {0},{1}) ", i, j);

                }


            }
            Console.ReadKey();
        }
    }
}
