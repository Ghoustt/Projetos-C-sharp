using System;
using System.Collections.Generic;
using System.Text;

namespace TestandoLista
{
    public class Tela
    {
        public static void Menu()
        {
            Console.WriteLine("1)Cadastrar\n0)Sair");
        }
        public static void ImprimirTela(Pessoa pss)
        {

            List<Pessoa> pessoas;

            Console.WriteLine("Digite seu nome:");
            pss.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            pss.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu Cpf:");
            pss.Cpf = Console.ReadLine();

            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(pss.Nome, pss.Idade, pss.Cpf));

            foreach (Pessoa pes in pessoas)
            {
                Console.WriteLine("Nome:" + pes.Nome + "\n" + "Idade" + pes.Idade + "\n" + "Cpf" + pes.Cpf);
            }
            Console.WriteLine("\nRegistrado!\nAperte qualquer tecla para continuar.\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
