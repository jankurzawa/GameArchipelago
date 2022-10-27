namespace GameArchipelago.Forms.Snake
{
    public partial class SnakeForm : Form
    {
        private readonly HighscoreController _highscoreController;
        private readonly SnakeHandler _snakeHandler;

        public SnakeForm(SnakeHandler snakeHandler, HighscoreController highscoreController)
        {
            _snakeHandler = snakeHandler;
            _highscoreController = highscoreController;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            btnStart.Enabled = false;
            UpdateScore();
            _snakeHandler.SetUpGame();
            timer.Start();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && _snakeHandler.Direction != "right") _snakeHandler.Direction = "left";
            else if (e.KeyCode == Keys.Right && _snakeHandler.Direction != "left") _snakeHandler.Direction = "right";
            else if (e.KeyCode == Keys.Up && _snakeHandler.Direction != "down") _snakeHandler.Direction = "up";
            else if (e.KeyCode == Keys.Down && _snakeHandler.Direction != "up") _snakeHandler.Direction = "down";
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _snakeHandler.MoveSnake();
            if (_snakeHandler.IsOutOfBorder() || _snakeHandler.IfHitYourself()) GameOver();
            if (_snakeHandler.Snake[0].X == _snakeHandler.Food.X && _snakeHandler.Snake[0].Y == _snakeHandler.Food.Y) 
            {
                _snakeHandler.EatFood();
                _snakeHandler.SetFood(); 
            }
            UpdateScore();
            pbBoard.Invalidate();
        }

        private void UpdateBoard(object sender, PaintEventArgs e)
        {
            Graphics board = e.Graphics;
            Brush colourOfSnake;

            for (int i = 0; i < _snakeHandler.Snake.Count; i++)
            {
                if (i == 0) colourOfSnake = Brushes.DarkGray;
                else colourOfSnake = Brushes.DarkGreen;

                board.FillEllipse(colourOfSnake, new Rectangle(
                    _snakeHandler.Snake[i].X * SnakeHandler.MaxWidth,
                    _snakeHandler.Snake[i].Y * SnakeHandler.MaxHeight,
                    SnakeHandler.MaxWidth,
                    SnakeHandler.MaxHeight
                    ));
            }
            board.FillEllipse(Brushes.Red, new Rectangle(
                _snakeHandler.Food.X * SnakeHandler.MaxWidth, 
                _snakeHandler.Food.Y * SnakeHandler.MaxHeight, 
                SnakeHandler.MaxWidth, 
                SnakeHandler.MaxHeight
                ));
        }

        private void GameOver()
        {
            timer.Stop();
            HandleHighscore();
            lblGameOver.Visible = true;
            btnStart.Enabled = true;
        }

        private void HandleHighscore()
            => new HighScoreForm(_highscoreController, _snakeHandler.Score).Show();

        private void UpdateScore() 
            => lblresult.Text = _snakeHandler.Score.ToString();
    }
}
