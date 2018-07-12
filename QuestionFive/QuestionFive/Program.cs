using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length:: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;
            Console.WriteLine("Enter element:: ");
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = int.Parse(Console.ReadLine());
                

            }
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {

                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;

                    }
                }
                else
                    sames = 1;


            }

            for (int i = bestStart; i < lastElement + bestStart; i++)
            {

                Console.Write("{0}, ", arr[i]);
            }
            Console.ReadKey();

        }
    }
}
