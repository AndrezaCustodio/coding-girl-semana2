using System;
using System.Collections.Generic;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nDigite o código do aluno: ");
            int i = int.Parse(Console.ReadLine());

            List<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno());
            
            lista[i].Imprimir();
        }
    }
}
