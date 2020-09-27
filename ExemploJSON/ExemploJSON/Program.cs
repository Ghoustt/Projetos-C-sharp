using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ExemploJSON
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            Produto Parametros = new Produto();
            do
            {
                Tela.Menu();
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Tela.NovoProd(Parametros);
                        ArquivosTxt.Escrever(Parametros);
                        break;
                    case 2:
                        Tela.Descerializando();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Esta opção ão é válida, tente novamente\n");
                        break;
                }
            } while (opcao != 0);
        }
    }
}