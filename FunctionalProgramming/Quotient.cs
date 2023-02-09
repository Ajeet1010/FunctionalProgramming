using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Quotient
    {
        public void QueRem()
        {
            Console.WriteLine("\nEnter the no to divisible");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no to divide");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = Dividend / Divisor;
            int Remainder = Dividend - (Divisor * Quotient);

            Console.WriteLine("\nQuotient for " + Dividend + " divides by " + Divisor + " is: {0}", +Quotient);
            Console.WriteLine("Remainder for " + Dividend + " divides by " + Divisor + " is: {0}", +Remainder);
        }
    }
}
