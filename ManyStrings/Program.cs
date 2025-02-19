using System;

namespace ManyStrings
{
    public class Program
    {
        private const string T1 = "Hello, LP1!\nNew line.";
        private const string T2 = "Name:\tFrancisco";
        private const string T3 = "He said: \"Hi, how are you?\"";
        private const string T4 = "The file path is C:\\Users\\Francisco\\Documents";
        private const string T5 = "Heart: \u2764";
        private const string T6 = "Euro: \u20AC";

        private static readonly string T8 = "a" + 2;
        private const string T9 = "abc" + " x";    
        private const int X = 5;
        private static readonly string T10 = "abc" + X;
        private static readonly string T11 = $"Value of x is {X}";
        private const int Y = 10;
        private static readonly string T12 = $"{X} plus {Y} is equal to {X + Y}";

        private static void Main(string[] args)
        {
            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
            Console.WriteLine(T4);
            Console.WriteLine(T5);
            Console.WriteLine(T6);
            
            Console.WriteLine(T8);
            Console.WriteLine(T9);
            Console.WriteLine(T10);
            Console.WriteLine(T11);
            Console.WriteLine(T12);
        }
    }
}
