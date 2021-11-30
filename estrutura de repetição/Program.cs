using System;
using System.Collections.Generic;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
/*for(int i = 1;i <= 10; i+=2)
{
    Console.WriteLine($"o valor de i é: {i}");
}

List<string> listaNomes = new();
listaNomes.Add("Jefferson Soares");
listaNomes.Add("Paulo Ponciano");
listaNomes.Add("rubens");
listaNomes.Add("Marcos vinícios");
foreach(string nome in listaNomes)
Console.WriteLine($"o nome da lista é: {nome}");*/

try
{
Console.WriteLine("digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"erro: {ex.Message}");
}


        }
    }
}