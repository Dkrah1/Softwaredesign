using System;
using System.Xml.Serialization;
using System.IO;



namespace Quiz_Saving
{
    [Serializable]
    class QuizSingle
    {
        public string question;
        public string[] answers;
        public int correct;

        public static void ShowQuestionAndCheckIfSingleIsCorrect(string question, string[] answers, int correct, int score)
        {
            Console.Clear();
            Console.WriteLine(question + "\n" + answers[0] + "\n" + answers[1] + "\n" + answers[2] + "\n" + answers[3] + "\n");
            Console.WriteLine("Bitte wähle die richtige Antwort: ");
            int answerChoice = int.Parse(Console.ReadLine());

            if (answerChoice == correct)
            {
                Console.WriteLine("Korrekt!");
                score += 10;
            }
            else
            {
                Console.WriteLine("Falsch...");
            }
            Program.QuizMenu(score);
        }


        internal static void Serialize(string userQuestion, string userAnswers, int userCorrect, int score)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(userQuestion.GetType());
            FileStream str = new FileStream(@"C:/Users/Dome/Documents/GitHub/Softwaredesign/Quiz_Saving/test.xml", FileMode.Open);
            x.Serialize(str, userQuestion);

            System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(userAnswers.GetType());
            y.Serialize(str, userAnswers);

            System.Xml.Serialization.XmlSerializer z = new System.Xml.Serialization.XmlSerializer(userCorrect.GetType());
            z.Serialize(str, userCorrect);

            //Program p = new Program();
            Program.QuizMenu(score);
        }
    }
}

