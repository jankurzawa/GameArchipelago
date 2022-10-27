namespace GameArchipelago
{
    public partial class Main : Form
    {
        private const int AmountOfRecords = 10;
        public Action StartGame;
        public Main()
        {
            HandleLoadingForm();
            InitializeComponent();
            pictureBoxGif.Image = null;
        }

        private void buttonGame1_MouseEnter(object sender, EventArgs e) 
            => buttonGame1.BackColor = Color.Turquoise;
        private void buttonGame1_MouseLeave(object sender, EventArgs e) 
            => buttonGame1.BackColor = Color.SteelBlue;
        private void buttonGame2_MouseEnter(object sender, EventArgs e) 
            => buttonGame2.BackColor = Color.Tomato;
        private void buttonGame2_MouseLeave(object sender, EventArgs e) 
            => buttonGame2.BackColor = Color.SteelBlue;
        private void buttonGame3_MouseEnter(object sender, EventArgs e) 
            => buttonGame3.BackColor = Color.Crimson;
        private void buttonGame3_MouseLeave(object sender, EventArgs e) 
            => buttonGame3.BackColor = Color.SteelBlue;
        private void buttonGame4_MouseEnter(object sender, EventArgs e) 
            => buttonGame4.BackColor = Color.DarkGreen;
        private void buttonGame4_MouseLeave(object sender, EventArgs e) 
            => buttonGame4.BackColor = Color.SteelBlue;
        private void buttonGame5_MouseEnter(object sender, EventArgs e) 
            => buttonGame5.BackColor = Color.Orange;
        private void buttonGame5_MouseLeave(object sender, EventArgs e) 
            => buttonGame5.BackColor = Color.SteelBlue;
        private void buttonGame6_MouseEnter(object sender, EventArgs e) 
            => buttonGame6.BackColor = Color.RosyBrown;
        private void buttonGame6_MouseLeave(object sender, EventArgs e) 
            => buttonGame6.BackColor = Color.SteelBlue;
        private void buttonGame7_MouseEnter(object sender, EventArgs e) 
            => buttonGame7.BackColor = Color.Gold;
        private void buttonGame7_MouseLeave(object sender, EventArgs e) 
            => buttonGame7.BackColor = Color.SteelBlue;
        private void buttonGame8_MouseEnter(object sender, EventArgs e) 
            => buttonGame8.BackColor = Color.DarkGray;
        private void buttonGame8_MouseLeave(object sender, EventArgs e) 
            => buttonGame8.BackColor = Color.SteelBlue;
        private void iconButtonStartGame_Click(object sender, EventArgs e) 
            => StartGame?.Invoke();
        private void LoadingFrom_FormClosing(object? sender, FormClosingEventArgs e) 
            => Show();
        private void Game_FormClosing(object? sender, FormClosingEventArgs e) 
            => Show();
        private void StartWordle() 
            => ShowProperForm(new Wordle(new WordleHandler(), new HighscoreController(new Serializer<Highscore>(FileName.Wordle)), new Stopwatch()));
        private void StartTicTackToe() 
            => ShowProperForm(new TicTacToeForm(new TicTacToeHandler()));
        private void StartGuessNumber() 
            => ShowProperForm(new GuessTheNumberForm(new Random()));
        private void StartSnake() 
            => ShowProperForm(new SnakeForm(new SnakeHandler(), new HighscoreController(new Serializer<Highscore>(FileName.Snake))));
        private void StartPaperScissors() 
            => ShowProperForm(new StonePaperScissors(new StonePaperScissorsHandler()));
        private void StartDino() 
            => ShowProperForm(new DinoGame(new DinoController(), new HighscoreController(new Serializer<Highscore>(FileName.Dino))));
        private void StartPixelRace() 
            => ShowProperForm(new PixelRace(new PixelRaceController(), new HighscoreController(new Serializer<Highscore>(FileName.PixelRace))));
        private void StartTetris() 
            => ShowProperForm(new TetrisForm(new HighscoreController(new Serializer<Highscore>(FileName.Tetris))));
        private void buttonGame1_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame1.Text;
            panelSelectedGame.BackColor = Color.Turquoise;
            StartGame = null;
            StartGame += StartWordle;
            pictureBoxGif.Image = Properties.Resources.WordieGif;
            lbHighscore.DataSource = HighscoreController.GetData(FileName.Wordle, AmountOfRecords);
            SetHighscoresVisibility();
        }
        private void buttonGame2_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame2.Text;
            panelSelectedGame.BackColor = Color.Tomato;
            StartGame = null;
            StartGame += StartTicTackToe;
            pictureBoxGif.Image = Properties.Resources.TikTakGif;
            SetHighscoresVisibility(false);
        }
        private void buttonGame3_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame3.Text;
            panelSelectedGame.BackColor = Color.Crimson;
            StartGame = null;
            StartGame += StartGuessNumber;
            pictureBoxGif.Image = Properties.Resources.guessNumberGif;
            SetHighscoresVisibility(false);
        }
        private void buttonGame4_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame4.Text;
            panelSelectedGame.BackColor = Color.DarkGreen;
            StartGame = null;
            StartGame += StartSnake;
            pictureBoxGif.Image = Properties.Resources.ezgif_com_gif_maker__5_;
            lbHighscore.DataSource = HighscoreController.GetData(FileName.Snake, AmountOfRecords);
            SetHighscoresVisibility();
        }
        private void buttonGame5_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame5.Text;
            panelSelectedGame.BackColor = Color.Orange;
            StartGame = null;
            StartGame += StartPaperScissors;
            pictureBoxGif.Image = Properties.Resources.RockPaperGif;
            SetHighscoresVisibility(false);
        }
        private void buttonGame6_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame6.Text;
            panelSelectedGame.BackColor = Color.RosyBrown;
            StartGame = null;
            StartGame += StartDino;
            pictureBoxGif.Image = Properties.Resources.DinoGif;
            lbHighscore.DataSource = HighscoreController.GetData(FileName.Dino, AmountOfRecords);
            SetHighscoresVisibility();
        }
        private void buttonGame7_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame7.Text;
            panelSelectedGame.BackColor = Color.Gold;
            StartGame = null;
            StartGame += StartPixelRace;
            pictureBoxGif.Image = Properties.Resources.pixelRacingGif;
            lbHighscore.DataSource = HighscoreController.GetData(FileName.PixelRace, AmountOfRecords);
            SetHighscoresVisibility();
        }
        private void buttonGame8_Click(object sender, EventArgs e)
        {
            labelGameTitle.Text = buttonGame8.Text;
            panelSelectedGame.BackColor = Color.DarkGray;
            StartGame = null;
            StartGame += StartTetris;
            pictureBoxGif.Image = Properties.Resources.Tetris;
            lbHighscore.DataSource = HighscoreController.GetData(FileName.PixelRace, AmountOfRecords);
            SetHighscoresVisibility();
        }
        private void HandleLoadingForm()
        {
            Hide();
            var loadingFrom = new LoadingForm();
            loadingFrom.FormClosing += LoadingFrom_FormClosing;
            loadingFrom.ShowDialog();
        }
        private void ShowProperForm(Form game)
        {
            Hide();
            game.FormClosing += Game_FormClosing;
            game.ShowDialog();
        }
        private void SetHighscoresVisibility(bool isVisible = true)
        {
            lbHighscore.Visible = isVisible;
            lblHighscores.Visible = isVisible;
        }
    }
}
