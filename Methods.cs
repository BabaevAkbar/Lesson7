using System;
using System.Text;

namespace Program
{
    class Methods
    {
        /// <summary>
        /// Все гласные буквы на символ '*'
        /// </summary>
        /// <param name="Текст"></param>
        /// <returns>string</returns>
        public static string ReplaceVowels(string message)
        {
            string[] vowels = {"А","а","Е","е","Ё","ё","О","о","У","у","И","и","Э","э","Ы","ы","Я","я","Ю","ю"};
            foreach(char i in message)
            {
                foreach(string j in vowels)
                {
                    if(i.ToString() == j)
                    {
                        message = message.Replace(i, '*');
                    }
                }
            }
            return message;
        }

        /// <summary>
        /// Все пробелы на символ '_’
        /// </summary>
        /// <param name="Текст"></param>
        /// <returns>string</returns>
        public static string ReplaceSpace(string message)
        {
            message = message.Replace(' ', '_');
            return message;
        }

        /// <summary>
        /// Возвращвет количество слов в строке
        /// </summary>
        /// <param name="Текст"></param>
        /// <returns>int</returns>
        public static int CountWord(string message)
        {
            string[] messArray = message.Split(' ');
            return messArray.Length;
        }

        /// <summary>
        /// Находит самое длинное слово
        /// </summary>
        /// <param name="Текст"></param>
        /// <returns>string</returns>
        public static string LongOffer(string message)
        {
            message = message.Replace(",", "");
            message = message.Replace(".", "");
            message = message.Replace("!", "");
            string[] messageNew = message.Split(' ');
            int lengthMes = messageNew.Length;

            string max = string.Empty;
            foreach(string i in messageNew)
            {
                if(max.Length < i.Length)
                {
                    max =i;
                }
            }
            return max;
        }

        /// <summary>
        /// Возвращает количество чисел в строке
        /// </summary>
        /// <param name="Текст"></param>
        /// <returns>int</returns>
        public static int CountNum(string message)
        {
            string[] numbers = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            int count = 0;
            foreach(char i in message)
            {
                foreach(string j in numbers)
                {
                    if(i.ToString() == j)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Выводит день недели текущего числа и просчитает отстое дней до ближайщего понедельника.
        /// </summary>
        /// <param name="Текущая дата"></param>
        public static void DayWeek(DateTime now)
        {
            DayOfWeek dayWeek = now.DayOfWeek;
            int index = 0;
            if(now.DayOfWeek != DayOfWeek.Monday)
            {
                now = now.AddDays(1);
                index ++;
            }
            Console.WriteLine($"День недели данного числа {dayWeek}.");
            Console.WriteLine($"До следующего понедельника отсалось {index} дней.");
        }

        /// <summary>
        /// С помощь StringBuilder создает строку с определенными симолами n раз 
        /// </summary>
        /// <param name="Количество симолов"></param>
        /// <param name="Символ"></param>
        public static void AddStrBuilder(int a, string b)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= a; i++)
            {
                sb.Append(b);
                Console.WriteLine($"{i}-{sb[i-1]}");
            }
        }
    }

}