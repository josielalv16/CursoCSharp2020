using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaLogicaProgramacao
{
	class Program
	{
		static void Main(string[] args)
		{
			string codigo1;
			int numero1;
			decimal valor1;
			string codigo2;
			int numero2;
			decimal valor2;
			decimal valorPagar;

			Console.Write("Código de uma peça 1: ");
			codigo1 = Console.ReadLine();
			Console.Write("Número de peças 1: ");
			numero1 = int.Parse(Console.ReadLine());
			Console.Write("Valor unitário peça 1: ");
			valor1 = decimal.Parse(Console.ReadLine());

			Console.Write("Código de uma peça 2: ");
			codigo2 = Console.ReadLine();
			Console.Write("Número de peças 2: ");
			numero2 = int.Parse(Console.ReadLine());
			Console.Write("Valor unitário peça 2: ");
			valor2 = decimal.Parse(Console.ReadLine());

			valorPagar = (numero1 * valor1) + (numero2 * valor2);

			Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar}");

			Console.Read();
		}
	}
}
