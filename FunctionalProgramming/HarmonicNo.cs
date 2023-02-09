using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class HarmonicNo
    {
        public void Nth()
        {
            int i, n;
            double s = 0.0;

            Console.Write("\nCalculating the harmonic series");
            Console.Write("\nInput the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\nSum of harmoinic series is: " + s);
        }
    }
}
