using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Largest
    {
         public void No()
         {
            Console.Write("Enter first no: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second no: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third no: ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAll three no's are: "+first+", "+second+", "+third);
            if (first > second && first > third)
                Console.WriteLine("\nLargest number is: " + first);
            else if (second > first && second > third)
                Console.WriteLine("\nLargest number is: " + second);
            else
                Console.WriteLine("\nLargest number is: " + third);
        }
    }
}
