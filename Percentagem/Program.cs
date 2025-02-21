using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please insert 4 numbers between 0 and 1");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();

            float n1a = float.Parse(n1);
            float n2a = float.Parse(n2);
            float n3a = float.Parse(n3);
            float n4a = float.Parse(n4);

            float n1m = n1a * 100;
            float n2m = n2a * 100;
            float n3m = n3a * 100;
            float n4m = n4a * 100;

            Console.WriteLine($"{n1m}%");
            Console.WriteLine($"{n2m}%");
            Console.WriteLine($"{n3m}%");
            Console.WriteLine($"{n4m}%");


        }
    }
}
