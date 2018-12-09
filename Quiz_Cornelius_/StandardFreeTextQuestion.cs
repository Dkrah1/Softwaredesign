using System;

namespace Quiz_Cornelius_
{
    class StandardFreeTextQuestion : StandardQuizelement
    {
        public string question;
        public string correct;

        public static void CheckAnswerAndDisplayResult(int question, string[] answers, string correct, int questionCount, int credits)
        {
            string userAnswer = Console.ReadLine();
            if (userAnswer == correct)
            {
                credits += 10;
                questionCount += 1;
                Program.ShowMainOptionsToUser(questionCount, credits);
            }
            else
            {
                questionCount = questionCount +1;
                Program.ShowMainOptionsToUser(questionCount,credits);
            }
        }
    }
}