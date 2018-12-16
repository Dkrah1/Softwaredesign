using System;

namespace Quiz
{
    class Quizelement 
    {
        public string question;

        public Answer [] answers;

        public Quizelement(string question, Answer[] answers) //Konstruktor
        {
            this.question = question;
            this.answers = answers;
        }

    public void showQuestion()
    {
        Console.Write(question + "\n");
        for(int i = 0; i < answers.Length; i++ )
        {
            Console.WriteLine(i+1 + ")" + answers[i].answer);
        }
    }
    }
}
