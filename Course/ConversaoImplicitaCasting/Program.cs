using System;

namespace ConversaoImplicitaCasting {
	class Program {
		static void Main(string[] args) {

			float x = 4.5f;

			double y = x;

			Console.WriteLine(y);

			double a;
			float b;

			a = 5.1;
			b = (float)a;

			Console.WriteLine(b);

			double a1;
			int b1;

			a1 = 5.1;
			b1 = (int)a1;

			Console.WriteLine(b1);

			int a2 = 5;
			int b2 = 2;

			double resultado = (double)a2 / b2;

			Console.WriteLine(resultado);

		}
	}
}
