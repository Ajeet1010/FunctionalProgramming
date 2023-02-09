using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Prime
    {
        // A function to print all prime factors of a number
        public void Factors()
        {
            Console.WriteLine("\nEnter the no to print prime factors: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // To check whether the prime no is greater than 2 or not
            if (num > 2)
                Console.Write(num + " is greater than 2\n");
            else
                Console.WriteLine(num + " No should be greater than 2\n");

            // Print the number of 2s that divide n
            while (num % 2 == 0)
            {
                Console.Write(2 + "    ");
                num /= 2;
            }

            for (int i = 3; i <= num; i += 2)
            {
                // While i divides num, print i and divide num
                while (num % i == 0)
                {
                    Console.Write(i + "    ");
                    num /= i;
                }
            }
        }
    }
}
