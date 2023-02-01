using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Alphabet
    {
         public void VowCons()
         {
            Console.WriteLine("Enter any albhabet : ");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c  == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                Console.WriteLine("{0} is a Vowel alphabet", c);
            else
                Console.WriteLine("{0} is Consonant alphabet", c);
         }
    }
}
