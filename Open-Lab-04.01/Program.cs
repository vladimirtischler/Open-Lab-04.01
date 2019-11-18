using System;

namespace ConsoleApp2
{

    class Program
    {
        public static bool DoubleLetters(string str)
        {
            char[] word = str.ToCharArray();
            foreach (var c in word)
            {
                for (int a = 0; a == 2;)
                {
                    if (c == word[a])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string w = Console.ReadLine();
            Console.WriteLine(DoubleLetters(w));
        }
    }
}
