using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1
{
    public class Aluno
    {
        //atributos privados (restringidos)
        private string nome;
        private double nota1, nota2;
        private double frequencia;


        public string Nome 
        { 
            get; 
            set; 
        }
        public double Nota1
        {
            get;
            set;
        }
        public double Nota2
        {
            get;
            set;
        }
        public double Frequencia
        {
            get;
            set;
        }


        public Aluno()
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Frequencia = frequencia;
            Cadastrar();
        }

        public void Cadastrar()
        {
            Console.WriteLine("Insira aqui o nome do aluno: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira aqui a nota 1: ");
            Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira aqui a nota 2: ");
            Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira aqui a frequencia: ");
            Frequencia = double.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Nota 1: " + Nota1);
            Console.WriteLine("Nota 2: " + Nota2);
            Console.WriteLine("Frequência: " + Frequencia);
        }
    }
}
