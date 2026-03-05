using System;

namespace CSharpFoundations
{
    class VariableExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Engineering: Data Types & Memory Analysis ---");

            // Analyzing value types and their memory footprints
            // This is fundamental for building resource-efficient systems
            Console.WriteLine($"[int]    Size: {sizeof(int)} bytes | Range: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"[long]   Size: {sizeof(long)} bytes | Range: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"[double] Size: {sizeof(double)} bytes | Range: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"[bool]   Size: {sizeof(bool)} bytes");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("System status: Ready. Foundations Module 01 verified.");
        }
    }
}
