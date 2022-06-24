using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace exercicio2
{
    public class Calculadora
    {
        private double ValorTotal = 0;


        public Calculadora()
        {
            Console.WriteLine("Calculadora v1.0 \n");
            // Inicializar o Menu da Calculadora pela primeira vez.
            ApresentarMenu();
        }

        private void ApresentarMenu()
        {
            // Limpando nosso Terminal.
            Console.Clear();

            // Apresentando as opções que o usuário pode escolher.

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Reiniciar a calculadora");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Escolha qual operação deseja realizar:");
            Console.Write("> ");
            // Aguardo/Capturo a alternativa escolhida pelo Usuário.
            string EscolhaDoUsuario = Console.ReadLine();
            Console.WriteLine($"Você escolheu {EscolhaDoUsuario}");
            Console.WriteLine("Digite o valor que deseja calcular:");
            Console.Write("> ");
            string ValorDoUsuario = Console.ReadLine();
            // Tento converter o valor que o Usuário deseja calcular.
            bool ConverterValorDoUsuario = double.TryParse(ValorDoUsuario, out double ValorConvertido);
            Console.WriteLine($"Você escolheu {EscolhaDoUsuario}");

            // Tratar as Excessões das Operações.
            try
            {
                // Se for possível converter o valor do Usuário poderá realizar a operação matemática.
                if (ConverterValorDoUsuario)
                {
                    switch (EscolhaDoUsuario)
                    {
                        case "1":

                            Somar(ValorConvertido);

                            break;

                        case "2":
                            Subtrair(ValorConvertido);
                            break;

                        case "3":
                            Multiplicar(ValorConvertido);
                            break;
                        case "4":
                            Dividir(ValorConvertido);
                            break;

                        case "5":
                            Console.WriteLine("Você escolheu 5 - Reiniciar a calculadora.");
                            // Chamar o método responsável por Reiniciar a calculadora.
                            Reiniciar();
                            break;

                        default:
                            ApresentarMenu();
                            break;
                    }
                }
                // Caso contrário, teremos um Error/Excessão e iremos tratar o Erro/Excessão.
                else
                {
                    throw new Exception("CodError002 - O usuário não pode inserir qualquer valor além de números.");
                }

            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
                Console.WriteLine(Error.GetType());
                Console.WriteLine(Error.StackTrace);
            }
            finally
            {
                Thread.Sleep(2000);
                ApresentarMenu();
            }
        }

        private void Somar(double Valor)
        {
            ValorTotal += Valor;

            //ApresentarMenu();

        }

        private void Subtrair(double Valor)
        {
            ValorTotal -= Valor;
            ApresentarMenu();
        }

        private void Dividir(double Valor)
        {
            try
            {
                if (Valor == 0)
                {
                    throw new Exception("CodError001 - Divisão por 0 não é possível.");
                }
                else
                {
                    ValorTotal /= Valor;
                }
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
                Console.WriteLine(Error.GetType());
                Console.WriteLine(Error.StackTrace);
            }
            finally
            {
                Thread.Sleep(2000);
                ApresentarMenu();
            }

        }

        private void Multiplicar(double Valor)
        {
            ValorTotal *= Valor;
            ApresentarMenu();
        }

        private void Reiniciar()
        {
            ValorTotal = 0;
            ApresentarMenu();
        }
    }
}
