using System;


namespace exercicio2
{
    public class Empregado
    {
        public string nome;
        public string cargo;
        public double salario;

        public double Salario
        {
            get
            {
                return this.salario;
            }
            set
            {
                if (this.salario < 0)
                {
                    this.salario = 0.0;
                }
            }
        }

        public Empregado(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public Empregado()
        {
        }

        public void Aumento()
        {
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
        }

        public void SalarioAtualizado()
        {
            Console.WriteLine($" {this.nome} seu novo salário é: {(this.salario).ToString("F")}");
        }
    }




}
