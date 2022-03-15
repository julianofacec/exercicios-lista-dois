using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Dois
{
    internal class Program
    {
        private const string _sim = "SIM";

        static void Main(string[] args)
        {
            string continuar = string.Empty;
            decimal valorUm = 0.0m;
            decimal valorDois = 0.0m;

            try
            {
                do
                {
                    Console.WriteLine("Informe a operação matematica " +
                        "que deseja efetuar (+, -, *, /, %): ");

                    char operacao = char.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            #region Soma
                            Console.WriteLine("Informe o primeiro valor para a soma:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a soma: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da soma é {valorUm + valorDois}");

                            #endregion #region Soma
                            break;
                        case '-':
                            #region Subtração

                            Console.WriteLine("Informe o primeiro valor para a subtração:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a subtração: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da subtração é {valorUm - valorDois}");

                            #endregion Subtração
                            break;
                        case '*':
                            #region Multiplicação

                            Console.WriteLine("Informe o primeiro valor para a multiplicação:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a multiplicação: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da multiplicação é {valorUm * valorDois}");

                            #endregion Multiplicação
                            break;
                        case '/':
                            #region Divisão

                            Console.WriteLine("Informe o primeiro valor para a divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a divisão: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da divisão é {valorUm / valorDois}");

                            #endregion Divisão
                            break;
                        case '%':
                            #region Resto da Divisão

                            Console.WriteLine("Informe o primeiro valor para o resto da divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para o resto da divisão divisão: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado do resto da divisão é {valorUm % valorDois}");

                            #endregion Resto da Divisão
                            break;
                        default:
                            throw new Exception("Operação matemática não " +
                                "configurada! Verifique.");
                    }

                    Console.WriteLine("Deseja continuar? [sim/nao]");
                    continuar = Console.ReadLine();

                } while (_sim.Equals(continuar.ToUpper()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}