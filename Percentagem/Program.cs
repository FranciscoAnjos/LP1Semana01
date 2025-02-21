using System;
using System.Globalization;
using System.Reflection;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {  int a = 100;
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
            

        }
    }
}
