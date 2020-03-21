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
				if (!solveQuadric(a, b, c))
					Console.WriteLine("No real solutions!");
				else
					Console.WriteLine("");
			else if (b != 0)
				solveLinear(b, c);
			else
				Console.WriteLine("");

		}

		static bool solveQuadric(double a, double b, double c) {
			double diskr = b * b - 4 * a * c;

			if (diskr < 0)
				return false;

			diskr = Math.Sqrt(diskr);
			double x1 = (-b - diskr) / (2 * a);
			double x2 = (-b + diskr) / (2 * a);

			Console.WriteLine($"x1 = {x1}");
			Console.WriteLine($"x2 = {x2}");
			return true;
		}

		static void solveLinear(double b, double c) {
			double x = -c / b;
			Console.WriteLine($"x = {x}");
		}
	}
}
