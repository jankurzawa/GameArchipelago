namespace GameArchipelago.Logic.Games.Dino
{
    public class DinoController
    {
        private Random _rnd = new();
        private int _fallSpeed = 20;
        private int _jumpSpeed = 20;
        private int _baseGravityForce = 10;
        private int _gravityForce = 10;   
        private int _baseObstacleSpeed = 10;
        private int _obstacleSpeed = 10;
        private int _score = 0;
        private bool _isJumping = false;
        private bool _isFalling = false;
        public bool IsFalling => _isFalling;
        public int Score => _score;

        public int HandleJumping(int playerTop, int floorTop, int playerHeight)
        {
            if(_isJumping && _gravityForce < 0) {
                _isJumping = false;
                _isFalling = true; }
                
            if (_isJumping)
                playerTop = HandleJump(playerTop);    
            if (!_isJumping)
                playerTop = HandleFallingDown(playerTop, playerHeight, floorTop);

            return playerTop;
        }

        public void EndJumping()
        {
            if (_isJumping) {
                _isJumping = false;
                _isFalling = true; }        
        }

        public void StartJumping()
        {
            if (!_isJumping)
                _isJumping = true;
        }

        public int HandleObstacle(int obstacleLeft)
        {
            var outcome = obstacleLeft - _obstacleSpeed;

            if(outcome < 0) {
                var offstet = _rnd.Next(600, 1000);
                outcome = offstet;
                HandleGameDifficulty(2);
                RiseScore();
            }
            return outcome;
        }

        public int HandleObstacleCollision(int obstacleLeft)
            => obstacleLeft + _rnd.Next(100, 300);

        public int OffsetObstacleByValue(int obstacleLeft, int offset)
            => obstacleLeft + offset;

        public void Reset() 
        {
            _gravityForce = _baseGravityForce;
            _obstacleSpeed = _baseObstacleSpeed;
            _score = 0;
        }

        public void HandleGameDifficulty(int speedBoost)
        {
            if(Score % 1000 == 0 && Score > 0)
                _obstacleSpeed += speedBoost;
        }

        private int HandleJump(int playerTop)
        {
            _gravityForce--;
            var output = playerTop - _jumpSpeed;
            return output;
        }

        private int HandleFallingDown(int playerTop, int playerHeight, int floorTop)
        {
            int outcome;
            if (playerTop >= 370) {
                _gravityForce = _baseGravityForce;
                _isFalling = false;
                outcome = floorTop - playerHeight; }
            else outcome = playerTop + _fallSpeed;

            return outcome;
        }

        private void RiseScore() 
            => _score += 100;

        public int ResetObstaclePosition() 
            => _rnd.Next(370, 530);
    }
}
