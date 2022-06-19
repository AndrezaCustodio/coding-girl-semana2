using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio1
{
    class AlunoMatriculado
    {
        private int matricula;
        private string nome;
        private double n1, n2, trabalho;

        public AlunoMatriculado(int m, String n, double n1, double n2, double t)
        {
            matricula = m;
            nome = n;
            this.n1 = n1;
            this.n2 = n2;
            trabalho = t;
        }

        public double media()
        {
            return ((n1 + n2) * 2.5 + trabalho * 2) / 7;
        }

        public double notaFinal()
        {
            double media1 = media();
            if (media1 < 2.5 || media1 >= 5)
                return 0;

            return 10 - media1;
        }

        public static double round(double value, int places)
        {
            if (places < 0) throw new InvalidOperationException();

            long factor = (long)Math.Pow(10, places);
            value = value * factor;
            long tmp = (long)Math.Round(value);
            return (double)tmp / factor;


        }
    }
}
