using System;

namespace PrimeiroProjeto
{
public class Program
{
public static void Main(String[] args)
{
Console.WriteLine("olá mundo");
string nomeCompleto = "Jefferson Miranda Soares";
short numeroPequeno = 0; //variável short armazena números até 32767.
int numeroNormal = 0; //variável int armazena números até 2147483647.
long numeroGrande = 0; //variável long armazena números até 9223372036854775807.
decimal numeroDecimal = 0.0M;
double numeroDouble = 0;
bool eVerdadeiro = true;

//cálculos aritméticos

int soma = 34 + 14;
int subtracao = 10 - 5;
int multiplicacão = 10 * 5;
int divisao = 10 / 5;
int resto = 10 % 3;
double potencia = Math.Pow(10,5);

Console.WriteLine("soma: " + soma);
Console.WriteLine("subtração: " + subtracao);
Console.WriteLine("multiplicação: " + multiplicacão);
Console.WriteLine("divisão " + divisao);
Console.WriteLine("resto: " + resto);
Console.WriteLine("potência: " + potencia);

//estruturas de decisão

if(soma < 24)
{
    int result = 24 - soma;
    Console.WriteLine("faltam " + result);
}
else if(soma == 24)
{
    Console.WriteLine("clap clap clap");
}
else 
{
    int result = soma - 24;
    Console.WriteLine("sobrou " + result);
}



}
}  
}
