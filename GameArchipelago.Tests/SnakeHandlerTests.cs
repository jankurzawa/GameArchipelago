namespace GameArchipelago.Tests
{
    [TestFixture]
    public class SnakeHandlerTests
    {
        private SnakeHandler snakeHandler;

        [SetUp]
        public void Setup() 
            => snakeHandler = new SnakeHandler();

        [Theory]
        [TestCase("left", 9, 10)]
        [TestCase("right", 11, 10)]
        [TestCase("up", 10, 9)]
        [TestCase("down", 10, 11)]
        public void MoveSnake_ForGivenDirection_MovedInCorrectWay(string direction, int expectedX, int expectedY)
        {
            snakeHandler.Direction = direction;
            snakeHandler.MoveSnake();
            Assert.AreEqual(expectedX, snakeHandler.Snake[0].X);
            Assert.AreEqual(expectedY, snakeHandler.Snake[0].Y);
        }
        [Test]
        public void EatFood_Called_IncreasesScoreBy1()
        {
            var expectedScore = snakeHandler.Score + 1;
            snakeHandler.EatFood();
            Assert.AreEqual(expectedScore, snakeHandler.Score);
        }
        [Test]
        public void EatFood_Called_IncreasesLengthSnakeBy1()
        {
            var expectedSnake = snakeHandler.Snake.Count + 1;
            snakeHandler.EatFood();
            Assert.AreEqual(expectedSnake, snakeHandler.Snake.Count);
        }
    }
}
