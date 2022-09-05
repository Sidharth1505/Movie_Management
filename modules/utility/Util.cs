using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Management
{
    class Util
    {
        public static string GetandCheckInput()
        {
            string output;
            while (true)
            {
                try
                {
                    output = Console.ReadLine();

                    if (output == "") throw new FormatException();
                }
                catch
                {
                    Console.WriteLine("Enter a Valid Detail");
                    continue;
                }
                return output;
            }
        }

        public static void DisplayError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{text}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DisplaySuccess(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{text}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
