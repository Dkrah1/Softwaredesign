using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence: ");
            var text = Console.ReadLine();

            ReverseLetters(text);
            ReverseWord(text);
            ReverseWordAndLetter(text);

            Console.WriteLine(ReverseLetters(text));
            Console.WriteLine(ReverseWord(text));
            Console.WriteLine(ReverseWordAndLetter(text));

        }

        public static string ReverseLetters(string text)
        {
            string reversedString = "";
            foreach (var word in text.Split(' '))
            {
                string reversed = "";
                foreach (var letter in word.ToCharArray())
                {
                    reversed = letter + reversed;
                }
                reversedString = reversedString + reversed + " ";
            }
            return reversedString;
        }

        public static string ReverseWord(string text)
        {
            string[] word = text.Split(' ');
            Array.Reverse(word);
            return string.Join(" ", word);
        }

        public static string ReverseWordAndLetter(string text)
        {
            char[] CharacterArray = text.ToCharArray();
            string reverse = String.Empty;

            for (int i = CharacterArray.Length - 1; i > -1; i--)
            {
                reverse += CharacterArray[i];
            }
            return reverse;
        }

    }
}
