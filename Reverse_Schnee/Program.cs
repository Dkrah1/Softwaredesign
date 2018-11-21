using System;
using System.Collections.Generic;
using System.Collections;

namespace Reverse_Schnee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Person! Please enter a sentence to fullfile the quest.");
            string inputText = Console.ReadLine();
            TurnAroundLetterButKeepWordOrder(inputText);
            TurnAroundWord(inputText);
            TurnAroundWordAndSentence(inputText);


            Console.WriteLine(TurnAroundLetterButKeepWordOrder(inputText));
            Console.WriteLine(TurnAroundWord(inputText));
            Console.WriteLine(TurnAroundWordAndSentence(inputText));


        }
        public static string TurnAroundLetterButKeepWordOrder(string inputText)
        {
            string reverse = TurnAroundWordAndSentence(inputText);
            string reverse_two = TurnAroundWord(reverse);
            return reverse_two;
            /*List<string> listofWords = new List<string>();
            string[] splitter = inputText.Split(' ');
            for (int i = splitter.Length - 1; i >= 0; i--)
            {
                listofWords.Add(splitter[i]);
                //Console.WriteLine("Sentence: " + splitter[i]);
            }
            listofWords.Reverse();
            return string.Join("", listofWords.ToArray());*/
        }
        public static string TurnAroundWord(string inputText)
        {
            string[] word = inputText.Split(' ');             //Split(' ');
            Array.Reverse(word);
            inputText = string.Join(" ", word);

            return inputText;


        }
        public static string TurnAroundWordAndSentence(string inputText)
        {
            char[] splitter = inputText.ToCharArray();            //(new char []{' '}, StringSplitOptions.RemoveEmptyEntries);
            string reverse = String.Empty;
            for (int i = splitter.Length - 1; i >= 0; i--)
            {
                reverse += splitter[i];
                //var listofSentence = reverse.ToString();

                /*char [] words = splitter[i].ToCharArray();
                Array.Reverse(words);
                //listofSentence.Add(words);
                var list = words.ToString();
                List<char> myList = new List<char>(words);
                Console.WriteLine(myList);*/


            }
            return reverse;
        }
    }
}
