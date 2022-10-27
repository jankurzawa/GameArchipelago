namespace GameArchipelago.Forms
{
    public partial class GuessTheNumberForm : Form
    {
        private Random randomNumber;
        private int _numberToGuess = 0;
        private int _guess = 0;
        private List<Func<int, int, bool>> functions;

        public GuessTheNumberForm(Random random)
        {
            randomNumber = random;
            InitializeComponent();
            RandomizeAnswer();
            functions = new List<Func<int, int, bool>>();
            AddingMethodsToList();
        }

        private void AddingMethodsToList()
        {
            functions.Add(CheckingInputNumberIfItIsLowerThanNumberToGuess);
            functions.Add(CheckingInputNumberIfItIsBiggerThanNumberToGuess);
            functions.Add(CheckingInputNumberIfItIsEqualThanNumberToGuess);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correctInput = int.TryParse(InputNumberBox.Text, out int resultInput);
            CheckingResult(resultInput, correctInput);
        }

        private void CheckingResult(int resultInput, bool correctInput)
        {
            if (correctInput)
            {
                _guess++;
                TimesLabel.Text = $"You have guessed in {_guess} times";
                foreach (var func in from Func<int, int, Boolean> func in functions
                                     where func(resultInput, _numberToGuess) == true
                                     select func)
                {
                    if (InputNumberBox.Text != string.Empty)
                        func.Invoke(resultInput, _numberToGuess);
                }
            }
            else
                MessageBox.Show("Are you sure you inserted a number? :)");
        }

        private void RemoveTextFromInputNumberBox()
            => InputNumberBox.Text = "";

        private void RandomizeAnswer()
            => _numberToGuess = randomNumber.Next(0, 101);

        private bool CheckingInputNumberIfItIsLowerThanNumberToGuess(int resultInput, int _numberToGuess)
        {
            if (resultInput < _numberToGuess)
            {
                MessageBox.Show("Your number is lower than mine ");
                RemoveTextFromInputNumberBox();
                return true;
            }
            return false;
        }

        private bool CheckingInputNumberIfItIsBiggerThanNumberToGuess(int resultInput, int _numberToGuess)
        {
            if (resultInput > _numberToGuess)
            {
                MessageBox.Show("Your number is bigger than mine");
                RemoveTextFromInputNumberBox();
                return true;
            }
            return false;
        }

        private bool CheckingInputNumberIfItIsEqualThanNumberToGuess(int resultInput, int _numberToGuess)
        {
            if (resultInput == _numberToGuess)
            {
                MessageBox.Show("Congratulations, you won");
                RemoveTextFromInputNumberBox();
                ResetResultLabelAfterWinningMatch();
                RandomizeAnswer();
                return true;
            }
            return false;
        }

        private void ResetResultLabelAfterWinningMatch()
        {
            _guess = 0;
            TimesLabel.Text = $"You have guessed in {_guess} times";
        }
    }
}
