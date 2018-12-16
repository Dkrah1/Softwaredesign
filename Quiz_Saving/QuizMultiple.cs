using System;
using System.Xml.Serialization;
using System.IO;



namespace Quiz_Saving
{
    class QuizMultiple
    {
        public string question;
        public string[] answers;
        public string[] correct;
        public static void ShowQuestionAndCheckIfMultipleIsCorrect(string question, string[] answers, string[] correct, int score)
        {
            Console.Clear();
            Console.WriteLine(question + "\n" + answers[0] + "\n" + answers[1] + "\n" + answers[2] + "\n" + answers[3] + "\n");

            Console.WriteLine("Please choose the right answer (seperate your answers with , ):");

            string multipleAnswers = Console.ReadLine();
            string[] answer = multipleAnswers.Split(',');

            if (answer[0] == correct[0] && answer[1] == correct[1] && answer[2] == correct[2])
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
        internal static void Serialize(string userQuestion, string userAnswers, string userCorrect, int score)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(userQuestion.GetType());
            FileStream str = new FileStream(@"C:/Users/Dome/Documents/GitHub/Softwaredesign/Quiz_Saving/test.xml", FileMode.Open);
            x.Serialize(str, userQuestion);

            System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(userAnswers.GetType());
            y.Serialize(str, userAnswers);

            System.Xml.Serialization.XmlSerializer z = new System.Xml.Serialization.XmlSerializer(userCorrect.GetType());
            z.Serialize(str, userCorrect);
            Program.QuizMenu(score);
        }
    }
}