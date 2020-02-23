using System;
using System.Globalization;

namespace Exercicios1EstruturaSequencial {
	class Program {
		static void Main(string[] args) {

			// Exercicio 01
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());
			int total = n1 + n2;

			Console.WriteLine("SOMA = " + total);

			Console.WriteLine("==============================");

			// Exercicio 02
			double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			double pi = 3.14159;
			double area = pi * (Math.Pow(raio, 2));

			Console.WriteLine("A=" + area.ToString("F4"));

			Console.WriteLine("==============================");

			// Exercicio 03
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());

			int dif = a * b - c * d;

			Console.WriteLine("DIFERENCA = " + dif);

			Console.WriteLine("==============================");

			// Exercicio 04
			int nFuncionario = int.Parse(Console.ReadLine());
			int horasTrab = int.Parse(Console.ReadLine());
			double vlrHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double salario = horasTrab * vlrHora;

			Console.WriteLine("NUMBER = " + nFuncionario);
			Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

			Console.WriteLine("==============================");

			// Exercicio 05
			string[] p1 = Console.ReadLine().Split(' ');
			int codigo1 = int.Parse(p1[0]);
			int numero1 = int.Parse(p1[1]);
			double vlr1 = double.Parse(p1[2], CultureInfo.InvariantCulture);

			string[] p2 = Console.ReadLine().Split(' ');
			int codigo2 = int.Parse(p2[0]);
			int numero2 = int.Parse(p2[1]);
			double vlr2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

			double vlrTotal = numero1 * vlr1 + numero2 * vlr2;

			Console.WriteLine("Valor a Pagar: R$ " + vlrTotal.ToString("F2", CultureInfo.InvariantCulture));

			Console.WriteLine("==============================");

			// Exercicio 06
			string[] valores = Console.ReadLine().Split(' ');
			double a6 = double.Parse(valores[0], CultureInfo.InvariantCulture);
			double b6 = double.Parse(valores[1], CultureInfo.InvariantCulture);
			double c6 = double.Parse(valores[2], CultureInfo.InvariantCulture);

			double triangulo = a6 * c6 / 2.0;
			double circulo = 3.14159 * c6 * c6;
			double trapezio = (a6 + b6) / 2.0 * c6;
			double quadrado = b6 * b6;
			double retangulo = a6 * b6;

			Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

		}
	}
}
