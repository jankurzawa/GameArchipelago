namespace GameArchipelago.Logic.Highscores
{
    public class HighscoreController
    {
        private readonly ISerializer<Highscore> _highscoreSerializer;

        public HighscoreController(ISerializer<Highscore> highscoreSerializer)
            => _highscoreSerializer = highscoreSerializer;

        private List<Highscore> GetHighscoresCollection()
            => _highscoreSerializer.DeserializeFromFile().OrderByDescending(x => x.Score).ToList();

        public Highscore GetNewHighscore(string nickName, int score)
            => new() { Nickname = nickName, Score = score };

        public void SaveHighscore(Highscore highscore)
        {
            var highscores = GetHighscoresCollection();
            highscores.Add(highscore);
            _highscoreSerializer.SerializeToFile(highscores);
        }

        public static IEnumerable<Highscore> GetData(string fileName, int amountOfRecords)
            => new Serializer<Highscore>(fileName).DeserializeFromFile().OrderByDescending(x => x.Score).Take(amountOfRecords).ToList();
    }
}
