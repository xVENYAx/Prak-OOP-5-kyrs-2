using System;

namespace Практика_ООП__5_курс_2
{
    class Program
    {
        static string Reverse(string str)
        {
            //змінна для зберігання результату
            var retValue = string.Empty;
            foreach (var symbol in str)
            {
                //приклеюємо символ на початок рядка
                retValue = symbol + retValue;
            }

            return retValue;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть текст для реверсування: ");
            var s = Console.ReadLine();
            Console.WriteLine($"Реверс рядка: {Reverse(s)}");
            Console.ReadLine();
        }
    }
}
