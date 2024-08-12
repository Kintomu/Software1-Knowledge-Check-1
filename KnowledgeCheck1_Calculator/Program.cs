using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division, type exit to close.");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            while (input != "exit")
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        var addNumber1 = CheckIntValue();
                        var addNumber2 = CheckIntValue();

                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumber1, addNumber2));
                        Console.WriteLine();

                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        var subtractNumber1 = CheckIntValue();
                        var subtractNumber2 = CheckIntValue();

                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subtractNumber1, subtractNumber2));
                        Console.WriteLine();

                        break;

                    case "3":
                        Console.WriteLine("Enter 2 integers to Multiply");
                        var multiplyNumber1 = CheckIntValue();
                        var multiplyNumber2 = CheckIntValue();

                        Console.Write($"{multiplyNumber1} x {multiplyNumber2} = ");
                        Console.Write(calculator.Add(multiplyNumber1, multiplyNumber2));
                        Console.WriteLine();

                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        var divideNumber1 = CheckDoubleValue();
                        var divideNumber2 = CheckDoubleValue();

                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divideNumber1, divideNumber2));
                        Console.WriteLine();

                        break;

                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }

                Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division, type exit to close.");

                input = Console.ReadLine();
            }
        }

        public static int CheckIntValue()
        {
            while (true)
            {
                var number = Console.ReadLine();
                if (int.TryParse(number, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("The number is not an int, please input a new value.");
                }
            }
        }

        public static double CheckDoubleValue()
        {
            while (true)
            {
                var number = Console.ReadLine();
                if (double.TryParse(number, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("The number is not an int, please input a new value.");
                }
            }
        }
    }
}
