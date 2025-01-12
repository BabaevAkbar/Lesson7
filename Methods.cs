using System;

namespace Program
{
    class Methods
    {
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

        public static string ReplaceSpace(string message)
        {
            message = message.Replace(' ', '_');
            return message;
        }
    }

}