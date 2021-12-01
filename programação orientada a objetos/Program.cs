using System;
using ProgramacaoOrientadaObjetos.cadastro;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("digite a sua data de nascimento: (dd/MM/aaaa)");
string? textoDataNascimento = Console.ReadLine();

int ano = Convert.ToInt32(textoDataNascimento?.Substring(6, 4));
int mes = Convert.ToInt32(textoDataNascimento?.Substring(3, 2));
int dia = Convert.ToInt32(textoDataNascimento?.Substring(0, 2));

            Pessoa novoObjeto = new("maria", "silva", new DateTime(ano, mes, dia));

            Console.WriteLine($"o nome da pessoa do novo objeto é: {novoObjeto.Nome} {novoObjeto.Sobrenome}. {novoObjeto.calculaIdade()}");


        }
    }
}