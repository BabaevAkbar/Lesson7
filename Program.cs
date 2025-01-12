using System;
using Program;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("Введите текст:");
            string? message = Console.ReadLine();
            Methods.ReplaceVowels(message);
        }
    }
}