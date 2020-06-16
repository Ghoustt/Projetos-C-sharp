using System;

namespace Exemplo_De_Modularização
{

	class Program
	{
		static void Main(string[] args)
		{
			double salario, salarioLiquido, IR, INSS, VT;
			Console.WriteLine("Informe o valor do salário: ");
			salario = Convert.ToDouble(Console.ReadLine());

			IR = calcular(salario, 0.15);
			INSS = calcular(salario, 0.11);
			VT = calcular(salario, 0.20);

			salarioLiquido = salario - IR - INSS - VT;

			Console.WriteLine("Valor do inposto de renda: " + IR +
							  "\n.Valor do imposto do INSS: " + INSS +
							  "\n.Valor do Vale Transporte " + VT +
							  "\n.Valor do salário a receber: " + salarioLiquido);

			double calcular(double salario, double aliquota)
			{
				double calculo;
				calculo = salario * aliquota;
				return calculo;
			}

		}
	}
}
