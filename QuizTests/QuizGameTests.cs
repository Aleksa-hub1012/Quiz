using Xunit;
using Quiz; // Підключаємо основний проєкт

namespace Quiz.Tests
{
    public class QuizGameTests
    {
        [Fact]
        public void Constructor_WhenGameStarts_ShouldInitializeWithZeroStats()
        {
            var game = new QuizGame();

            Assert.Equal(0, game.Score);
            Assert.Equal(0, game.CorrectAnswers);
            Assert.Equal(0, game.TotalQuestionsAnswered);
            Assert.Equal(0.0, game.CorrectAnswerPercentage);
        }

        [Fact]
        public void GiveAnswer_WhenCorrect_ShouldIncreaseScoreAndCounts()
        {
            var game = new QuizGame();
            int points = 10;

            game.GiveAnswer(true, points);

            Assert.Equal(10, game.Score);
            Assert.Equal(1, game.CorrectAnswers);
            Assert.Equal(1, game.TotalQuestionsAnswered);
        }
    }    
}
