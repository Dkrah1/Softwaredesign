using System;

namespace Reverse_Schnee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Person! Please enter a sentence to fullfile the quest.");
            string inputText = Console.ReadLine();

           string word = TurnAroundWord (inputText);
            

            Console.WriteLine(TurnAroundWord(inputText));
            TurnAroundSentence(inputText);
            TurnAroundWordAndSentence(inputText);
            Console.WriteLine("Ende");

        }

       public static string TurnAroundWord(string inputText)
        {
            char [] word = inputText.ToCharArray();             //Split(' ');
            Array.Reverse (word);
            inputText = string.Join (" ",word);

            return inputText;
            
           
        }

        public static void TurnAroundSentence(string inputText)
        {
            string [] splitter = inputText.Split(' ');
            for (int i = splitter.Length -1;i>=0; i--)
            {
                Console.WriteLine("Sentence: " + splitter[i]);
            }
        }

        public static string TurnAroundWordAndSentence(string inputText)
        {
            string [] splitter = inputText.Split(new char []{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = splitter.Length -1; i>=0;i--)
            {

                char [] words = splitter[i].ToCharArray();
                Array.Reverse(words);
                Console.WriteLine("Letters and Words: ");
                Console.WriteLine(words);
                

            }
            return null;
        }
    }
}
