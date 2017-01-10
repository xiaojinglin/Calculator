using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 0.0;
            var operation = "";
            var num2 = 0.0;
            var result = 0.0;
            var enter = "";
            while(true)
            {
                Console.WriteLine("Arithmetic Calculator");
                //Prompt the user for a valid number.
                Console.WriteLine("Please enter a number(Type \"quit\" to exit):");
                enter = Console.ReadLine();
                if (enter.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    try
                    {
                        num1 = double.Parse(enter);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }
                }
                //Prompt the user for an operation (+ - / *).
                Console.WriteLine("Please enter an operation (+ - / *)(Type \"quit\" to exit):");
                enter = Console.ReadLine();
                if (enter.ToLower() == "quit")
                {
                    break;
                }
                else if(enter == "+" || enter == "-" || enter == "*" || enter == "/")
                {
                    operation = enter;
                }
                else
                {
                    Console.WriteLine("Please enter a valid operation.");
                    continue;
                }
                //Prompt the user for another valid number.
                Console.WriteLine("Please enter another number(Type \"quit\" to exit):");
                enter = Console.ReadLine();
                if (enter.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    try
                    {
                        num2 = double.Parse(enter);
                        if(operation == "/" && num2 == 0.0)
                        {
                            Console.WriteLine("The divisor should not be 0.");
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }
                }
                //Calculate the result
                if(operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                    result = num1 / num2;
                }
                //Print the result to the screen.
                Console.WriteLine(num1 + " " + operation + " " + num2 +" = " + result);
            }
        }
    }
}
