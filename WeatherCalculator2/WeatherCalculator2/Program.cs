﻿using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            // determine heat index or wind chill
            bool isabove = temperature > 50;

            if (isabove)
            {
                //get relitive humidity
                Console.WriteLine("Enter relitive humidity");

                input = Console.ReadLine();

                int relhum = int.Parse(input);

                //calculate heat index

                double p1 = (temperature - 68) * 1.2;
                double p2 = relhum * 0.094;
                double HI = (temperature + 61 + p1 + p2) * 0.5;
                Console.WriteLine("The heat index is " + HI);
            }
            else
            {// Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill); }
        }
    }
}
