/*
 *	Программа для решения крадратный уравнений,
 *	в т.ч. с комплексными корнями.
 */

using System;

public class QuadraticEquations {
	public static void Main(string[] args) {
		Console.WriteLine("Enter parameter of:");
		Console.WriteLine("ax^2 + bx + c = 0");
		Console.Write("a = ");
		double a = Convert.ToDouble(Console.ReadLine());
		Console.Write("b = ");
		double b = Convert.ToDouble(Console.ReadLine());
		Console.Write("c = ");
		double c = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine();

		WriteEqution(a, b, c);
		if (a != 0)
			SolveQuadric(a, b, c);
		else if (b != 0)
			SolveLinear(b, c);
		else if (c != 0)
			Console.WriteLine("No solutions!");
	}

	public static void SolveQuadric(double a, double b, double c) {
		double diskr = b * b - 4 * a * c;

		if (diskr >= 0)
			SolveReal(a, b, diskr);
		else
			SolveComplex(a, b, diskr);
	}

	public static void SolveReal(double a, double b, double diskr) {
		diskr = Math.Sqrt(diskr);
		double x1 = (-b - diskr) / (2 * a);
		double x2 = (-b + diskr) / (2 * a);

		if (x2 > x1)
			Swap(ref x1, ref x2);

		Console.WriteLine($"x1 = {x1}");
		Console.WriteLine($"x2 = {x2}");
	}

	public static void SolveComplex(double a, double b, double diskr) {
		double alpha = -b / (2*a);
		double beta = Math.Sqrt(-diskr) / (2*a);
		string x1 = $"{alpha} + {beta}i";
		string x2 = $"{alpha} - {beta}i";

		Console.WriteLine($"x1 = {x1}");
		Console.WriteLine($"x2 = {x2}");
	}

	public static void SolveLinear(double b, double c) {
		double x = -c / b;
		Console.WriteLine($"x = {x}");
	}

	public static void WriteEqution(double a, double b, double c) {
			if (a == 0)
				Pass();
			else
				if (a == 1)
					Console.Write("x^2");
				else if (a == -1)
					Console.Write("-x^2");
				else
					Console.Write($"{a}x^2");

			if (b == 0)
				Pass();
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
					Pass();
				else if (c > 0)
					Console.Write($" + {c}");
				else
					Console.Write($" - {-c}");
			else
					Console.Write($"{c}");
			Console.WriteLine(" = 0");
	}

	public static void Swap<T>(ref T a, ref T b) {
		T temp;
		temp = a;
		a = b;
		b = temp;
	}

	public static void Pass() {
		return;
	}
}
