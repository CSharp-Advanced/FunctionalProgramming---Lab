using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> calculation = x => x *= 1.2;
            Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(calculation)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
