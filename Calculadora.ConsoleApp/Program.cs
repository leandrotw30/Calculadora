using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string operacao = MostrarMenu();

                if (OperacaoSaidaSelecionada(operacao))
                {
                    break;
                }
                else if (OpcaoInvalida(operacao))
                {
                    ExibirMensagemErro();
                    continue;
                }
                else
                {
                    RealizaCalculo(operacao);
                }
            }
        }
        static string MostrarMenu() //void não retorna nada
        {
            //mostrar o menu - input
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara 2024\n");
            Console.WriteLine("Digite 1 para Adicionar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir");
            Console.WriteLine("Digite S para Sair");

            string operacao = Console.ReadLine();

            return operacao;
        }
        static bool OperacaoSaidaSelecionada(string opcao) // atributo ou parâmetro
        {
            bool opcaoSaidaSelecionada = string.IsNullOrEmpty(opcao) || opcao.Equals("S", StringComparison.InvariantCultureIgnoreCase);

            return opcaoSaidaSelecionada;
        }
        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = Convert.ToInt32(opcao) > 4 || Convert.ToInt32(opcao) < 1;

            return opcaoInvalida;
        }
        static void ExibirMensagemErro()
        {
            Console.WriteLine("Opção inválida. Digite um número válido");
            Console.WriteLine("Tecle 'enter' para retornar ao menu");
            Console.ReadKey();
        }
        static void RealizaCalculo(string operacao)
        {
            Console.WriteLine("Digite o primeiro número:");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;

            switch (operacao)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    break;

                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    break;

                case "4":
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível realizar a operação. Tente novamente");
                        Console.WriteLine("Tecle 'enter' para retornar ao menu");
                    }
                    resultado = primeiroNumero / segundoNumero;
                    break;
            }
            ExibirResultado(resultado);
        }
        private static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("O resultado é: " + resultado.ToString("F2"));
            Console.WriteLine("Tecle 'enter' para retornar ao menu");

            Console.ReadKey();
        }
    }
}