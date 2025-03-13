using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int number = int.Parse(Console.Readline());
            Console.WriteLine(GetSpecial(number));
        }
    }
}
