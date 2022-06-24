using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2
{
    public class Empregado
    {
        //atributos
        public string nome;
        public string cargo;
        public double salario;
        public double salarioAtualizado;


        public String Nome
        {
            get;
            set;
        }

        public String Cargo
        {
            get;
            set;
        }

        public String Salario
        {
            get;
            set;
        }

        public String SalarioAtualizado
        {
            get;
            set;
        }

        public Empregado()
        {
            Console.WriteLine("\nInsira o nome: ");
            Nome = Console.ReadLine();
            this.nome = Nome;

            Console.WriteLine("Insira o cargo: ");
            Cargo = Console.ReadLine();
            this.cargo = Cargo;

            Console.WriteLine("Insira o salario: ");
            Salario = Convert.ToDouble(Console.ReadLine());
            this.salario = Salario;

            this.salarioAtualizado = SalarioAtualizado;


            Console.WriteLine($"Nome do funcionário: {Nome}\nCargo: {Cargo}");
            ImprimirSalario(Salario);
        }

        private void ImprimirSalario(double Salario)
        {
            if (Salario < 0)
            {
                Salario = 0.0;
                Console.WriteLine($"Salário: R$ {Salario:0.00}");
            }
            else
            {
                Console.WriteLine($"Salário: R$ {Salario:00.00}");
                Aumento(Salario);
            }
        }

        private void Aumento(double Salario)
        {
            double ValorAumento;
            if (this.salario <= 400)
            {

                this.salario = this.salario * 1.15;
            }
            else if (this.salario <= 800)
            {

                this.salario = this.salario * 1.12;
            }
            else if (this.salario <= 1200)
            {

                this.salario = salario * 1.10;
            }
            else if (this.salario <= 2000)
            {

                this.salario = this.salario * 1.07;
            }
            else
            {

                this.salario = this.salario * 1.04;
            }

            ValorAumento = Salario;


            Console.WriteLine($" {this.nome} seu novo salário é: {(this.Salario).ToString("F")}");
            
        }

    }
}
