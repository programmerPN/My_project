using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();
            Console.WriteLine("\t\t\t\t--- FizzBazz Game ---");

            while (true)
            {
                Console.Write("\nEnter an integer: ");
                Console.WriteLine(fizzBuzz.FizzBuzz(EnterNumber()));
                ColorText(ConsoleColor.Gray);
                Console.WriteLine("\nPress any key to continue game or press \"Q\" to Quit");
                ColorText(ConsoleColor.Yellow);
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("\nQuit");
                    ColorText(ConsoleColor.Gray);
                    break;
                }
                ColorText(ConsoleColor.Gray);
            }
        }
        #region Methods
        private static int EnterNumber()
        {
            while (true)
            {
                ColorText(ConsoleColor.Yellow);
                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                else
                {
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("\nWrong data type. Please enter an integer\n");
                    ColorText(ConsoleColor.Gray);
                    Console.Write("Try again: ");
                    ColorText(ConsoleColor.Yellow);
                }
            }
        }
        private static void ColorText(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        #endregion
    }
}
