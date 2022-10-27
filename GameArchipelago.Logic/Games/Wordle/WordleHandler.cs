namespace GameArchipelago.Logic.Games.Wordle
{
    public class WordleHandler
    {
        private const int PointsPerTurn = 2000;
        private const int PointsPenaltyPerSecond = 10;
        private const string WordsFileName = "Words.txt";
       
        public string WordToGuess { get; private set; }

        public WordleHandler()
            => GetWordToGuess();

        private void GetWordToGuess()
        {
            var wordsList = new FileReader(WordsFileName).GetDataFromFile().ToList();
            WordToGuess = wordsList[new Random().Next(0, wordsList.Count)].ToUpper();
        }

        public int CountSameCharsInWord(string charToCount)
            => Regex.Matches(WordToGuess, charToCount).Count;

        public bool IsMatch(string wordToMatch)
            => WordToGuess.Equals(wordToMatch);

        public bool IsMatch(string charToMatch, int index)
            => WordToGuess[index].ToString() == charToMatch;

        public int CalculateScore(int remainingTurns, int gameTime)
            => remainingTurns * PointsPerTurn - gameTime * PointsPenaltyPerSecond;
    }
}
