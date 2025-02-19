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
        
        //chars
        private const char C1 = '\u00A9';
        private const char C2 = '\u263A';
        
        //real numbers
        private const float R1 = 3.14f;
        private const double R2 = 3.14159;
        
        //booleans
        private const bool B1 = true;
        private const bool B2 = false;

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
            
            Console.WriteLine(C1.ToString());
            Console.WriteLine(C2.ToString());
            
            Console.WriteLine(R1.ToString());
            Console.WriteLine(R2.ToString());
            
            Console.WriteLine(B1.ToString());
            Console.WriteLine(B2.ToString());
        }
    }
}
