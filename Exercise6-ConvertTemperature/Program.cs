using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_ConvertTemperature
{
    class Program
    {
        //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        // K = celsius + 273
        // F = celsius * 18 / 10 + 32
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celssius Degree: ");
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine();
            double k = temp + 273.15;
            double f = temp * 18/10 + 32;

            Console.WriteLine("Temperature in Kelvin is: {0}", k);
            Console.WriteLine("Temperature in Fahrenheit is: {0}", f);

            Console.ReadLine();
        } 
    }
}
