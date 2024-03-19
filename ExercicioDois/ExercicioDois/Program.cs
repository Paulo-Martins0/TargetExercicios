using System;
using System.Reflection.Emit;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new List<int>{ 0, 1, 1, 2 };
            int num = 13;

            while(fibonacci.Count < num) 
            {
                var anterior1 = fibonacci[fibonacci.Count - 1];
                var anterior2 = fibonacci[fibonacci.Count - 2];

                int prox = anterior1 + anterior2;

                fibonacci.Add(prox);
                Console.WriteLine(prox);

            }

            if (fibonacci.Contains(num))
            {
                Console.WriteLine($"A sequência contém {num}");
            }
            else
            {
                Console.WriteLine($"A sequência não contém {num}");
            }

            

            
            
        }
    }
}