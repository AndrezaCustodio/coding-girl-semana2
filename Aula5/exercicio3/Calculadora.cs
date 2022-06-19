using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio3
{
    public class Calculadora
    {
        public int a;
        public int b;
    }

    public class Somar
    {
        public double Soma(double a, double b)
        {
            return a + b;
        }
    }

    public class Subtrair
    {
        public double Sub(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiplicar
    {
        public double Mult(double a, double b)
        {
            return a * b;
        }
    }

    public class Dividir
    {
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
