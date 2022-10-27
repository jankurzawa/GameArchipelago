namespace GameArchipelago.Tests
{
    [TestFixture]
    public class StonePaperScissorsHandlerTests
    {
        [Theory]
        [TestCase("Rock", "Rock", "Draw")]
        [TestCase("Rock", "Scissors", "Opponents won")]
        [TestCase("Scissors", "Rock", "You won")]
        [TestCase("Rock", "Paper", "You won")]
        [TestCase("Paper", "Rock", "Opponents won")]
        [TestCase("Paper", "Scissors", "You won")]
        public void GetResult_ForGivenArguments_ReturnsCorrectValue(string firstValue, string secondValue, string expectedResult)
        {
            StonePaperScissorsHandler spcHandler = new();
            var returnedResult = spcHandler.GetResult(firstValue, secondValue);
            Assert.AreEqual(expectedResult, returnedResult);
        }
    }
}
