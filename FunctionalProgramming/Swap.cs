using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Swap
    {
        public void No()
        {
            Console.WriteLine("\nEnter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine("First no: " + a + "\nSecond no: " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping\nFirst no: " + a + "\nSecond no: " + b);
        }
    }
}
