using System;

namespace Quiz_Cornelius_
{
    class StandardEstimatedQuestion : StandardQuizelement
    {
        public string question;
        public int correct;

        public static void CheckAnswerAndDisplayResult(int question, string[] answers, int correct, int questionCount, int credits)
        {
            int choice = Int32.Parse(Console.ReadLine());
            if (correct <= choice || correct >= choice)
            {
                credits += 10;
                questionCount += 1;
                Program.ShowMainOptionsToUser(questionCount, credits);
            }
            else
            {
                questionCount = questionCount + 1;
                Program.ShowMainOptionsToUser(questionCount, credits);
            }


        }
    }
}