using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoMatriculado eu = new AlunoMatriculado(123, "Léo", 8, 1, 5);
            Console.WriteLine($"A média é: " + Math.Round(eu.media(), 2) + " e é necessário mais " + Math.Round(eu.notaFinal(), 2) + " para ser aprovado.");
        }
    }
}
