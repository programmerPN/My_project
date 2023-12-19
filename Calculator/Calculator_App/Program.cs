using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App by NOVAK\nPress \"Enter\" to continue or press \"Q\" to Exit the aplication.");

            while (true)
            {
                if (Console.ReadLine().ToLower() == "q")
                {
                    break;
                }
                try
                {
                    Console.Write("Select an action: +, -, *, /          \nselected: ");
                    string action = Console.ReadLine();

                    Console.Write("Enter a first number: ");
                    float number1 = EnteredNumber();

                    Console.Write("Enter a second number: ");
                    float number2 = EnteredNumber();

                    Console.WriteLine("The result of the action is: " + Calculate(number1, number2, action));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);//"Wrong data type."); <-- dont works good, always shows this message
                }
            }
        }
        private static float Calculate(float num1, float num2, string action)
        {
            switch (action)
            {
                case "+" :
                    return num1 + num2;
                case "-" :
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    throw new Exception("Selected wrong action!.");
            }
        }

        private static float EnteredNumber()
        {
            //return int.Parse(Console.ReadLine()); 
            if (!float.TryParse(Console.ReadLine(), out float number))
                throw new Exception("Wrong data type.");

            return number;
        }

        
    }
}
