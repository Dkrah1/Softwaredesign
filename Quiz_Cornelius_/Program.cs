using System;

namespace Quiz_Cornelius_
{
    class Program
    {
        public int questionCount;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ShowMainOptionsToUser(int questionCount, int credits)
        {
            string mainOptionsTopline = "Was möchtest Du tun?";
            Console.WriteLine(mainOptionsTopline);

            string[] mainOptionsChoices = { "1.Quiztyp auswählen", "2.Eigene Quizfragen erstellen", "3.Beenden" };

            int choice = Int32.Parse(CreateMenu(mainOptionsTopline, mainOptionsChoices));

            ShowQuizTypesToUser(questionCount, credits);
            CreateUserQuestion(questionCount, credits);

        }

        public static void ShowQuizTypesToUser(int questionCount, int credits)
        {
            string quizTypeSelectionTopline = " Welche Art von Quiz möchtest du spielen?" + credits;
            string[] quizTypeSelectionChoices = { "1.Standard", "2. Ja/Nein-Fragen", "3. Schätzfragen", "4. Multiple Answers", "5. Freitextantwort" };
            int choice = Int32.Parse(CreateMenu(quizTypeSelectionTopline, quizTypeSelectionChoices));

            TansferStandardQuestions(questionCount, credits);
            TransferYesNoQuestions(questionCount, credits);
            TransferEstimatedQuestions(questionCount, credits);
            TransferMultipleAnswerQuestion(questionCount, credits);
            TransferFreetextQuestion(questionCount, credits);
        }

        public static void CreateUserQuestion(int questionCount, int credits)
        {
            string quizTypeSelectionTopline = "Welche Art von Quiz möchtest du erstellen?" + credits;
            //Wert muss per Console.ReadLine abgefragt werden.
            string[] quizTypeSelectionChoices = { "1.Standard", "2. Ja/Nein-Fragen", "3. Schätzfragen", "4. Multiple Answers", "5. Freitextantwort" };
            //Wert muss per Console.ReadLine abgefragt werden.
            int choice = Int32.Parse(CreateMenu(quizTypeSelectionTopline, quizTypeSelectionChoices));

        }


        public static void TansferStandardQuestions(int questionCount, int credits)
        {
            int questionCount = 1;

            switch (questionCount)
            {
                case 1:


                    StandardQuizelement standardQuiz1 = new StandardQuizelement();
                    standardQuiz1.question = "...";
                    standardQuiz1.answers = new string[] { "...", "..." };
                    standardQuiz1.correct = 1;
                    standardQuiz1.CheckAnswerAndDisplayResult(ref standardQuiz1.question, standardQuiz1.answers, standardQuiz1.correct, questionCount, credits);
                    break;
            }

        }

        //Bearbeiten
        public static void TransferYesNoQuestions(int questionCount, int credits)
        {
            int questionCount = 1;

            switch (questionCount)
            {
                case 1:


                    StandardYesNoQuestion standardYesNoQuestion1 = new StandardYesNoQuestion();
                    standardYesNoQuestion1.question = "...";
                    standardYesNoQuestion1.answers = new string[] { "...", "..." };
                    standardYesNoQuestion1.correct = 1;
                    standardYesNoQuestion1.CheckAnswerAndDisplayResult(ref standardYesNoQuestion1.question, standardYesNoQuestion1.answers,
                    standardYesNoQuestion1.correct, questionCount, credits);
                    break;
            }

        }

        public static void TransferEstimatedQuestions(int questionCount, int credits)
        {
            int questionCount = 1;
            switch (questionCount)
            {
                case 1:
                    StandardEstimatedQuestion standardEstimatedQuestion1 = new StandardEstimatedQuestion();
                    standardEstimatedQuestion1.question = "...";
                    standardEstimatedQuestion1.answers = new string[] { "...", "..." };
                    standardEstimatedQuestion1.correct = 1;
                    standardEstimatedQuestion1.CheckAnswerAndDisplayResult( standardEstimatedQuestion1.question, standardEstimatedQuestion1.answers,
                    standardEstimatedQuestion1.correct, questionCount, credits);
                    break;
            }
        }

        public static void TransferMultipleAnswerQuestion(int questionCount, int credits)
        {
            int questionCount = 1;
            switch (questionCount)
            {
                case 1:
                    StandardMultipleAnswerQuestion standardMultipleAnswerQuestion1 = new StandardMultipleAnswerQuestion();
                    standardMultipleAnswerQuestion1.question = "...";
                    standardMultipleAnswerQuestion1.answers = new string[] { "...", "..." };
                    standardMultipleAnswerQuestion1.rightAnswers = new int[] { 1, 3 };
                    standardMultipleAnswerQuestion1.correct = 1;
                    standardMultipleAnswerQuestion1.CheckAnswerAndDisplayResult(ref standardMultipleAnswerQuestion1.question, standardMultipleAnswerQuestion1.answers,
                    standardMultipleAnswerQuestion1.correct, questionCount, credits);
                    break;
            }
        }

        public static void TransferFreeTextQuestion(int questionCount, int credits)
        {
            int questionCount = 1;
            switch (questionCount)
            {
                case 1:
                    StandardFreeTextQuestion standardFreeTextQuestion1 = new StandardFreeTextQuestion();
                    standardFreeTextQuestion1.question = "Was sagt der Hund zur Katze?";
                    standardFreeTextQuestion1.answers = new string[] { "Das ist richtig" };
                    standardFreeTextQuestion1.correct = "Das ist richtig";
                    standardFreeTextQuestion1.CheckAnswerAndDisplayResult(ref standardFreeTextQuestion1.question, standardFreeTextQuestion1.answers,
                    standardFreeTextQuestion1.correct, questionCount, credits);
                    break;
            }
        }





        public static string CreateMenu(string topline, string[] options)
        {
            short curItem = 0, c;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine(topline);
                for (c = 0; c < options.Length; c++)
                {
                    if (curItem == c)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(options[c]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(options[c]);
                        Console.ResetColor();
                    }
                }
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    curItem++;
                    if (curItem > options.Length - 1) curItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    curItem--;
                    if (curItem < 0) curItem = Convert.ToInt16(options.Length - 1);
                }
            } while (key.KeyChar != 13);
            return curItem.ToString();
        }


    }


}










