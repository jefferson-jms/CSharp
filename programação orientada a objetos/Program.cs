using System;
using ProgramacaoOrientadaObjetos.cadastro;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa teste = new("maria", "silva", DateTime.Now);

            Console.WriteLine($"o nome da pessoa do novo objeto é: {teste.Nome} {teste.Sobrenome}.\ndata: {teste.DataNascimento}");

        }
    }
}