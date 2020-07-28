using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Orientação_a_objeto
{
   class Professor : Pessoa
    {
        //Registro e formação
        private string registro;
        private string formacao;

        public Professor()
        {
            this.id = 0;
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.registro= "";
            this.formacao= "";
        }
        public Professor(int _id, string _nome, string _rg, string _cpf, string _registro, string _formacao)
        {
            this.id = _id;
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.registro = _registro;
            this.formacao = _formacao;
        }
        public string REGISTRO
        {
            get { return this.registro; }
            set { this.registro = value; }
        }
        public string FORMACAO
        {
            get { return this.formacao; }
            set { this.formacao = value; }
        }
    }
}
