using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Quiz
{
    class Program
    {
        static int score = 0;
        static int currentQuestion = 0;
        static List<Quizelement> questionPool = new List<Quizelement>();
        public static void Main(string[] args)
        {

            GenerateDefaultQuestions();
            while (getUserInteraction() == false) { }
        }

        public static void GenerateDefaultQuestions()
        {
            Quizelement quiz1 = new Quizelement(
                

                 "Wer war der 1.Bundeskanzler der BRD?",
                new Answer[] {
                    new Answer("Barack Obama", false),
                    new Answer("Helmut Kohl", false),
                    new Answer( "Konrad Adenauer", true),
                    new Answer( "Angela Merkel", false )
                }
                
            );
            string json = JsonConvert.SerializeObject(quiz1);
            Console.Write(json);

            Quizelement quiz2 = new Quizelement(
                  "In welcher Beziehung stand Hera zu Zeus?",
                new Answer[] {
                    new Answer("Tochter und Vater", false),
                    new Answer("Frau und Schwester", true),
                    new Answer( "Mutter und Sohn", false),
                    new Answer( "Tante und Neffe", false )
                }
            );

            questionPool.Add(quiz1);
            questionPool.Add(quiz2);
        }

        public static void AddQuestionToPool()
        {
            //Console.Clear();

            Console.Write("Please enter question: \n> ");
            string addedQuestion = Console.ReadLine();

            Console.Write("Set question count: \n> ");
            int answerCount = Convert.ToInt32(Console.ReadLine());

            Answer[] newAnswers = new Answer[answerCount];

            Console.Write("Please write your first AND right answer: \n> ");
            newAnswers[0] = new Answer(Console.ReadLine(), true);
            for (int i = 1; i < answerCount; i++)
            {
                Console.Write("Please enter next answer: \n> ");
                newAnswers[i] = new Answer(Console.ReadLine(), false);
            }

            questionPool.Add(new Quizelement(addedQuestion, newAnswers));

        }

        public static void PlayTheGame(Quizelement quiz)
        {
           // Console.Clear();

            quiz.showQuestion();
            Console.Write("\nSprich die Antwort und tritt ein: \n>");
            if (quiz.answers[Convert.ToInt32(Console.ReadLine()) - 1].IsCorrect())
            {
                score += 10;
                Console.WriteLine("For the King. (Score + 10)");

            }
            else
            {
                Console.WriteLine("You shall not pass");
            }
            currentQuestion++;
        }

        public static Boolean getUserInteraction()
        {
           // Console.Clear();

            Console.Write("Your score: " + score + "\n\n");
            Console.WriteLine("Do you want to answer the question (p) or add a question to the questionpool(a) or quit the game (q)");
            string command = Console.ReadLine();
            if (command == "p")
            {
                if (currentQuestion < questionPool.Count)
                {
                    PlayTheGame(questionPool[currentQuestion]);
                }
                else
                {
                    //Console.Clear();
                    Console.WriteLine("GAME OVER \n Thanks for playing. \n Your score is: " + score);
                    return true;
                }
                return false;
            }
            else if (command == "a")
            {
                AddQuestionToPool();
                return false;
            }
            else
            {
                //Console.Clear();
                Console.WriteLine("GAME OVER \n Thanks for playing. \n Your score is: " + score);
                return true;
            }

        }
    }
}