using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o valor do seu salário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            double acrecimo = 0;

            while (salario < 0)
            {
                try
                {
                    Console.WriteLine("digite o valor do seu salário:");
                    salario = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"erro: {ex.Message}");
                }
            }


            if (salario <= 2800)
            {
                acrecimo = (salario * 20) / 100;
                Console.WriteLine("Seu salário é era de: " + salario);
                Console.WriteLine("você ganhará um desconto de 20 porcento");
                Console.WriteLine("o seu acrescimo é de: " + acrecimo);
                salario = salario + acrecimo;
                Console.WriteLine("Com isso, seu salário a partir de agora é de: " + salario);
            }
            else if (salario > 2800 && salario <= 7000)
            {
                acrecimo = (salario * 15) / 100;
                Console.WriteLine("Seu salário é era de: " + salario);
                Console.WriteLine("você ganhará um desconto de 15 porcento");
                Console.WriteLine("o seu acrescimo é de: " + acrecimo);
                salario = salario + acrecimo;
                Console.WriteLine("Com isso, seu salário a partir de agora é de: " + salario);
            }
            else if (salario > 7000 && salario <= 15000)
            {
                acrecimo = (salario * 10) / 100;
                Console.WriteLine("Seu salário é era de: " + salario);
                Console.WriteLine("você ganhará um desconto de 10 porcento");
                Console.WriteLine("o seu acrescimo é de: " + acrecimo);
                salario = salario + acrecimo;
                Console.WriteLine("Com isso, seu salário a partir de agora é de: " + salario);
            }
            else
            {
                acrecimo = (salario * 5) / 100;
                Console.WriteLine("Seu salário é era de: " + salario);
                Console.WriteLine("você ganhará um desconto de 5 porcento");
                Console.WriteLine("o seu acrescimo é de: " + acrecimo);
                salario = salario + acrecimo;
                Console.WriteLine("Com isso, seu salário a partir de agora é de: " + salario);
            }

        }
    }
}