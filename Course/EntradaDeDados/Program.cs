using System;
using System.Globalization;

namespace EntradaDeDados {
	class Program {
		static void Main(string[] args) {

			//string frase = Console.ReadLine();
			//string x = Console.ReadLine();
			//string y = Console.ReadLine();
			//string z = Console.ReadLine();

			//string[] v = Console.ReadLine().Split(' ');
			//string a = v[0];
			//string b = v[1];
			//string c = v[2];

			//Console.WriteLine("Você digitou: ");
			//Console.WriteLine(frase);
			//Console.WriteLine(x);
			//Console.WriteLine(y);
			//Console.WriteLine(z);
			//Console.WriteLine(a);
			//Console.WriteLine(b);
			//Console.WriteLine(c);

			//Console.WriteLine("===================== PARTE 2 =======================");

			//int n1 = int.Parse(Console.ReadLine());
			//char ch = char.Parse(Console.ReadLine());
			//double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			//string[] vet = Console.ReadLine().Split(' ');
			//string nome = vet[0];
			//char sexo = char.Parse(vet[1]);
			//int idade = int.Parse(vet[2]);
			//double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

			//Console.WriteLine("Você digitou: ");
			//Console.WriteLine(n1);
			//Console.WriteLine(ch);
			//Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
			//Console.WriteLine(nome);
			//Console.WriteLine(sexo);
			//Console.WriteLine(idade);
			//Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

			Console.WriteLine("======================== Exercicio de fixação =========================");
			
			Console.WriteLine("Entre com seu nome completo:");
			string nome = Console.ReadLine();

			Console.WriteLine("Quantos quartos tem na sua casa?");
			int quartos = int.Parse(Console.ReadLine());

			Console.WriteLine("Entre com o preço de um produto:");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
			string[] vet = Console.ReadLine().Split(' ');
			string ultimoNome = vet[0];
			int idade = int.Parse(vet[1]);
			double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

			Console.WriteLine(nome);
			Console.WriteLine(quartos);
			Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine(ultimoNome);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
