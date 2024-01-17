using System;

namespace ProjectCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Choose the desired operation: ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("--------");
            Console.WriteLine("Select an option: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Addition()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"the result of the Addition is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = (v1 - v2);
            Console.WriteLine($"The result of the subtraction is {result}");

            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"The result of the division is {result}");

            Console.ReadKey();
            Menu();

        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;
            Console.WriteLine($"The result of multiplication is {result}");

            Console.ReadKey();
            Menu();

        }

    }

}