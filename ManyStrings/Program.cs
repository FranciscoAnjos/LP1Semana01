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
        
        private static void Main(string[] args)
        {
            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
            Console.WriteLine(T4);
            Console.WriteLine(T5);
            Console.WriteLine(T6);
        }
    }
}
