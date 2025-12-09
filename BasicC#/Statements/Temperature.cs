using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class Temperature
    {
        public void temp()
        {
         
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.Write("Enter your choice 1 or 2 ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Celsius to Fahrenheit
                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == "2")
            {
                // Fahrenheit to Celsius
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
    }
}
