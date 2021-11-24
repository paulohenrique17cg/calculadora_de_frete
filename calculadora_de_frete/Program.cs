using System;

namespace desafios
{
    class Program
    {


        static void Main(string[] args)
        {
            // Declaração de variáveis
            string estado;
            float valordoproduto, frete;

            // Comandos de entrada e saída
            Console.Write("--------Calculadora de FRETE--------\n\n");
            Console.Write("Informe o valor do produto: R$");
            valordoproduto = int.Parse(Console.ReadLine());
            Console.Write("Insira as iniciais do estado para onde o pedido sera enviado: ");
            estado = Console.ReadLine();

            // área de condicionais
            if (valordoproduto > 999) // determino que o valor mínimo para o frete ser gratuito é de R$999,00 reais.
            {
                frete = 0;
                Console.Write("O valor do frete é: R$" + frete);
            }
            else
            { 
                // tabelando valores fixos de acordo com o estado 
                switch (estado) //
                {
                    case "SP":
                        frete = 10;
                        Console.WriteLine("O valor do frete é de R$" + frete);
                        break;
                    case "RJ":
                        frete = 15;
                        Console.WriteLine("O valor do frete é de R$" + frete);
                        break;
                    case "AM":
                        frete = 20;
                        Console.WriteLine("O valor do frete é de R$" + frete);
                        break;
                    default:
                        frete = 15;
                        Console.WriteLine("O valor do frete é de R$" + frete);
                        break;
                }

            }

        }
    }
}
