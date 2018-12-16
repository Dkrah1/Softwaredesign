using System;
using System.Xml.Serialization;
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
            Console.WriteLine("Please choose the right answer(+/- 5):");

            string userAnswer = Console.ReadLine();

            if (userAnswer == answer)
            {
                Console.WriteLine("Right answer good one!");
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