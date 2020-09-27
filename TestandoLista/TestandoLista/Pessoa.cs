using System;
using System.Text;

namespace TestandoLista
{

    public class Pessoa
    {
        public Pessoa()
        {

        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, int idade, string cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
        }
    }
}
