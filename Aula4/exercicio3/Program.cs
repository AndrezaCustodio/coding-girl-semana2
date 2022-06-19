using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[5];



            for (int i = 0; i < palavras.Length; i++)
            {

                Console.WriteLine($"Digite a {i + 1}ª palavra:");

                palavras[i] = Console.ReadLine();

            }



            Array.Sort(palavras, (x, y) => x.Length.CompareTo(y.Length));



            foreach (string palavra in palavras)
            {

                Console.WriteLine($"{palavra}");

            }
        }
    }
}
