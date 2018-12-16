using System;
using Newtonsoft.Json;
using System.IO;

namespace Quiz_Saving
{
    class QuizFree
    {
        public string question;
        public string answer;
        public static void ShowQuestionAndCheckIfFreeIsCorrect(string question, string answer, int score)
        {
            Console.Clear();
            Console.WriteLine(question + "\n");
            Console.WriteLine("Wähle die richtige Antworten (+/- 5):");

            string userAnswer = Console.ReadLine();

            if (userAnswer == answer)
            {
                Console.WriteLine("Richtig!");
                score += 10;
            }
            else
            {
                Console.WriteLine("Leider Falsch...");
            }
            Program.QuizMenu(score);
        }

        //internal static void Serialize(string question, string answer)
        //{
        //   throw new NotImplementedException();
        //}
        /*public static void Serialize(string question,string answer)
        {
            var json = File.ReadAllText(pathToTheFile);
            string content = JsonConvert.SerializeObject(free);
            File.WriteAllText("/QuizFree.json", content);
            Console.WriteLine(content);
        }*/
    }

}