using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace ExemploJSON
{
    class ArquivosTxt
    {
        public static void Escrever(Produto Parametros)
        {
            var ProdutoSerializado = new Produto()
            {
                Codigo = Parametros.Codigo,
                Descricao = Parametros.Descricao,
                UnidadeDeMedida = Parametros.UnidadeDeMedida,
                Peso = Parametros.Peso,
                PrecoDeCusto = Parametros.PrecoDeCusto,
                PrecoDeVenda = Parametros.PrecoDeVenda,
                MargemDeLucro = Parametros.MargemDeLucro,
                Estoque = Parametros.Estoque,
                Ativo = Parametros.Ativo
            };

            var Serializando = JsonSerializer.Serialize(ProdutoSerializado);
            using (StreamWriter arquivo = new StreamWriter(@"..\..\..\Registros\Registros.txt", true))
            {
                arquivo.WriteLine(Serializando);
                arquivo.Close();
            }
        }
    }
}
