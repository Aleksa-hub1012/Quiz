using System;
using Quiz;

namespace QuizService
{
    public class QuizProgram
    {
        static void Main(string[] args)
        {
            var quiz = new QuizGame();
            Console.WriteLine($"Quiz started. Score: {quiz.Score}, correct answers: {quiz.CorrectAnswers}, total: {quiz.TotalQuestionsAnswered}");

            quiz.GiveAnswer(true, 10);
            Console.WriteLine($"After correct answer: Score = {quiz.Score}, Correct = {quiz.CorrectAnswers}, Total = {quiz.TotalQuestionsAnswered}, Percentage = {quiz.CorrectAnswerPercentage}%");

            quiz.GiveAnswer(false, 10);
            Console.WriteLine($"After incorrect answer: Score = {quiz.Score}, Correct = {quiz.CorrectAnswers}, Total = {quiz.TotalQuestionsAnswered}, Percentage = {quiz.CorrectAnswerPercentage}%");

            quiz.GiveAnswer(true, 5);
            Console.WriteLine($"After another correct answer: Score = {quiz.Score}, Correct = {quiz.CorrectAnswers}, Total = {quiz.TotalQuestionsAnswered}, Percentage = {quiz.CorrectAnswerPercentage}%");

            quiz.Restart();
            Console.WriteLine($"Game restarted. Score: {quiz.Score}, Correct: {quiz.CorrectAnswers}, Total: {quiz.TotalQuestionsAnswered}, Percentage = {quiz.CorrectAnswerPercentage}%");
        }
    }
}
