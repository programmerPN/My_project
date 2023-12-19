using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SayHelloToYou_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delay(1000);
            Console.WriteLine("\t\t\t\t\t Say Hello to You.");
            Delay(1000);
            Console.WriteLine("Follow the instructions.\n");

            Delay(1000);
            Console.Write("Enter Your name: ");
            ColorText(ConsoleColor.Yellow);
            string name = Console.ReadLine();
            ColorText(ConsoleColor.Green);
            Delay(500);
            Console.WriteLine("Data entered.");
            ColorText(ConsoleColor.Gray);

            Delay(500);
            Console.Write("\nEnter Your year of birth: ");
            ColorText(ConsoleColor.Yellow);
            int yearBirth = EnteredYear();

            Delay(500);
            Console.Write("\nEnter Your month of birth: ");
            ColorText(ConsoleColor.Yellow);
            int monthBirth = EnteredMonth();

            Delay(500);
            Console.Write("\nEnter Your day of birth: ");
            ColorText(ConsoleColor.Yellow);
            int dayBirth = EnteredDay(yearBirth,monthBirth);

            Delay(500);
            Console.Write("\nEnter Your place of birth: ");
            ColorText(ConsoleColor.Yellow);
            string place = Console.ReadLine();
            ColorText(ConsoleColor.Green);
            Delay(500);
            Console.WriteLine("Data entered.");
            ColorText(ConsoleColor.Gray);

            DateTime birthDate = new DateTime(yearBirth, monthBirth, dayBirth);
            Delay(1000);
            ColorText(ConsoleColor.Cyan);
            Console.WriteLine($"\n\t\t\t\tHello {name}, You born in {place} and You are {MyAge(birthDate)} years old.\n\n");
            ColorText(ConsoleColor.Gray);
            Delay(5000);
        }

        private static int EnteredYear()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value >= DateTime.Today.Year)
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Please enter correct year.");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else if (value <= 1900)
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Wrong value. Please enter right details. ");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Green);
                        Console.WriteLine("Data entered.");
                        ColorText(ConsoleColor.Gray);
                        return value;
                    }
                }
                else
                {
                    Delay(500);
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("Wrong data type.");
                    ColorText(ConsoleColor.Gray);
                    Delay(500);
                    Console.Write("Try again: ");
                    continue;
                }
            }
        }

        private static int EnteredMonth()
        {
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    if(value > 12)
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Are You sure we have more than 12 months old ? ");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else if(value <= 0)
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Are You sure we have 0 or less months old ? ");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Green);
                        Console.WriteLine("Data entered.");
                        ColorText(ConsoleColor.Gray);
                        return value;
                    }
                }
                else
                {
                    Delay(500);
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("Wrong data type.");
                    ColorText(ConsoleColor.Gray);
                    Delay(500);
                    Console.Write("Try again: ");
                    continue;
                }
                
            }
        }

        private static int EnteredDay(int year, int month)
        {
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value > DateTime.DaysInMonth(year, month))
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Uncorrect value. Please enter right value.");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else if (value <= 0)
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Red);
                        Console.WriteLine("Are You sure? Please enter correct data.");
                        ColorText(ConsoleColor.Gray);
                        Delay(500);
                        Console.Write("Try again: ");
                        continue;
                    }
                    else
                    {
                        Delay(500);
                        ColorText(ConsoleColor.Green);
                        Console.WriteLine("Data entered.");
                        ColorText(ConsoleColor.Gray);
                        return value;
                    }

                }
                else
                {
                    Delay(500);
                    ColorText(ConsoleColor.Red);
                    Console.WriteLine("Wrong data type.");
                    ColorText(ConsoleColor.Gray);
                    Delay(500);
                    Console.Write("Try again: ");
                    continue;
                }
            }
        }

        private static int MyAge(DateTime birth)
        {
            if (DateTime.Today.DayOfYear >= birth.DayOfYear)
                return DateTime.Today.Year - birth.Year;
            else
                return (DateTime.Today.Year - birth.Year) - 1;

        }


        private static void ColorText(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        private static void Delay(int value)
        {
            Thread.Sleep(value);
        }
    }
}
