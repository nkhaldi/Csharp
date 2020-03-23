/*
 *	Написать программу для решения крадратный уравнений,
 *	в т.ч. с комплексными корнями.
*/

using System;

namespace quadricEquations {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("Enter parameter of:");
			Console.WriteLine("ax^2 + bx + c = 0");
			Console.Write("a = ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("b = ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.Write("c = ");
			double c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();

			if (a != 0)
				solveQuadric(a, b, c);
			else if (b != 0)
				solveLinear(b, c);
			else if (c != 0)
				Console.WriteLine("No solutions!");
			else
				Console.WriteLine("0 = 0");
		}

		static void solveQuadric(double a, double b, double c) {
			double diskr = b * b - 4 * a * c;

			if (diskr >= 0)
				solveReal(a, b, diskr);
			else
				solveComplex(a, b, diskr);
		}

		static void solveReal(double a, double b, double diskr) {
			diskr = Math.Sqrt(diskr);
			double x1 = (-b - diskr) / (2 * a);
			double x2 = (-b + diskr) / (2 * a);

			Console.WriteLine($"x1 = {x1}");
			Console.WriteLine($"x2 = {x2}");
		}

		static void solveComplex(double a, double b, double diskr) {
			double alpha = -b / (2*a);
			double beta = Math.Sqrt(-diskr) / (2*a);
			string x1 = $"{alpha} + {beta}i";
			string x2 = $"{alpha} - {beta}i";

			Console.WriteLine($"x1 = {x1}");
			Console.WriteLine($"x2 = {x2}");
		}

		static void solveLinear(double b, double c) {
			double x = -c / b;
			Console.WriteLine($"x = {x}");
		}
	}
}
