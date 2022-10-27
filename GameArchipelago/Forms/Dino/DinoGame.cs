namespace GameArchipelago.Forms.Dino
{
    public partial class DinoGame : Form
    {
        private readonly HighscoreController _highscoreController;
        private readonly DinoController _dinoController;

        public DinoGame(DinoController dinoController, HighscoreController highscoreController)
        {
            _dinoController = dinoController;
            _highscoreController = highscoreController;
            InitializeComponent();
            DisplayMenu();
        }

        private void gameEvent(object sender, EventArgs e)
        {
            scoreText.Text = $"Score: {_dinoController.Score}";
            trex.Top =  _dinoController.HandleJumping(trex.Top, floor.Top, trex.Height);

            foreach (Control c in Controls)
                HandleIfObstacleCollision(c);
            foreach (Control c in Controls)
                HandleIfWrongObstaclePosition(c);
            foreach (Control c in Controls)
                HandleIfGameOver(c);
        }

        private void HandleIfGameOver(Control c)
        {
            if ((string)c.Tag == "obstacle" && c.Bounds.IntersectsWith(trex.Bounds)) {
                gameTimer.Stop();
                HandleHighscore();
                DisplayMenu();
            }
        }

        private void HandleHighscore()
            => new HighScoreForm(_highscoreController, _dinoController.Score).Show();

        private void HandleIfWrongObstaclePosition(Control c)
        {
            if (c is PictureBox && (string)c.Tag == "obstacle")
                if (CheckIfObstaclesAreToClose(c))
                    c.Left = _dinoController.OffsetObstacleByValue(c.Left, 300);
        }

        private void HandleIfObstacleCollision(Control c)
        {
            if (c is PictureBox && (string)c.Tag == "obstacle") {
                c.Left = _dinoController.HandleObstacle(c.Left);
                if (CheckForObstacleCollision(c))
                    c.Left = _dinoController.HandleObstacleCollision(c.Left); }
        }

        private bool CheckForObstacleCollision(Control c)
        {
            bool outcome = false;
            
            foreach (Control c2 in Controls) {
                if(c2 is PictureBox && (string)c2.Tag == "obstacle" && c.Name != c2.Name 
                    && c2.Bounds.IntersectsWith(c.Bounds))
                        outcome = true; }

            return outcome;
        }

        private bool CheckIfObstaclesAreToClose(Control c)
        {
            bool outcome = false;

            foreach (Control c2 in Controls) {
                if ((string)c2.Tag == "obstacle" && c.Name != c2.Name
                    && Math.Abs(c.Left - c2.Left) <= 130)
                    outcome = true;}

            return outcome;
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !_dinoController.IsFalling)
                _dinoController.StartJumping();
        }

        private void endGameLabel_Click(object sender, EventArgs e) 
            => Close();
        private void keyIsUp(object sender, KeyEventArgs e) 
            => _dinoController.EndJumping();

        private void DisplayMenu(bool isDisplay = true)
        {
            labelStartGame.Visible = isDisplay;
            labelStartGame.Enabled = isDisplay;
            endGameLabel.Visible = isDisplay;
            endGameLabel.Enabled = isDisplay;
            labelTitle.Visible = isDisplay;
            labelEdition.Visible = isDisplay;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DisplayMenu(isDisplay: false);
            ResetGame();
        }

        private void ResetGame()
        {
            foreach (Control c in Controls)
                if (c is PictureBox && (string)c.Tag == "obstacle")
                    c.Left = _dinoController.ResetObstaclePosition();

            _dinoController.Reset();
            gameTimer.Start();
        }
    }
}
