using System;

namespace Exercício2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quadrado = 0;
            int soma = 0;

            Console.WriteLine("digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 10)
            {
                Console.WriteLine("número inválido, por favor, digite outro.");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            while (numero <= 0)
            {
                Console.WriteLine("número inválido, por favor, digite outro.");
                numero = Convert.ToInt32(Console.ReadLine());
            }

                for (int i = numero; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    quadrado = (i * i);
                    soma += quadrado;
                }
                else
                {
                    quadrado = (i * i);
                    soma += quadrado;
                }
            }
            Console.WriteLine($"a soma dos quadrados dos números ímpares é: {soma}");



        }
    }
}