using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número maior que zero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }


            Console.WriteLine("\nVocê digitou esses números");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nEsses são os números pares");

            foreach (int num in pares)
            {
                if (num != 0) Console.WriteLine(num);
            }

            Console.WriteLine("\n\nEsses são os números ímpares");

            foreach (int num in impares)
            {
                if (num != 0) Console.WriteLine(num);
            }
        }
    }
}
