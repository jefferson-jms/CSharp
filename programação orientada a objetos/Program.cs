using System;
using ProgramacaoOrientadaObjetos.cadastro;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa novoObjeto = new("maria", "silva", new DateTime(1995, 04, 06));

            Console.WriteLine($"o nome da pessoa do novo objeto é: {novoObjeto.Nome} {novoObjeto.Sobrenome}. {novoObjeto.calculaIdade()}");


        }
    }
}