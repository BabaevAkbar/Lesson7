using System;
using Program;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Введите текст:");
            // string? message = Console.ReadLine();
            // //Задание 1
            // string result = Methods.ReplaceVowels(message);
            // Console.WriteLine(result);

            // string result1 = Methods.ReplaceSpace(message);
            // Console.WriteLine(result1);

            // //Задание 2
            // int result2 = Methods.CountWord(message);
            // Console.WriteLine($"Количество слово в данной строке {result2}");

            // string result3 = Methods.LongOffer(message);
            // Console.WriteLine($"Самое длинное слово в данной строке {result3}");

            // int result4 = Methods.CountNum(message);
            // Console.WriteLine($"Количество чисел в строке составляет {result4}");

            //Задание 3
            DateTime now = DateTime.UtcNow;
            Methods.DayWeek(now);
        }
    }
}