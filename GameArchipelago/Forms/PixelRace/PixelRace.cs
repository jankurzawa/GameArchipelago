namespace GameArchipelago.Forms.PixelRace
{
    public partial class PixelRace : Form
    {
        private readonly PixelRaceController _pixelRaceController;
        private readonly HighscoreController _highscoreController;
            
        public PixelRace( PixelRaceController controller, HighscoreController highscoreController)
        {
            _pixelRaceController = controller;
            _highscoreController = highscoreController;
            InitializeComponent();     
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                lblRight.BackColor = Color.Green;
                _pixelRaceController.MovePlayerRight();
            }

            if (e.KeyCode == Keys.Left) 
            {
                lblLeft.BackColor = Color.Green;
                _pixelRaceController.MovePlayerLeft();
            }
        }

        private void GameEvents(object sender, EventArgs e)
        {
            labelScoreValue.Text = "Score: " + _pixelRaceController.Score.ToString();
            pictureBoxPlayer.Location = new Point(_pixelRaceController.Player.X, _pixelRaceController.Player.Y);
            HandleEnemyMovement();
            CheckForCollision();
        }

        private void spawnEnemyEvent(object sender, EventArgs e)
        {
            SpawnEnemies();
            _pixelRaceController.RiseScore(100);
        }

        private void SpawnEnemies()
        {
            int spawnPatern = _pixelRaceController.Rnd.Next(1, 7);

            switch (spawnPatern)
            {
                case 1:
                    SpawnEnemy(264);
                    break;
                case 2:
                    SpawnEnemy(378);
                    break;
                case 3:
                    SpawnEnemy(492);
                    break;
                case 4:
                    SpawnEnemy(264);
                    SpawnEnemy(378);
                    break;
                case 5:
                    SpawnEnemy(378);
                    SpawnEnemy(492);
                    break;
                case 6:
                    SpawnEnemy(264);
                    SpawnEnemy(492);
                    break;
            }              
        }

        private void HandleEnemyMovement()
        {
            foreach(Control c in Controls)
            {
                if ((string)c.Tag == "enemy") {
                    c.Top += _pixelRaceController.GameSpeed;
                    HandleOutOfBounds(c); }              
            }
        }

        private void HandleOutOfBounds(Control control)
        {
            if (control.Location.Y > 650)
                Controls.Remove(control);
        }

        private void SpawnEnemy(int x)
        {
            var picure = new PictureBox {
                Name = "pictureBox",
                Size = new Size(67, 60),
                Location = new Point(x, 12),
                Image = Properties.Resources.Enemy,
                Tag = "enemy",
                SizeMode = PictureBoxSizeMode.Zoom 
            };
            Controls.Add(picure);
        }

        private void CheckForCollision()
        {
            foreach (Control c in Controls)
            {
                if ((string)c.Tag == "enemy") {
                    if (c.Bounds.IntersectsWith(pictureBoxPlayer.Bounds))
                        GameOver(); }
            }
        }

        private void ClearEnemies()
        {
            foreach (Control c in Controls)
                if ((string)c.Tag == "enemy")
                    Controls.Remove(c);
        }

        private void GameOver()
        {
            timer.Stop();
            timerEnemy.Stop();
            timerGameDiff.Stop();
            labelGameOver.Visible = true;
            HandleScore();
        }

        private void HandleScore()
            => new HighScoreForm(_highscoreController, _pixelRaceController.Score).Show();

        private void StartGame()
        {
            ClearEnemies();
            labelGameOver.Visible = false;
            _pixelRaceController.Reset();
            timer.Interval = 100;
            timerEnemy.Interval = 1500;
            timer.Start();
            timerEnemy.Start();
            timerGameDiff.Start();
            SpawnEnemies();
        }

        private void gameDiffEvent(object sender, EventArgs e)
        {
            timer.Interval -= timer.Interval / 4;
            timerEnemy.Interval -= timerEnemy.Interval / 4;
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            lblLeft.BackColor = Color.Azure;
            lblRight.BackColor = Color.Azure;
        }

        private void labelStart_Click(object sender, EventArgs e) 
            => StartGame();
        private void labelExit_Click(object sender, EventArgs e) 
            => Close(); 
    }
}
