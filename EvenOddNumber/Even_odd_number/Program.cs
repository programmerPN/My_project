using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorText(ConsoleColor.Cyan);
            Console.WriteLine("--- Even\\Odd Number---");
            ColorText(ConsoleColor.Gray);

            while (true)
            {
                Console.Write("\nEnter number: ");
                OddEvenNumber(EnterNumber());
                Console.Write("\nPress any key to check parity of the number or press \"Q\" to Quit.\n");

                ColorText(ConsoleColor.Yellow);
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("\nQuit\n");
                    ColorText(ConsoleColor.Gray);
                    break;
                }

                ColorText(ConsoleColor.Gray);
            }
        }

        #region Methods
        private static void OddEvenNumber(int number)
        {
            int value = number;
            if ((value % 2) == 0)
            {
                Console.WriteLine("The number You enter is even.");
            }
            else
                Console.WriteLine("The number You enter is odd.");
        }

        private static int EnterNumber()
        {
            ColorText(ConsoleColor.Yellow);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    ColorText(ConsoleColor.Gray);
                    return value;
                }
                else
                {
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("Wrong data type.");
                    ColorText(ConsoleColor.Gray);
                    Console.Write("\nTray again: ");
                    ColorText(ConsoleColor.Yellow);
                    continue;
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
