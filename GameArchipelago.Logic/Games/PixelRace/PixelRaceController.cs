namespace GameArchipelago.Logic.Games.PixelRace
{
    public class PixelRaceController
    {
        public readonly Random Rnd = new();
        private Player _player;
        public Player Player => _player;
        private int _baseGameSpeed = 20;
        private int _gameSpeed;
        public int GameSpeed => _gameSpeed;
        private int _score = 0;
        public int Score => _score;

        public PixelRaceController()
        {
            _player = new Player(378, 553);
            _gameSpeed = _baseGameSpeed;
        }

        public void MovePlayerRight()
        {
            if(_player.X <= 378)
                _player.MovePlayerRight(114);
        }

        public void MovePlayerLeft()
        {
            if( _player.X >= 378)
                _player.MovePlayerLeft(114);
        }

        public void Reset()
        {
            _player = new Player(378, 553);
            _gameSpeed = _baseGameSpeed;
            _score = 0;
        }

        public void RiseScore(int amount)
            => _score += amount;

        public void RiseSpeed(int amount)
            => _gameSpeed += amount;
    }
}
