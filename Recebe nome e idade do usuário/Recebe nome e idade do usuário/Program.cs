using System;


public class Program
{
	public static void Main()
	{
		string nome;
		int ano, idade;



		Console.WriteLine("qual seu nome?");
		nome = Console.ReadLine();

		Console.WriteLine("Em que ano você nasceu?");
		ano = int.Parse(Console.ReadLine());

		while (ano <= 0 || nome.ToLower() == "")
		{

			Console.Clear();
			Console.WriteLine("Ops, acho que você esqueceu de preencher algum campo\ntente novamente\n");
			Console.WriteLine("qual seu nome?");
			nome = Console.ReadLine();

			Console.WriteLine("Em que ano você nasceu?");
			ano = int.Parse(Console.ReadLine());

		}

		idade = 2020 - ano;

		Console.WriteLine("Seu nome é: " + nome + " e você tem " + idade + " anos");
	}
}

