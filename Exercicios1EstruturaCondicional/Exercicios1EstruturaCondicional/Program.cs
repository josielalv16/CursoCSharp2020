using System;
using System.Globalization;

namespace Exercicios1EstruturaCondicional {
	class Program {
		static void Main(string[] args) {
			//Exercicio 01
			int n = int.Parse(Console.ReadLine());

			if (n < 0) {
				Console.WriteLine("NEGATIVO");
			}
			else {
				Console.WriteLine("NÃO NEGATIVO");
			}

			// Exercicio 02
			int n2 = int.Parse(Console.ReadLine());

			if (n2 % 2 == 0) {
				Console.WriteLine("PAR");
			}
			else {
				Console.WriteLine("IMPAR");
			}

			// Exercicio 03
			string[] valores = Console.ReadLine().Split(' ');
			int a = int.Parse(valores[0]);
			int b = int.Parse(valores[1]);

			if (a % b == 0 || b % a == 0) {
				Console.WriteLine("São Multiplos");
			}
			else {
				Console.WriteLine("Não são multiplos");
			}

			// Exercicio 04
			string[] valores4 = Console.ReadLine().Split(' ');
			int inicial = int.Parse(valores4[0]);
			int final = int.Parse(valores4[1]);
			int duracao;

			if (inicial < final) {
				duracao = final - inicial;
			}
			else {
				duracao = 24 - inicial + final;
			}

			Console.WriteLine($"O jogo durou {duracao} hora(s)");

			// Exercicio 05
			string[] valores5 = Console.ReadLine().Split(' ');
			int codigo = int.Parse(valores5[0]);
			int quantidade = int.Parse(valores5[1]);
			double total;

			if (codigo == 1) {
				total = quantidade * 4.0;
			}
			else if (codigo == 2) {
				total = quantidade * 4.50;
			}
			else if (codigo == 3) {
				total = quantidade * 5.00;
			}
			else if (codigo == 4) {
				total = quantidade * 2.00;
			}
			else {
				total = quantidade * 1.50;
			}

			Console.WriteLine("Total: R$ " + total.ToString("F2"));

			// Exercicio 06
			double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (valor6 < 0 || valor6 > 100) {
				Console.WriteLine("Fora de intervalo");
			}
			else if (valor6 <= 25) {
				Console.WriteLine("Intervalo (0, 25)");
			}
			else if (valor6 <= 50) {
				Console.WriteLine("Intervalo (25, 50)");
			}
			else if (valor6 <= 75) {
				Console.WriteLine("Intervalo (50, 75)");
			}
			else
				Console.WriteLine("Intervalo (75, 100)");

			// Exercicio 07
			string[] valores7 = Console.ReadLine().Split(' ');
			double x = double.Parse(valores7[0], CultureInfo.InvariantCulture);
			double y = double.Parse(valores7[1], CultureInfo.InvariantCulture);

			if (x == 0.0 && y == 0.0) {
				Console.WriteLine("Origem");
			}
			else if (x == 0.0) {
				Console.WriteLine("Eixo Y");
			}
			else if (y == 0.0) {
				Console.WriteLine("Eixo X");
			}
			else if (x > 0.0 && y > 0.0) {
				Console.WriteLine("Q1");
			}
			else if (x < 0.0 && y > 0.0) {
				Console.WriteLine("Q2");
			}
			else if (x < 0.0 && y < 0.0) {
				Console.WriteLine("Q3");
			}
			else {
				Console.WriteLine("Q4");
			}

			// Exercicio 08
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double imposto;

			if (salario <= 2000.0) {
				imposto = 0.0;
			}
			else if (salario <= 3000.0) {
				imposto = (salario - 2000.0) * 0.08;
			}
			else if (salario <= 4500.0) {
				imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
			}
			else {
				imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
			}

			if (imposto == 0.0) {
				Console.WriteLine("Isento");
			}
			else {
				Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
			}


		}
	}
}
