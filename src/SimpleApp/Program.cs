using System;

namespace SimpleApp
{
    public static class MathService
    {
        public static int Add(int a, int b) => a + b;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("SimpleApp running.");
            Console.WriteLine($"2 + 3 = {MathService.Add(2, 3)}");
        }
    }
}
