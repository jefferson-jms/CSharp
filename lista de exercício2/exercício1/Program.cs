using System;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"digite o {i}º número:");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                {
                    numero += 1;
                }
            }
            Console.WriteLine($"existem {numero} pessoas com 18 anos ou mais.");

        }
    }
}