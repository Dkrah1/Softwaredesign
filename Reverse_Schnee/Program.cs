using System;

namespace Reverse_Schnee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Person! Please enter a sentence to fullfile the quest.");
            string inputText = Console.ReadLine();

            TurnAroundWord (inputText);
            TurnAroundSentence(inputText);
            TurnAroundWordAndSentence(inputText);

            Console.WriteLine(TurnAroundWord(inputText));
            Console.WriteLine("Ende");

        }

        public static string TurnAroundWord(string inputText)
        {
            string [] word = inputText.Split(' ');
            Array.Reverse (word);
            return string.Join (" ",word);
        }

        public static void TurnAroundSentence(string inputText)
        {
            string [] splitter = inputText.Split(new char());
            for (int i = splitter.Length -1;i>=0; i--)
            {
                Console.WriteLine(splitter[i]);
            }
        }

        public static string TurnAroundWordAndSentence(string inputText)
        {
            string [] splitter = inputText.Split(new char []{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = splitter.Length -1; i>0;i--)
            {
                char [] words = splitter[i].ToCharArray();
                Array.Reverse(words);
                Console.WriteLine(words);
            }
            return null;
        }
    }
}
