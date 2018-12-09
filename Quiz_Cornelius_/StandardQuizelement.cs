using System;
using System.Collections.Generic;

namespace Quiz_Cornelius_
{
    class StandardQuizelement
    {
        public string question;
        public string[] answers;

        public int correct;

        public static void CheckAnswerAndDisplayResult(string question, string[] answers, int correct, int questionCount, int credits)
        {
            int choice = Int32.Parse(Console.ReadLine());
            if (correct == choice)
            {
                credits += 10;
                questionCount += 1;
                Program.ShowMainOptionsToUser(questionCount, credits);
            }
            else
            {
                questionCount += 1;
                Program.ShowMainOptionsToUser(questionCount, credits);
            }

        }



    }


}
