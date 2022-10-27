namespace GameArchipelago.Data.Model
{
    public class Highscore
    {
        public string Nickname { get; set; }
        public int Score { get; set; }

        public override string ToString()
            => $"{Nickname}: {Score} points";
    }
}
