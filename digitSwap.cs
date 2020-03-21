/*
 *	Дано одно натуральное четырехзначное число.
 *	Найдите самое большое число, полученное
 *	из заданного циклической перестановкой его цифр.
*/

using System;

public class MainClass
{
    public static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int x1 = x / 1000;
        int x2 = x % 1000 / 100;
        int x3 = x % 100 / 10;
        int x4 = x % 10;

        int m1 = x1 * 1000 +  x2 * 100 + x3 * 10 + x4;
        int m2 = x2 * 1000 +  x3 * 100 + x4 * 10 + x1;
        int m3 = x3 * 1000 +  x4 * 100 + x1 * 10 + x2;
        int m4 = x4 * 1000 +  x1 * 100 + x2 * 10 + x3;
        int m12 = Math.Max(m1, m2);
        int m34 = Math.Max(m3, m4);

        int m = Math.Max(m12, m34);
        Console.WriteLine(m);
    }
}
