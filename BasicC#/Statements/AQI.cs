using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class AQI
    {
        public void air()
        {
            Console.Write("Enter the AQI value: ");
            int aqi = int.Parse(Console.ReadLine());

            Console.WriteLine($"AQI Value: {aqi}");

            if (aqi >= 0 && aqi <= 50)
                Console.WriteLine("Air Quality: Good");
            else if (aqi >= 51 && aqi <= 100)
                Console.WriteLine("Air Quality: Moderate");
            else if (aqi >= 101 && aqi <= 150)
                Console.WriteLine("Air Quality: Unhealthy for Sensitive Groups");
            else if (aqi >= 151 && aqi <= 200)
                Console.WriteLine("Air Quality: Unhealthy");
            else if (aqi >= 201 && aqi <= 300)
                Console.WriteLine("Air Quality: Very Unhealthy");
            else if (aqi > 300)
                Console.WriteLine("Air Quality: Hazardous");
            else
                Console.WriteLine("Invalid AQI value!");
        }
    }
}
