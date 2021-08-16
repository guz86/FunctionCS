using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
  
        }
        public static string AlphabetPosition(string text)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string result = "";

            for (int j = 0; j < text.Length; j++)
            {


                for (int i = 0; i < letters.Length; i++)
                {
                    if (Char.ToLower(text[j]) == letters[i])
                    {
                        result += " " + (i + 1);
                    }
                }

            }
            result = result.Substring(1);
            return result;
        }

    }
}
