using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class PowerOf2
    {
        public void Power()
        {
            Console.WriteLine("Enter the no to check power value");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
