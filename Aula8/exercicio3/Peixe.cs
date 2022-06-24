using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    //peixe herdou a classe animal
    public class Peixe : Animal
    {
        private string caracteristica;

        public string Caracteristica
        {
            get;
            set;
        }

        //contrutor
        public Peixe(string nome, double numeroPatas, string cor, string ambiente, double velocidadeMedia, string caracteristica)
            : base(nome, numeroPatas, cor, ambiente, velocidadeMedia)
        {
            this.nome = nome;
            this.numeroPatas = numeroPatas;
            this.cor = cor;
            this.ambiente = ambiente;
            this.velocidadeMedia = velocidadeMedia;
            this.Caracteristica = caracteristica;

        }

        public void Imprimir()
        {
            Console.WriteLine("\nPEIXE");
            ImprimirAnimal();
            Console.WriteLine("Característica: "+ Caracteristica);
        }
    }
}
