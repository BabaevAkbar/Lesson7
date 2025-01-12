using System;

namespace Program
{
    class Methods
    {
        /// <summary>
        /// Все гласные буквы на символ '*'
        /// </summary>
        /// <param name="message"></param>
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
        /// <param name="message"></param>
        /// <returns>string</returns>
        public static string ReplaceSpace(string message)
        {
            message = message.Replace(' ', '_');
            return message;
        }

        /// <summary>
        /// Возвращвет количество слов в строке
        /// </summary>
        /// <param name="message"></param>
        /// <returns>int</returns>
        public static int CountWord(string message)
        {
            string[] messArray = message.Split(' ');
            return messArray.Length;
        }

        /// <summary>
        /// Находит самое длинное слово
        /// </summary>
        /// <param name="message"></param>
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
        /// <param name="message"></param>
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
    }

}