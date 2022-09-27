using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {

        //C = (F – 32) * 5 / 9
        public static double FahrenheitToCelsius(double tempF)
            {
                var answer = (tempF - 32) * 5 / 9;
                return answer;
            }

        // F = (C * 9) / 5 + 32
        public static double CelsiusToFahrenheit(double tempC)
            {
                var answer =  (tempC * 9) / 5 + 32;
                return answer;
            }
        

        //Now create a static class called TempConverter.
        //The class should have at least 2 methods,
        //one called FahrenheitToCelsius that will require a double as a parameter and return a double,
        //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.



        //Fill out these methods and call them in your Program.cs file.Make sure they’re accurate!
    }
}
