using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {       
             while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024");
                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite S para Sair");
                
                string operacao = Console.ReadLine();

                if (string.IsNullOrEmpty(operacao) || operacao.Equals("S",StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else if (Convert.ToInt32(operacao) > 4 || Convert.ToInt32(operacao) < 1)
                {
                    Console.WriteLine("Opção inválida. Digite um número válido");
                    Console.WriteLine("Tecle 'enter' para retornar ao menu");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Digite o primeiro número:");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());
                
                decimal resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (operacao == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível realizar a operação. Tente novamente");
                        Console.WriteLine("Tecle 'enter' para retornar ao menu");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = primeiroNumero / segundoNumero;
                }
                
                Console.WriteLine("O resultado é: " + resultado.ToString("F2"));
                Console.WriteLine("Tecle 'enter' para retornar ao menu");

                Console.ReadKey();
            }
              Environment.Exit(0);
        }
    }
}
