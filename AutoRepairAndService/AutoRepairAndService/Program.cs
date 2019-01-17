using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Advanced - Problem from Exercise /Stacks & Queues/

            string[] inputCars = Console.ReadLine().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var cars = new Queue<string>(inputCars);

            var servedCars = new Stack<string>();

            while (inputCars[0] != "End")
            {
                if (inputCars[0] == "Service")
                {
                    string carServed = cars.Peek();
                    servedCars.Push(carServed);
                    Console.WriteLine($"Vehicle {cars.Dequeue()} got served.");
                }
                else if (inputCars[0] == "CarInfo")
                {
                    string carToCheck = inputCars[1];
                    if (servedCars.Contains(carToCheck))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (inputCars[0] == "History")
                {
                    if (servedCars.Count != 0)
                    {
                        Console.WriteLine($"{string.Join(", ", servedCars)}");
                    }
                    if (cars.Count != 0)
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
                    }
                }



                inputCars = Console.ReadLine().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}
