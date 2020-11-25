/*
 * Иногда некоторые слова вроде localization или internationalization
 * настолько длинны, что их весьма утомительно писать много раз
 * в каком либо тексте.
 *
 * Будем считать слово слишком длинным, если его длина строго больше
 * 1010 символов. Все слишком длинные слова можно заменить
 * специальной аббревиатурой, которая строится следующим образом:
 * записывается первая и последняя буква слова, а между ними —
 * количество букв между первой и последней буквой
 *
 * Таком образом, localization запишется как l10n,
 * а «internationalization» как i18n.
 *
 * Вам предлагается автоматизировать процесс замены слов на аббревиатуры.
 * При этом все слишком длинные слова должны быть заменены аббревиатурой,
 * а слова, не являющиеся слишком длинными, должны остаться без изменений.
 */

using System;

public class LongWords {
    public static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        string str;
        for (int i = 1; i <= n; i++) {
            str = Console.ReadLine();
            int len = str.Length;
            char a = str[0];
            char b = str[len-1];
            if (len > 10) {
                Console.Write(a);
                Console.Write(len - 2);
                Console.WriteLine(b);
            } else {
                Console.WriteLine(str);
            }
        }  
    }
}
