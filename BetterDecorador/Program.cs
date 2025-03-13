using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Defines the components the user inputs
        /// And changes the string type to the correct one
        /// </summary>
        /// <param name="args">The args on the method Decor()</param>
         private static void Main(string[] args)
         {
             Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
         }
        /// <summary>
        /// Creates a string that repeats the input given to the string, s
        /// so that it can print it the right number of times
        /// </summary>
        /// <param name="phrase">The phrase given first</param>
        /// <param name="symbol">The symbol given in second place</param>
        /// <param name="numbers">The number of time the symbol will appear </param>
        /// <returns>Prints at the end </returns>
         private static string Decor (string phrase, char symbol, int numbers)
         {
             string realsymbol = " ";
             for (int i = 0; i < numbers; i++)
             {
                 realsymbol += symbol;
             }
             return $"{realsymbol} {phrase} {realsymbol}";
         }
     }
 }