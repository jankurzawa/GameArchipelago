namespace GameArchipelago.Forms
{
    public partial class Wordle : Form
    {
        private const string ButtonPrefix = "btn";
        private readonly HighscoreController _highscoreController;

        private Stopwatch _timer;
        private List<Button> _clickedButtons;
        private WordleHandler _wordleHandler;
        private int _counter, _remainingTurns = 5;

        public Wordle(WordleHandler wordleHandler, HighscoreController highscoreController, Stopwatch timer)
        {
            _clickedButtons = new();
            _wordleHandler = wordleHandler;
            _highscoreController = highscoreController;
            _timer = timer;
            InitializeComponent();
            lbTurnsAmount.Text = _remainingTurns.ToString();
            ActiveControl = btnReturn;
            timer.Start();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            if (_clickedButtons.Count == _wordleHandler.WordToGuess.Length)
                return;

            var button = (Button)sender;
            plInput.Controls[_counter++].Text = button.Tag.ToString();
            _clickedButtons.Add(button);

            if (_clickedButtons.Count == _wordleHandler.WordToGuess.Length)
                btnReturn.Enabled = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (_clickedButtons.Any())
            {
                plInput.Controls[--_counter].Text = String.Empty;
                _clickedButtons.Remove(_clickedButtons.Last());
                btnReturn.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetGameStateAfterTurn();
            HandleResult();
            DeacreaseRemainingTurnsAmount();
            ResetViewForNextTurn();
        }

        private void SetGameStateAfterTurn()
        {
            for (int i = 0; i < plInput.Controls.Count; i++)
            {
                var charCount = _wordleHandler.CountSameCharsInWord(plInput.Controls[i].Text);
                var isMatch = _wordleHandler.IsMatch(plInput.Controls[i].Text, i);

                if (isMatch)
                {
                    plWord.Controls[i].Text = _wordleHandler.WordToGuess[i].ToString();
                    plWord.Controls[i].BackColor = Color.Green;
                    _clickedButtons[i].BackColor = charCount == 1 ? Color.Green : Color.Orange;;
                }
                else if (!isMatch && charCount != 0)
                    _clickedButtons[i].BackColor = Color.Orange;
                else
                    _clickedButtons[i].BackColor = Color.Red;
            }
        }

        private void DeacreaseRemainingTurnsAmount()
            => lbTurnsAmount.Text = (--_remainingTurns).ToString();

        private void HandleResult()
        {
            var guessedWord = new StringBuilder();
            foreach (Label label in plWord.Controls)
                guessedWord.Append(label.Text);

            if (_wordleHandler.IsMatch(guessedWord.ToString()) && _remainingTurns > 0) {
                _timer.Stop();
                var gameTime = (int)_timer.Elapsed.TotalSeconds;
                var highscoreForm = new HighScoreForm(_highscoreController, _wordleHandler.CalculateScore(_remainingTurns, gameTime));
                highscoreForm.Show(); }

            if (_remainingTurns == 0) {
                MessageBox.Show($"You loose! The word was: {_wordleHandler.WordToGuess}.", $"{_wordleHandler.WordToGuess}");
                Close(); }
        }

        private void ResetViewForNextTurn()
        {
            _counter = 0;
            ActiveControl = btnReturn;
            btnReturn.Enabled = false;
            _clickedButtons.Clear();
            foreach (Label label in plInput.Controls)
                label.Text = string.Empty;
        }

        private void Wordle_KeyUp(object sender, KeyEventArgs e)
            => (Controls.Find(ButtonPrefix + e.KeyData.ToString(), searchAllChildren: true).FirstOrDefault() as Button)?.PerformClick();
    }
}
