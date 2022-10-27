namespace GameArchipelago.Logic.Games.PixelRace
{
    public class Enemy
    {
        private int _x;
        private int _y;
        public int X => _x;
        public int Y => _y;

        public void Move(int speed)
            => _y += speed;
    }
}
