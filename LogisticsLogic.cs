using System;

namespace CSharpFoundations
{
    class LogisticsLogic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Logistics Decision Engine v1.0 ");
            
            // Step 1: User input handling
            Console.Write("Enter cargo weight (kg): ");
            string input = Console.ReadLine();
            double weight = Convert.ToDouble(input);

            Console.WriteLine("\n- Processing Strategy ---");

            // Step 2: Control Flow logic
            if (weight <= 0)
            {
                Console.WriteLine("Error: Invalid weight input.");
            }
            else if (weight < 20)
            {
                Console.WriteLine("Transport: Micro-mobility (Courier Bike).");
            }
            else if (weight <= 500)
            {
                Console.WriteLine("Transport: Standard Delivery Van.");
            }
            else
            {
                Console.WriteLine("Transport: Heavy Duty Truck.");
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("System: Decision logic executed.");
        }
    }
}
