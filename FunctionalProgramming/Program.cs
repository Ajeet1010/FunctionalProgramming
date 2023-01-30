namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Basic Core Programs  -----");
            LeapYear leapYear = new LeapYear();
            leapYear.Ensure();
        }
    }
}