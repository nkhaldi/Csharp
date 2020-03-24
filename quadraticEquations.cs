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

			writeEqution(a, b, c);
			if (a != 0)
				solveQuadric(a, b, c);
			else if (b != 0)
				solveLinear(b, c);
			else if (c != 0)
				Console.WriteLine("No solutions!");
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

			if (x2 > x1)
				swap(ref x1, ref x2);

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

		static void writeEqution(double a, double b, double c) {
				if (a == 0)
					pass();
				else
					if (a == 1)
						Console.Write("x^2");
					else if (a == -1)
						Console.Write("-x^2");
					else
						Console.Write($"{a}x^2");

				if (b == 0)
					pass();
				else
					if (a != 0)
						if (b == 1)
							Console.Write(" + x");
						else if (b == -1)
							Console.Write(" - x");
						else if (b > 0)
							Console.Write($" + {b}x");
						else
							Console.Write($" - {-b}x");
					else
						if (b == 1)
								Console.Write("x");
						else if (b == -1)
							Console.Write($"-x");
						else
							Console.Write($"{b}x");

				if (a != 0 || b != 0)
					if (c == 0)
						pass();
					else if (c > 0)
						Console.Write($" + {c}");
					else
						Console.Write($" - {-c}");
				else
						Console.Write($"{c}");
				Console.WriteLine(" = 0");
		}

		static void swap<T>(ref T a, ref T b) {
			T temp;
			temp = a;
			a = b;
			b = temp;
		}

		static void pass() {
			return;
		}
	}
}
