using System;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matricula = 2;

            Console.WriteLine("digite a primeira nota:");
            double nota = Convert.ToDouble(Console.ReadLine());

            double soma = nota;

            while (nota >= 0)
            {
                Console.WriteLine("digite a próxima nota:");
                nota = Convert.ToDouble(Console.ReadLine());
                soma += nota;
                double media = soma / matricula;
                Console.WriteLine($"Até agora são {matricula} alunos matriculados e a média das notas na prova é de: {media}.");
            }

        }
    }
}