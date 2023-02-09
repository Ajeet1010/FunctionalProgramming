namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Basic Core Programs  -----");
            Console.Write("1. Flip Coin\n2. Leap Year\n3. Power Of 2\n4. Harmonic No\n5. Prime Factors\n6. Quotient Remainder\n" +
                "7. Swapping\n8. Even Odd\n9. Alphabet\n10. Largest No\nChoose option to perform:");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n----- Flip Coin  -----");
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Percentage();
                    break;

                case 2:
                    Console.WriteLine("\n----- Leap Year -----");
                    LeapYear leapYear = new LeapYear();
                    leapYear.Ensure();
                    break;

                case 3:
                    Console.WriteLine("\n----- Power Of 2  -----");
                    PowerOf2 powerOf2 = new PowerOf2();
                    powerOf2.Power();
                    break;

                case 4:
                    Console.WriteLine("\n----- Harmonic No  -----");
                    HarmonicNo harmonicNo = new HarmonicNo();
                    harmonicNo.Nth();
                    break;

                case 5:
                    Console.WriteLine("\n-----  Prime Factors -----");
                    Prime prime = new Prime();
                    prime.Factors();
                    break;

                case 6:
                    Console.WriteLine("\n----- Quotient & Remainder -----");
                    Quotient quotient = new Quotient();
                    quotient.QueRem();
                    break;

                case 7:
                    Console.WriteLine("\n-----  Swapping of two nos -----");
                    Swap swap = new Swap();
                    swap.No();
                    break;

                case 8:
                    Console.WriteLine("\n-----  Check no is Even or Odd no -----");
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.No();
                    break;

                case 9:
                    Console.WriteLine("\n-----  Check Alphabet is Vowel or Consonant -----\n");
                    Alphabet alphabet = new Alphabet();
                    alphabet.VowCons();
                    break;

                case 10:
                    Console.WriteLine("\n-----  Largest No -----");
                    Largest largest = new Largest();
                    largest.No();
                    break;
            }
        }
    }
}