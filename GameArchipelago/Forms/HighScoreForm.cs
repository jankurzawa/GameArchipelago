namespace GameArchipelago.Forms
{
    public partial class HighScoreForm : Form
    {
        private readonly HighscoreController _highscoreController;
        private readonly int _score;

        public HighScoreForm(HighscoreController highscoreController, int score)
        {
            _highscoreController = highscoreController;
            _score = score;
            InitializeComponent();
        }

        private void buttonSaveHighScore_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNick.Text))
                MessageBox.Show("Nickname cannot be empty!", "Error");
            else {
                var highScore = _highscoreController.GetNewHighscore(textBoxNick.Text, _score);
                _highscoreController.SaveHighscore(highScore);
                Close(); }
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " +_score.ToString();
            ActiveControl = textBoxNick;
        }
    }
}