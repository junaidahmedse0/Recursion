using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {

        public static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length == 1)
                return numbers;
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(numbers[i]);

                }

                else
                {

                    right.Add(numbers[i]);


                }


            }
            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();
            return Merge(left, right);
        }
        private static int[] Merge(List<int> left, List<int> right )
        {

            var result = new List<int>();
            while (NotEmpty(left) && NotEmpty(right))
            {

                if (left.First() <= right.First())
                {
                    if (left.First() <= right.First())
                    {
                        MoveValueFromSourceToResult(left, result);

                    }
                    else
                    {


                        MoveValueFromSourceToResult(right, result);


                    }
                }



            }
            while (NotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }
            while (NotEmpty(right))
            {
                MoveValueFromSourceToResult(right, result);
            }
            return result.ToArray();

        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }


        private static void MoveValueFromSourceToResult(List<int> left, List<int> result)
        {
            result.Add(left.First());
            left.RemoveAt(0);
        }
        public static void DoMergeSort(this int[] numbers)
        {

            var sortNumbers = MergeSort(numbers);
            for (int i = 0; i < sortNumbers.Length; i++)
            {
                numbers[i] = sortNumbers[i];

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }





        }
    }
}
