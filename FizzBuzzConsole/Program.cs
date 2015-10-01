using System;
using FizzBuzzLib;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz(1, 100);

            foreach (var result in fb.GetResults())
                Console.WriteLine(result);
        }
    }
}
