using System;

namespace OperadoresAtribuicao {
	class Program {
		static void Main(string[] args) {

			int a = 10;
			Console.WriteLine(a);

			a += 2;
			Console.WriteLine(a);

			a *= 3;
			Console.WriteLine(a);

			string s = "ABC";
			Console.WriteLine(s);

			s += "DEF";
			Console.WriteLine(s);

			int a1 = 10;
			a1++;
			Console.WriteLine(a1);
			a1--;
			Console.WriteLine(a1);

			int b = a1++;
			Console.WriteLine(a1);
			Console.WriteLine(b);

			b = ++a1;
			Console.WriteLine(a1);
			Console.WriteLine(b);


		}
	}
}
