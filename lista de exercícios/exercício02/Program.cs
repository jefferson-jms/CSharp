using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número:");
            string? a1 = Console.ReadLine();
            Console.WriteLine("digite o segundo número:");
            string? b2 = Console.ReadLine();
            Console.WriteLine("digite o terceiro número:");
            string? c3 = Console.ReadLine();

            int a = Convert.ToInt32(a1);
            int b = Convert.ToInt32(b2);
            int c = Convert.ToInt32(c3);

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("todos os números tem o mesmo tamanho.");
            }
            else
            {
                if (a > b && a > c)
                {
                    Console.WriteLine(a + " é o valor maior.");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine(b + " é onúmero maior");
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine(c + " é o número maior");
                }

                if (a < b && a < c)
                {
                    Console.WriteLine(a + " é o número menor.");
                }
                else if (b < a && b < c)
                {
                    Console.WriteLine(b + " é o número menor.");
                }
                else if (c < a && c < b)
                {
                    Console.WriteLine(c + " é o número menor");
                }
            }



        }
    }
}