using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExampleRealRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file Path:: ");
            string path = Console.ReadLine();
            FindFiles(path);
            Console.ReadKey();
        }
        static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles(path)) 
            {

                Console.WriteLine(fileName);
            }
            foreach (string directory in Directory.GetDirectories(path))
            {

                FindFiles(directory);

            }



        }
    }
}
