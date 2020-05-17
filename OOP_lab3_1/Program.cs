using System;

namespace OOP_lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            str = "";

            for (int i = 0; i < words.Length; i += 2)
            {
                str += words[i] + " ";
            }
            
            words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            str = "";

            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i][0] != words[i][words[i].Length - 1])
                {
                    str += words[i] + " ";
                }
            }

            Console.WriteLine(str);
        }
    }
}
