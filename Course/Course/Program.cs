using System;

namespace Course {
	class Program {
		static void Main(string[] args) {

			// Tipos de variaveis	
			bool completo = false;
			char genero = 'F';
			char letra = '\u0041';
			sbyte x = 100;
			byte n1 = 254;
			int n2 = 1000;
			int n3 = 2147483647;
			long n4 = 2147483648L;
			float n5 = 4.5f;
			double n6 = 4.5;
			string nome = "Maria Green";
			object obj1 = "Alex Brown";
			object obj2 = 4.5;
			n1++;

			Console.WriteLine(completo);
			Console.WriteLine(genero);
			Console.WriteLine(letra);
			Console.WriteLine(n1);
			Console.WriteLine(n2);
			Console.WriteLine(n3);
			Console.WriteLine(n4);
			Console.WriteLine(n5);
			Console.WriteLine(n6);
			Console.WriteLine(nome);
			Console.WriteLine(obj1);
			Console.WriteLine(obj2);
			Console.WriteLine(x);

			int n1M = int.MinValue;
			int n2M = int.MaxValue;
			sbyte n3M = sbyte.MinValue;
			decimal n4M = decimal.MaxValue;

			Console.WriteLine(n1M);
			Console.WriteLine(n2M);
			Console.WriteLine(n3M);
			Console.WriteLine(n4M);
		}
	}
}
