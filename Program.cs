using System;
using Program;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Введите текст:");
            string? message = Console.ReadLine();
            string result = Methods.ReplaceVowels(message);
            Console.WriteLine(result);

            string result1 = Methods.ReplaceSpace(message);
            Console.WriteLine(result1);
        }
    }
}