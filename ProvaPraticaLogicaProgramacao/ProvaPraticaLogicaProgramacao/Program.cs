﻿using System;
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
            // EXERCICIO 1.1
            //string codigo1;
            //int numero1;
            //decimal valor1;
            //string codigo2;
            //int numero2;
            //decimal valor2;
            //decimal valorPagar;

            //Console.Write("Código de uma peça 1: ");
            //codigo1 = Console.ReadLine();
            //Console.Write("Número de peças 1: ");
            //numero1 = int.Parse(Console.ReadLine());
            //Console.Write("Valor unitário peça 1: ");
            //valor1 = decimal.Parse(Console.ReadLine());

            //Console.Write("Código de uma peça 2: ");
            //codigo2 = Console.ReadLine();
            //Console.Write("Número de peças 2: ");
            //numero2 = int.Parse(Console.ReadLine());
            //Console.Write("Valor unitário peça 2: ");
            //valor2 = decimal.Parse(Console.ReadLine());

            //valorPagar = (numero1 * valor1) + (numero2 * valor2);

            //Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar}");

            // EXERCICIO 1.2
            //decimal raio;
            //decimal area;
            //decimal pi = 3.14159M;

            //Console.Write("Raio: ");
            //raio = decimal.Parse(Console.ReadLine());

            //area = pi * (raio * raio);
            //Console.Write($"A={area.ToString("N4")}");

            // EXERCICIO 2.1
            //int codigo;
            //int qtd;
            //decimal total = 0;

            //      Console.Write("Codigo do produto: ");
            //codigo = int.Parse(Console.ReadLine());
            //      Console.Write("Quantidade deste item: ");
            //qtd = int.Parse(Console.ReadLine());

            //switch (codigo)
            //{
            //          case 1:
            //        total = qtd * 4.0M;
            //              break;
            //          case 2:
            //        total = qtd*4.50M;
            //              break;
            //          case 3:
            //        total = qtd*5.0M;
            //              break;
            //          case 4:
            //        total = qtd*2.0M;
            //              break;
            //          case 5:
            //        total = qtd*1.50M;
            //              break;
            //}

            //      Console.Write($"Total: R$ {total}");

            // EXERCICIO 2.2
            //      double a, b, c, delta, x1, x2;
            //      Console.Write("Valor de A: ");
            //a = double.Parse(Console.ReadLine());
            //      Console.Write("Valor de B: ");
            //b = double.Parse(Console.ReadLine());
            //      Console.Write("Valor de C: ");
            //c = double.Parse(Console.ReadLine());

            //      if (a == 0)
            //          Console.Write("Impossivel calcular");
            //      else
            //      {
            //          delta = (b*b) - (4*a*c);
            //          if (delta < 0)
            //              Console.Write("Impossivel calcular");
            //          else
            //          {
            //              x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //              x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //              Console.WriteLine($"X1 = {x1}");
            //              Console.WriteLine($"X2 = {x2}");
            //          }
            //      }

            // EXERCICIO 3.1
            //int senha = 0;
            //do
            //{
            //    senha = int.Parse(Console.ReadLine());
            //    if (senha != 2002)
            //        Console.WriteLine("Senha invalida");
            //    else
            //        Console.WriteLine("Acesso Permitido");
            //} while (senha != 2002);

            // EXERCICIO 3.2
		    int n = 0, valor, dentro = 0, fora = 0;

		    n = int.Parse(Console.ReadLine());
		    for (int i = 0; i < n; i++)
		    {
		        valor = int.Parse(Console.ReadLine());
		        if (valor >= 10 && valor <= 20)
		            dentro++;
		        else
		            fora++;
		    }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");


            Console.Read();
		}
	}
}
