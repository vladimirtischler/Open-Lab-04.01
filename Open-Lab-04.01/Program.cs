using System;

namespace ConsoleApp2
{

    class Program
    {
        public static bool DoubleLetters(string str)
        {
            char[] word = str.ToCharArray();
            for(int a = 0; a < str.Length - 1; a++)
            {
                if (word[a] == word[a + 1])
                {
                    return true;
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
