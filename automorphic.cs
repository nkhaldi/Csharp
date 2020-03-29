/*
 * Автоморфное число — неотрицательное целое число,
 * десятичная запись квадрата которого оканчивается цифрами
 * самого этого числа.
 * Например, число 25, так как 25^2 = 625.
 * Также число 625, так как 625^2 = 390625.
 *
 * По данному числу k выведите все aвтоморфные числа,
 * которые не превосходят k.
 */

using System;

public class Automorphic {
    public static void Main() {
        long k = Convert.ToInt64(Console.ReadLine());

        for (long num = 0; num <= k; num++)
            if (IsAutomorphic(num))
                Console.Write(num + " ");
        Console.WriteLine("");
    }
    
    static bool IsAutomorphic(long number) {
        int len = 0;
        long reserve = number;

        while (number > 0) {
            number /= 10;
            len++;
        }
        return (reserve*reserve) % Math.Pow(10, len) == reserve;
    }
}
