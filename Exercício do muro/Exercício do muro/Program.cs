using System;

public class Program
{
	public static void Main()
	{
		int altura, largura, tijolos, metros;

		Console.WriteLine("Qantos metros de altura tem no muro?");
		altura = int.Parse(Console.ReadLine());

		Console.WriteLine("Qantos metros de largura tem no muro?");
		largura = int.Parse(Console.ReadLine());

		metros = altura * largura;
		tijolos = altura * largura / 8;

		Console.WriteLine("Esse muro tem: " + metros + "m² e serão necessários: " + tijolos + "\n para a conclusão da obra");
	}
}