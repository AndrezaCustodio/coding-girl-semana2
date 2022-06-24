using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    public class MundoAnimal
    {
        Peixe peixe = new Peixe("Dory", 0, "azul brilhante e amarelo", "marítimo", 7, "blue tang");
        Mamifero mamifero = new Mamifero("Gato", 4, "branco e preto", "terrestre", 15, "carne");

        public MundoAnimal()
        {
            peixe.Imprimir();
            mamifero.Imprimir();
        }
    }
}
