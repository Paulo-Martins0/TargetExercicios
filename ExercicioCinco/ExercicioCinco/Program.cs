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
            //Pega todas as letras presentes na string e coloca em uma array de chars
            char[] letras = str.ToCharArray();

            //Usa do metodo Reverse presente na Array para inverter a ordem das letras no array
            Array.Reverse(letras);

            //retorna a string
            return new string(letras);
        }
    }
}
