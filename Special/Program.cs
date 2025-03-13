using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /// <summary>
            /// Asks the user a number and saves it on GetSpecial
            /// <summary>
            /// <param name="args"></param>
            Console.Write("Insert n-th number of the special sequence: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(number));
        }
        private static int GetSpecial(int n)
        {
            /// <summary>
            /// Checks the variable n and gets the next number on the sequence
            /// </summary>
            /// <param name="n">Number selected</param>
            /// <returns> The next number on the sequence.</returns>
            int result;
            if (n==0) {return 0;}
            else if (n==1) {return 1;}
            else
                result = GetSpecial(n-1)+2*GetSpecial(n-2);
                return result;
        }
    }
}
