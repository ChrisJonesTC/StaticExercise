using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahreneit to Celsius");
            var tempC = TempConverter.FahrenheitToCelsius(32);
            Console.WriteLine(tempC);
            
            Console.WriteLine("Celsius to Fahreneit");
            var  tempF = TempConverter.CelsiusToFahrenheit(0);
           Console.WriteLine(tempF);
        }

    }  

}
