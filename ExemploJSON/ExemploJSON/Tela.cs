using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace ExemploJSON
{
    public class Tela
    {
        public static void Menu()
        {
            Console.WriteLine("Bem vindo ao sistema de cadastro de produtos\n O que deseja?");
            Console.WriteLine("1)Cadastrar um produto\n2)Ver produtos cadastrados no sistema\n0)Exit");
        }
        public static void NovoProd(Produto prod)
        {
            string Resposta;

            Console.WriteLine("Digite o código do produto:");
            prod.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a descrição do produto:");
            prod.Descricao = Console.ReadLine();

            Console.WriteLine("Digite a unidade de medida:");
            prod.UnidadeDeMedida = Console.ReadLine();

            Console.WriteLine("Digite o peso do produto:");
            prod.Peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o Preço de custo do produto:");
            prod.PrecoDeCusto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o Preço de venda do produto:");
            prod.PrecoDeVenda = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o margem de lucro do produto:");
            prod.MargemDeLucro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Estoque do produto:");
            prod.Estoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Deseja cadastrar esse produto para ser vendido agora?(S/N)");
            Resposta = Console.ReadLine();

            if (Resposta.ToUpper() == "S" || Resposta.ToUpper() == "SIM")
            {
                prod.Ativo = true;
            }
            else
            {
                prod.Ativo = false;
            }

            Console.WriteLine("Produto registrado!");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Descerializando()
        {
            string LendoTxt = "";
            using (var ler = new StreamReader(@"..\..\..\Registros\Registros.txt"))
            {
                LendoTxt += ler.ReadLine();
                var Descerializando = JsonSerializer.Deserialize<Produto>(LendoTxt);
            }

            var texto = File.ReadAllLines(@"..\..\..\Registros\Registros.txt");
            foreach (var item in texto)
            {
                Console.WriteLine(item + "\n");
            }
            Console.WriteLine("Precione qualquer tecla para continuar");

            //Console.WriteLine(lendo);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
