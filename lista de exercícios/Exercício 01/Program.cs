using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("digite a primeira nota.");
string textoNota01 = Console.ReadLine();
Console.WriteLine("digite a segunda nota.");
string textoNota02 = Console.ReadLine();

double nota01 = Convert.ToDouble(textoNota01);
double nota02 = Convert.ToDouble(textoNota02);
        double media = (nota01 + nota02)/2;

        if(media >= 10)
        {
            Console.WriteLine("parabéns, você foi aprovado com distinção!");
        }
else if(media <= 7)
{
    Console.WriteLine("Infelizmente você foi reprovado.");
}
        else
{
Console.WriteLine("Parabéns, você foi aprovado.");
        }


        }
    }
}