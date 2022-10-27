namespace GameArchipelago.Forms.Tetris
{
    public partial class TetrisForm : Form
    {
        private readonly HighscoreController _highscoreController;
        private TetrisHandler tetrisHandler;
        public TetrisForm(HighscoreController highscoreController)
        {
            _highscoreController = highscoreController;
            tetrisHandler = new();
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            tetrisTimer.Start();
            tetrisHandler.SetupGame();
            btnStart.Enabled = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            tetrisHandler.MakeMove("down");
            if (tetrisHandler.IfLose()) GameOver();
            lblScore.Text = tetrisHandler.Score.ToString();
            pbBoard.Invalidate();
        }
        private void GameOver()
        {
            tetrisTimer.Stop();
            HandleHighscore();
            lblGameOver.Visible = true;
            btnStart.Enabled = true;
        }
        private void HandleHighscore()
            => new HighScoreForm(_highscoreController, tetrisHandler.Score).Show();
        private void UpdateBoard(object sender, PaintEventArgs e)
        {
            Graphics board = e.Graphics;
            foreach(var element in tetrisHandler.fallingShape.elements)
            {
                board.FillRectangle(Brushes.Red, new Rectangle
                        (element.X * TetrisHandler.MaxWidth,
                        element.Y * TetrisHandler.MaxHeight,
                        TetrisHandler.MaxWidth,
                        TetrisHandler.MaxHeight
                        ));
            }
            foreach (var element in tetrisHandler.falledShapes)
            {
                board.FillRectangle(Brushes.Red, new Rectangle
                    (element.X * TetrisHandler.MaxWidth,
                    element.Y * TetrisHandler.MaxHeight,
                    TetrisHandler.MaxWidth,
                    TetrisHandler.MaxHeight
                    ));
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) tetrisHandler.MakeMove("left");
            else if (e.KeyCode == Keys.Right) tetrisHandler.MakeMove("right");
            else if (e.KeyCode == Keys.Up) tetrisHandler.MakeMove("up");
            else if (e.KeyCode == Keys.Down) tetrisHandler.MakeMove("down");
        }
    }
}
