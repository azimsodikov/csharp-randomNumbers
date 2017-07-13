using System;
using System.Collections.Generic;


namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random random = new Random();
            // Create a list
            List<double> randomNumbers = new List<double>();
            List<double> squareNumbers = new List<double>();
            List<double> evenNumbers = new List<double>();
            // Populate the list
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(random.Next(1, 50));
            }

            foreach (var item in randomNumbers)
            {
                squareNumbers.Add(Math.Sqrt(item));
            }
            foreach (var item in squareNumbers)
            {
            //    Console.WriteLine(item);
            }
            squareNumbers.RemoveAll(i => i % 2 != 0);
            foreach (var item in squareNumbers)
            {
               Console.WriteLine($"These are the only even numbers {item}");
            }
        }
    }

}
