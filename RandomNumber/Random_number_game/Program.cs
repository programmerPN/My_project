using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Random_number_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number1_100 = rand.Next(1, 101);

            int countGuess = 0;

            #region Introduction

            //Console.WriteLine(number1_100);
            DelayText(1000);
            ColorText(ConsoleColor.White);
            Console.WriteLine("\t\t\t\t\t ---- Random Number Game ----");
            ColorText(ConsoleColor.White);
            DelayText(2000);
            Console.WriteLine("\n\nThe computer draws a number between 1 and 100.");
            DelayText(1000);
            ProgressBar(10, 400);
            ColorText(ConsoleColor.Green);
            Console.WriteLine("\nA number has been drawn.\n");
            ColorText(ConsoleColor.Gray);
            DelayText(1000);
            Console.Write("Guess the number: ");

            #endregion

            while (true)
            {
                ColorText(ConsoleColor.Yellow);
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value > 100 || value <= 0)
                    {
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Number out of range. Please choose a number between 1 and 100.");
                        ColorText(ConsoleColor.Gray);
                        Console.Write("\nTray again: ");
                        continue;
                    }

                    else if (value == number1_100)
                    {
                        ColorText(ConsoleColor.Green);
                        Console.WriteLine("\nGreat! You guess the number!");
                        countGuess++;
                        ColorText(ConsoleColor.White);
                        ProgressBar(10, 400);
                        ColorText(ConsoleColor.Green);
                        Console.Write("\nNumber of attmepts to guess: ");
                        ColorText(ConsoleColor.Yellow);
                        Console.Write(countGuess + "\n\n");
                        DelayText(5000);
                        ColorText(ConsoleColor.Gray);
                        return;
                    }
                    else if(value < number1_100)
                    {
                        ColorText(ConsoleColor.Gray);
                        Console.Write("Too low number. \n\nTry again: ");
                        countGuess++;
                        continue;
                    }
                    else if(value > number1_100)
                    {
                        ColorText(ConsoleColor.Gray);
                        Console.Write("Too high number. \n\nTry again: ");
                        countGuess++;
                        continue;
                    }
                }
                else
                {
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("Wrong data type. Please enter a number between 1 and 100.");
                    ColorText(ConsoleColor.Gray);
                    Console.Write("\nTry again: ");
                    continue;
                }
            }
        }


        #region Methods

        private static void ProgressBar(int countLoop, int speed)
        {
            int pass = countLoop;

            for (int i = 0; i <= pass; i++)
            {
                Console.Write(".");
                DelayText(speed);
            }
        }

        private static void ColorText(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        private static void DelayText(int value)
        {
            Thread.Sleep(value);
        }

        #endregion
    }
}
