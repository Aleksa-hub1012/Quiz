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
    }    
}
