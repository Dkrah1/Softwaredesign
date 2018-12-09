using System;

namespace Quiz_Cornelius_
{
    class StandardMultipleAnswerQuestion : StandardQuizelement
    {
       public string question;
        public string[] answers;
        public static int[] rightAnswers;


        public static void CheckAnswerAndDisplayResult(int question, string[] answers, int correct, int questionCount, int credits)
        {
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == rightAnswers)
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