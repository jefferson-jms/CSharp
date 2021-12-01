using System;

namespace ProgramacaoOrientadaObjetos.cadastro
{
    public class Pessoa
    {
        public int Código { get; set; }

        public string? Nome { get; set; }

        public string? Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }
        public Pessoa(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;

        }
    }
}
