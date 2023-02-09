using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class EvenOdd
    {
        public void No()
        {
            Console.WriteLine("\nEnter the no to check even or odd: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            if (digit % 2 == 0)
                Console.WriteLine(digit + " is a even no");
            else
                Console.WriteLine(digit + " is an odd number");
        }
    }
}
