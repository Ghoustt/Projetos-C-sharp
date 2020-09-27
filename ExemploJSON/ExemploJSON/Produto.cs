using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploJSON
{
    public class Produto
    {
        public Produto()
        {

        }
        //O construtor ficou muito grande!!Como resolver?
        public Produto(int codigo, string descricao, string unidadeDeMedida, decimal peso, decimal precoDeCusto, decimal precoDeVenda, decimal margemDeLucro, int estoque, bool ativo)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.UnidadeDeMedida = unidadeDeMedida;
            this.Peso = peso;
            this.PrecoDeCusto = precoDeCusto;
            this.PrecoDeVenda = precoDeVenda;
            this.MargemDeLucro = margemDeLucro;
            this.Estoque = estoque;
            this.Ativo = ativo;
        }
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public string UnidadeDeMedida { get; set; }

        public decimal Peso { get; set; }

        public decimal PrecoDeCusto { get; set; }

        public decimal PrecoDeVenda { get; set; }

        public decimal MargemDeLucro { get; set; }

        public int Estoque { get; set; }

        public bool Ativo { get; set; }
    }
}
