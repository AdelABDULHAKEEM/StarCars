using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsCalculator CC = new CarsCalculator()
            {
                Height = 3678.5,
                Width = 68784.98,
                Class = 'A'

            };
            double Weight = CC.GetCarWeight();

            Console.WriteLine($"The Car Weight is : {Weight} ");

          if(Weight <= 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed!");
            }
          else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succeeded!");
            }
            Console.ReadKey();
        }
    }
}
