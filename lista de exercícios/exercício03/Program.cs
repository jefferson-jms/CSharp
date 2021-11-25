using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o valor do primeiro produto::");
            string? produto1 = Console.ReadLine();
            Console.WriteLine("digite o valor do segundo produto:");
            string? produto2 = Console.ReadLine();
            Console.WriteLine("digite o valor do terceiro produto:");
            string? produto3 = Console.ReadLine();
            double valorProduto1 = Convert.ToDouble(produto1);
            double valorProduto2 = Convert.ToDouble(produto2);
            double valorProduto3 = Convert.ToDouble(produto3);

            if (valorProduto1 < valorProduto2 && valorProduto1 < valorProduto3)
            {
                Console.WriteLine("O produto mais barato é o produto: produto1");
            }
            else if (valorProduto2 < valorProduto1 && valorProduto2 < valorProduto3)
            {
                Console.WriteLine("O produto mais barato é o produto: produto2");
            }
            else if (valorProduto3 < valorProduto1 && valorProduto3 < valorProduto2)
            {
                Console.WriteLine("o produto de menor valor é o produto: produto3");
            }
            else
            {
                Console.WriteLine("produtos com valores iguais");
            }

        }
    }
}
