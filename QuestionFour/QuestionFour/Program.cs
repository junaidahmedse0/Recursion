using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Program that finds maximal sequence of equal elements in an array");
            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int currentSequence = 1;
            int longestSequence = 1;
            int indexOfLongest=0;
            for (int i = 0; i < arr.Length-1; i++)
            {

                if (arr[i] == arr[i + 1])
                {
                    currentSequence++;


                }
                else
                {
                    if (longestSequence < currentSequence)
                    {

                        longestSequence = currentSequence;
                        indexOfLongest = i - currentSequence + 1;

                    }
                    currentSequence = 1;


                }

            }


            for (int i = indexOfLongest; i < indexOfLongest + longestSequence; i++)
            {

                Console.Write("" + arr[i]);

            }

            Console.ReadKey();
        }
    }
}
