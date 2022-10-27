namespace GameArchipelago.Logic.Games.PixelRace
{
    public class Player
    {
        private int _x;
        private int _y;
        public int X => _x;
        public int Y => _y;

        public Player(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void MovePlayerLeft(int offSet)
            => _x = _x -= offSet;
        public void MovePlayerRight(int offSet)
            => _x = _x += offSet;
    }
}
