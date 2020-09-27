using System;

namespace TestandoLista
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;

            do
            {
                Tela.Menu();
                opcao = Convert.ToInt32(Console.ReadLine());
                Pessoa pe = new Pessoa();
                switch (opcao)
                {
                    case 1:
                        Tela.ImprimirTela(pe);
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
