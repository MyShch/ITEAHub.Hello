using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.Math
{
    public class AddQuestion
    {
        public List<Question> questions = new List<Question>();


        public void Add()
        {
            Console.WriteLine("Write Question");
            var question = Console.ReadLine();

            var questionConsole = new Question
            {
                QuestionBody = question
            };

            questionConsole.Answers = new List<Answer>();
            Console.WriteLine("Write all answers:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Write {i+1}");

                var answerStr = Console.ReadLine();
                Console.WriteLine("1 - true, 0 -false");

                var isCorrect = Console.ReadLine();

                Answer answer = new Answer
                {
                    AnswerBody = answerStr
                };

                if (isCorrect == "true")
                {
                    answer.IsCorrect = true;
                }
                else
                {
                    answer.IsCorrect = false;
                }

               
                questionConsole.Answers.Add(answer);
            }

        }

    }
}
