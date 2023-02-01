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
        public  void Factors()
        {
            Console.WriteLine("Enter the no to print prime factors: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // Print the number of 2s that divide n
            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num /= 2;
            }

            // num must be odd at this point. So we can skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                // While i divides n, print i and divide n
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }

            // This condition is to handle the case when
            // n is a prime number greater than 2
            if (num > 2)
                Console.Write(num);
        }
    }
}
