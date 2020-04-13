/*
 * Перевод числа из десятичной системы в римскую
 */

using System;
using System.Text;

public class DecimalToRoman {
    public static void Main() {
        int dec = int.Parse(Console.ReadLine());
        string rom = DecToRom(dec);
        Console.WriteLine(rom);
    }

    static string DecToRom(int dec) {
        StringBuilder roman = new StringBuilder();
        for (int i = 0; i < dec; i++) {
            roman.Append("I");
            roman.Replace("IIII", "IV");
            roman.Replace("VIV", "IX");
            roman.Replace("IXI", "X");
            roman.Replace("IVI", "V");
            roman.Replace("VV", "X");
            roman.Replace("XXXX", "XL");
            roman.Replace("XLX", "L");
            roman.Replace("LXL", "XC");
            roman.Replace("XCX", "C");
            roman.Replace("LL", "C");
            roman.Replace("CCCC", "CD");
            roman.Replace("CDC", "D");
            roman.Replace("DCD", "CM");
            roman.Replace("CMC", "M");
            roman.Replace("DD", "M");
        }
        return roman.ToString();
    }
}
