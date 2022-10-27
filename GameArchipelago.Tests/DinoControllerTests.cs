namespace GameArchipelago.Tests
{
    [TestFixture]
    public class DinoControllerTests
    {
        private readonly DinoController _dinoControler;

        public DinoControllerTests()
            => _dinoControler = new DinoController();

        [Test]
        public void ShouldResetObstacleAfterItGoesOutOfBounds()
        {
            int obstacleLeft = 0;
            int restult = _dinoControler.HandleObstacle(obstacleLeft);
            Assert.That(restult > 599 && restult < 1000);
        }

        [Test]
        public void ShouldMoveObstacleToLeft()
        {
            int obstacleLeft = 100;
            int result = _dinoControler.HandleObstacle(obstacleLeft);
            Assert.That(result.Equals(90));
        }

        [Test]
        public void ShouldOffsetObstacleByRandomNumberInRange()
        {
            int obstacleLeft = 100;
            int result = _dinoControler.HandleObstacleCollision(obstacleLeft);
            Assert.That(result > 199 && result < 399);
        }

        [Test]
        public void ShouldOffSetObstacleByValue()
        {
            int obstacleLeft = 100;
            int offSet = 50;
            int result = _dinoControler.OffsetObstacleByValue(obstacleLeft, offSet);

            Assert.That(result.Equals(150));
        }

        [Test]
        [Repeat(10)]
        public void ShouldResetObstaclePositionBetweenRange()
        {
            int result = _dinoControler.ResetObstaclePosition();
            Assert.That(result > 369 && result < 530);
        }
    }
}
