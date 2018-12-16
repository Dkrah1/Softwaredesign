using System;
using System.IO;
using System.Xml; //using xml reader 
using System.Xml.Serialization;
//using Newtonsoft;
//using Newtonsoft.Json;

namespace Quiz_Saving
{

    [Serializable]
    class Program
    {
        public int score = 0;

        static void Main(string[] args)
        {
            int score = 0;
            QuizMenu(score);
        }

        public static void QuizMenu(int score)
        {
            Console.WriteLine("Score: " + score + "\nWas möchtest Du tun? \n1. Fragen beantworten \n2. Neue Fragen hinzufügen \n3. Das Program beenden");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayTheGame(score);
                    break;
                case 2:
                    AddNewQuestion(score);
                    break;
                default:
                    Console.WriteLine("Das Programm wird beendet!");
                    break;
            }
        }

        public static void PlayTheGame(int score)
        {
            //Console.Clear();
            Console.WriteLine("Was für eine Frage möchtest Du beantworten? \n\n1. Normales Quiz \n2. Multiple Choice \n3. Ja/Nein Frage \n4. Zahlen raten \n5. Freitextantworten");
            int questionType = Convert.ToInt32(Console.ReadLine());

            switch (questionType)
            {
                case 1:
                    QuizSingle single = new QuizSingle();
                    single.question = "Wer war der erste Bundeskanzler der BRD?";
                    single.answers = new string[] { "1. Barrack Obama", "2. Helmut Kohl", "3. Konrad Adenauer", "4. Angela Merkel" };
                    single.correct = 3;
                    QuizSingle.ShowQuestionAndCheckIfSingleIsCorrect(single.question, single.answers, single.correct, score);
                    break;
                case 2:
                    QuizMultiple multiple = new QuizMultiple();
                    multiple.question = "How long does the 30-year war last??";
                    multiple.answers = new string[] { "1. 10950", "2. 30", "3. 4643356", "4. 262800" };
                    multiple.correct = new string[] { "1", "2", "4" };
                    QuizMultiple.ShowQuestionAndCheckIfMultipleIsCorrect(multiple.question, multiple.answers, multiple.correct, score);
                    break;
                case 3:
                    QuizBinary binary = new QuizBinary();
                    binary.question = "Is Gandalf a wizard?";
                    binary.answer = "Yes";
                    QuizBinary.ShowQuestionAndCheckIfBinaryIsCorrect(binary.question, binary.answer, score);
                    break;
                case 4:
                    QuizGuess guess = new QuizGuess();
                    guess.question = "Wie viele Tage hat ein Jahr?\n";
                    guess.answer = 365;
                    QuizGuess.ShowQuestionAndCheckIfGuessIsCorrect(guess.question, guess.answer, score);
                    break;
                case 5:
                    QuizFree free = new QuizFree();
                    free.question = "What does Gandalf say to the Balrok on the bridge of Kazad-dum?\n";
                    free.answer = "You shall not pass";
                    QuizFree.ShowQuestionAndCheckIfFreeIsCorrect(free.question, free.answer, score);
                    break;
                default:
                    Console.WriteLine("Sorry! There are no questions left. Your score is: " + score);
                    break;
            }
        }

        public static void AddNewQuestion(int score)
        {
            //Console.Clear();
            Console.WriteLine("What question type do you wanna create? \n\n1. Noraml quiz \n2. Multiple Choice \n3. Yes/No \n4. Guess \n5. Free text");
            int questionType = Convert.ToInt32(Console.ReadLine());

            switch (questionType)
            {
                case 1:
                    AddNewSingleQuiz(score);
                    break;
                case 2:
                    AddNewMultipleQuiz(score);
                    break;
                case 3:
                    AddNewBinaryQuiz(score);
                    break;
                case 4:
                    AddNewGuessQuiz(score);
                    break;
                case 5:
                    AddNewFreeQuiz(score);
                    break;
                default:
                    Console.WriteLine("The program quit!");
                    break;
            }


        }

        public static void AddNewSingleQuiz(int score)
        {
            Console.WriteLine("Write your question\n");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("Write answer/s\n");
            string userAnswers = Console.ReadLine();
            Console.WriteLine("Which answer is correct?\n");
            int userCorrect = int.Parse(Console.ReadLine());
            QuizSingle single = new QuizSingle();
            single.question = userQuestion;
            single.answers = userAnswers.Split(",");
            single.correct = userCorrect;
            QuizSingle.ShowQuestionAndCheckIfSingleIsCorrect(single.question, single.answers, single.correct, score);
            QuizSingle.Serialize(userQuestion, userAnswers, userCorrect, score);
        }

        public static void AddNewMultipleQuiz(int score)
        {
            Console.WriteLine("Write your question\n");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("Write answer/s\n");
            string userAnswers = Console.ReadLine();
            Console.WriteLine("Which answer is correct?\n");
            string userCorrect = Console.ReadLine();
            QuizMultiple multiple = new QuizMultiple();
            multiple.question = userQuestion;
            multiple.answers = userAnswers.Split(",");
            multiple.correct = userCorrect.Split(',');
            QuizMultiple.ShowQuestionAndCheckIfMultipleIsCorrect(multiple.question, multiple.answers, multiple.correct, score);
            QuizMultiple.Serialize(userQuestion, userAnswers,userCorrect, score);

        }

        public static void AddNewBinaryQuiz(int score)
        {
            Console.WriteLine("Write your question\n");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("Write answer/s\n");
            string userAnswer = Console.ReadLine();
            QuizBinary binary = new QuizBinary();
            binary.question = userQuestion;
            binary.answer = userAnswer;
            QuizBinary.ShowQuestionAndCheckIfBinaryIsCorrect(binary.question, binary.answer, score);
            QuizBinary.Serialize(userQuestion, userAnswer, score);

        }

        public static void AddNewGuessQuiz(int score)
        {
            Console.WriteLine("Write your question?\n");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("Write answer/s\n");
            int userAnswer = int.Parse(Console.ReadLine());
            QuizGuess guess = new QuizGuess();
            guess.question = userQuestion;
            guess.answer = userAnswer;
            QuizGuess.ShowQuestionAndCheckIfGuessIsCorrect(guess.question, guess.answer, score);
            QuizGuess.Serialize(userQuestion, userAnswer, score);
        }

        public static void AddNewFreeQuiz(int score)
        {
            Console.WriteLine("Write your question?\n");
            string userQuestion = Console.ReadLine();
            Console.WriteLine("Write answer/s\n");
            string userAnswer = Console.ReadLine();
            QuizFree free = new QuizFree();
            free.question = userQuestion;
            free.answer = userAnswer;
            QuizFree.ShowQuestionAndCheckIfFreeIsCorrect(free.question, free.answer, score);
            QuizFree.Serialize(userQuestion, userAnswer, score);
        }




    }
}
