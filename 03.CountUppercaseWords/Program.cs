using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = str => char.IsUpper(str[0]);

            Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(w => predicate(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
