using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine("Minimum #1 : {0}", numbers.FindMinimum(2, 4));
            Console.WriteLine("Minimum #2 : {0}", numbers.FindMinimum(2, 4, 1));
            Console.WriteLine();
            Console.WriteLine("Maximum #1 : {0}", numbers.FindMaximum(9, 8));
            Console.WriteLine("Maximum #2 : {0}", numbers.FindMaximum(9, 8, 7));
            

            Console.ReadKey();
        }
    }
}
