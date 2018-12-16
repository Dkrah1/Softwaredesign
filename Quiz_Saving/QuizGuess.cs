using System;
using System.Xml.Serialization;
using System.IO;

namespace Quiz_Saving
{
    class QuizGuess
    {
        public string question;
        public int answer;
        public static void ShowQuestionAndCheckIfGuessIsCorrect(string question, int answer, int score)
        {
            Console.Clear();
            Console.WriteLine(question + "\n");
            Console.WriteLine("Please choose the right answer (tolernace = +/- 5):");

            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer < answer - 5 || userAnswer > answer + 5)
            {

                Console.WriteLine("Wrong answer");
            }
            else
            {
                Console.WriteLine("Right answer!");
                score += 10;
            }
            Program.QuizMenu(score);
        }

        internal static void Serialize(string userQuestion, int userAnswer, int score)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(userQuestion.GetType());
            FileStream str = new FileStream(@"C:/Users/Dome/Documents/GitHub/Softwaredesign/Quiz_Saving/test.xml", FileMode.Open);
            x.Serialize(str, userQuestion);

            System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(userAnswer.GetType());
            y.Serialize(str, userAnswer);

            /*System.Xml.Serialization.XmlSerializer z = new System.Xml.Serialization.XmlSerializer(userCorrect.GetType());
            z.Serialize(str, userCorrect);*/
            Program.QuizMenu(score);
        }

    }
}