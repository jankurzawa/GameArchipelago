namespace GameArchipelago.Logic.Games.StonePaperScissors
{
    public class StonePaperScissorsHandler
    {
        private readonly Random random;
        public StonePaperScissorsHandler() 
            => random = new();

        public string RandomMove()
        {
            var number = random.Next(0, 3);
            if (number == 0) return "Rock";
            else if (number == 1) return "Paper";
            return "Scissors";
        }

        public string GetResult(string randomizedMove, string playersMove)
        {
            if (randomizedMove == playersMove) return "Draw";
            if (randomizedMove == "Rock" && playersMove == "Scissors") return "Opponents won";
            else if (randomizedMove == "Scissors" && playersMove == "Paper") return "Opponents won";
            else if (randomizedMove == "Paper" && playersMove == "Rock") return "Opponents won";
            else return "You won";
        }
    }
}
