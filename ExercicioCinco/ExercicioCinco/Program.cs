using System;

namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {

            string normal = "Target";
            string inversa = StringInversa(normal);
            Console.WriteLine(inversa);
        }

        static string StringInversa (string str)
        {
            string inversa = "";

            for(int i = str.Length - 1; i >= 0; i--)
            {
                inversa += str[i];
            }

            return inversa;
        }
    }
}
