using System;
using System.Xml.Serialization;
using System.IO;


namespace Quiz_Saving
{
    class QuizBinary
    {
        public string question;
        public string answer;
        public static void ShowQuestionAndCheckIfBinaryIsCorrect(string question, string answer, int score)
        {
            Console.Clear();
            Console.WriteLine(question + "\n");
            Console.WriteLine("Please choose the rigth answer (Yes or No):");

            string userAnswer = Console.ReadLine();

            if (userAnswer == answer)
            {
                Console.WriteLine("Rigth answer good one!");
                score += 10;
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            Program.QuizMenu(score);

        }

        internal static void Serialize(string userQuestion, string userAnswer, int score)
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
