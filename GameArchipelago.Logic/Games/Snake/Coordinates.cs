namespace GameArchipelago.Logic.Games.Snake
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates() 
        {
            X = 10;
            Y = 10;
        }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
