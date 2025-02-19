using System;

namespace VariousTypes
{
    public class Program
    {
        //integrals
        private const byte N1 = 1;
        private const sbyte N2 = 2;
        private const short N3 = 5;
        private const ushort N4 = 3;
        private const int N5 = 10;
        private const uint N6 = 9;
        private const long N7 = 100;
        private const ulong N8 = 98;

        private static void Main(string[] args)
        {
            Console.WriteLine(N1.ToString());
            Console.WriteLine(N2.ToString());
            Console.WriteLine(N3.ToString());
            Console.WriteLine(N4.ToString());
            Console.WriteLine(N5.ToString());
            Console.WriteLine(N6.ToString());
            Console.WriteLine(N7.ToString());
            Console.WriteLine(N8.ToString());
        }
    }
}
