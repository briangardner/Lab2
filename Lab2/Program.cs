using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Room Detail Generator");
            do
            {
                //Prompt User
                Console.Write("Enter Length:");
                decimal length = GetValue();
                Console.Write("Enter Width:");
                decimal width = GetValue();
                Console.Write("Enter Height:");
                decimal heigh = GetValue();

                //Do Calculations
                var area = CalculateArea(length, width);
                var perimeter = CalculatePerimeter(length, width);
                var volume = CalculateVolume(length, width, heigh);

                //Output Results
                Console.WriteLine($"Area: {area}");
                Console.WriteLine("Perimeter: {0:N}", perimeter);
                Console.WriteLine("Volume: " + CalculateVolume(length, width, heigh));
            } while (ShouldContinue());
        }

        private static object CalculateVolume(decimal length, decimal width, decimal heigh)
        {
            return length * width * heigh;
        }

        private static bool ShouldContinue()
        {
            while (true)
            {
                Console.Write("Continue? y/n ");
                var promptResult = Console.ReadKey().KeyChar;
                promptResult = char.ToLower(promptResult);
                Console.WriteLine();
                switch (promptResult)
                {
                    case 'y':
                        return true;
                    case 'n':
                        return false;
                    default:
                        Console.Write("Invalid Entry. ");
                        continue;
                }
            }
        }

        private static decimal CalculatePerimeter(decimal length, decimal width)
        {
            return (length + width) * 2;
        }

        private static decimal CalculateArea(decimal length, decimal width)
        {
            return length * width;
        }


        private static decimal GetValue()
        {
            while (true)
            {
                var value = Console.ReadLine();
                if (IsValidNumber(value))
                {
                    return decimal.Parse(value);
                }

                Console.Write("Invalid entry.  Please enter another value:");
            }
        }

        private static bool IsValidNumber(string number)
        {
            return !string.IsNullOrWhiteSpace(number) && decimal.TryParse(number, out _);
        }
    }
}
