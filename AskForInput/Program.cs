using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please insert a whole number");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            Console.WriteLine("Now insert a real number");
            string c = Console.ReadLine();
            float d = float.Parse(c);
            float s = d + b;
            Console.WriteLine($"The sum of your numbers is {s} ");
        }
    }
}
