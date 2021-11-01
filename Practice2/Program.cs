using System;

namespace Practice2
{
    class Quiz
    {
        //Attributes
        string[] question = new string[10];
        string[] answer = new string[10];
        int totalQuestions = 0;
        int currentQuestion = 0;
        int correctQuestions = 0;

        //Methods
        public void addQuestion(string q, string a)
        {
            question[totalQuestions] = q;
            answer[totalQuestions++] = a;
            return;
        }

        public void giveQuiz()
        {
            while (currentQuestion < totalQuestions)
            {
                Console.WriteLine("Question #{0}: ", question[currentQuestion]);
                Console.Write("Enter your answer: ");
                string response = Console.ReadLine();
                if (response == answer[currentQuestion++])
                {
                    correctQuestions++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Quiz finished. You scored {0} out of {1}, resulting in a {2:F2}%.",
                                correctQuestions, totalQuestions, Convert.ToDouble(correctQuestions/totalQuestions));
        }
    }

    class QuizTime
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Quiz A = new Quiz();

            Console.WriteLine("Enter questions and answers below. A maximum of 10 questions will be taken. Enter QUIT when finished");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter question: ");
                string temp = Console.ReadLine();
                Console.Write("Enter question answer: ");
                string temp2 = Console.ReadLine();

                if (temp == "QUIT" || temp2 == "QUIT")
                {
                    break;
                }

                A.addQuestion(temp, temp2);
            }

            Console.WriteLine("Quiz is ready. Please enter GO to begin.");
            
            string temp3 = Console.ReadLine();
            while (temp3 != "GO")
            {
                temp3  = Console.ReadLine();
            }
            A.giveQuiz();
        }
    }
}
