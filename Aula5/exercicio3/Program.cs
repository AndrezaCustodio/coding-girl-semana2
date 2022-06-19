using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira aqui o primeiro número");
            double numero1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira aqui o segundo número");
            double numero2 = Double.Parse(Console.ReadLine());

            Somar soma = new Somar();
            Console.WriteLine($"Soma: " + soma.Soma(numero1, numero2));

            Subtrair sub = new Subtrair();
            Console.WriteLine($"Subtração: " + sub.Sub(numero1, numero2));

            Multiplicar mult = new Multiplicar();
            Console.WriteLine($"Multiplicação: " + mult.Mult(numero1, numero2));

            Dividir div = new Dividir();
            Console.WriteLine($"Divisão: " + div.Div(numero1, numero2));

        }
    }
}
