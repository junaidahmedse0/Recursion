using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayEqual = true;
            char[] arrA = new char[] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrB = new char[] { 'a', 'b', 'c', 'd', 'e' };
            if (arrA.Length > arrB.Length)
            {
                Console.WriteLine("Second array is lexicographical first");

            }
            else if (arrA.Length < arrB.Length)
            {
                Console.WriteLine("First array is lexicograhical first");

            }
            else
            {

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] < arrB[i])
                    {

                        Console.WriteLine("First array is lexicograhical first");
                        arrayEqual = false;
                        break;
                    }
                    if (arrA[i] > arrB[i])
                    {

                        Console.WriteLine("Secondary array is lexicographical first");
                        arrayEqual = false;
                        break;

                    }
                    
                }


            }
            if (arrayEqual)
            {
                Console.WriteLine("arraysare lexiocgrahically equal");
            }
            Console.ReadKey();
        }
    }
}
