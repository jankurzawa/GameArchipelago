namespace GameArchipelago.Forms
{
    public partial class TicTacToeForm : Form
    {
        private TicTacToeHandler _ticTacToeHandler;
        private string _symbol = "X";
        private bool _stopPlay;
        private int _signCounter;

        private Dictionary<string, Color> _colors = new()
        {
            { "X", Color.Cyan },
            { "O", Color.Red }
        };

        public TicTacToeForm(TicTacToeHandler ticTacToeHandler)
        {
            _ticTacToeHandler = ticTacToeHandler;
            InitializeComponent();
            ActiveControl = lblActivePlayer;           
        }

        private void ToggleSymbol()
        {
            if (_symbol == "X") _symbol = "O";    
            else _symbol = "X";
            lblActivePlayer.Text = $"Player {_symbol}\n to move";
        }

        private void SignButton(object sender, EventArgs e)
        {
            if (_stopPlay)
                return;

            Button selectedButton = sender as Button;
            if (string.IsNullOrEmpty(selectedButton.Text)) {
                _signCounter++;
                ChangeSignToAdd(selectedButton);
                ToggleSymbol();
                bool isWinner = CheckWin();

                if (isWinner)
                    WinMatch(selectedButton);
                else if (!isWinner && _signCounter == 9)
                    TieMatch();
            }
        }
        private void TieMatch()
        {
            MessageBox.Show("It's a tie!", "Tic Tac Toe!");
            _stopPlay = true;
            Clear();
            _signCounter = 0;
            _stopPlay = false;
        }

        private void WinMatch(Button selectedButton)
        {
            MessageBox.Show($"Player {selectedButton.Text} has won!", "Tic Tac Toe!");
            _stopPlay = true;
            Clear();
            _signCounter = 0;
            _stopPlay = false;
        }

        private void ChangeSignToAdd(Button selectedButton)
        {
            selectedButton.Text = _symbol;
            selectedButton.BackColor = (_colors[_symbol]);
        }

        private bool CheckWin()
        {
            string[,] gamePlatform = CreatingArray();
            if (_ticTacToeHandler.CheckingWinnerVertical(gamePlatform) || _ticTacToeHandler.CheckingRightDiagonal(gamePlatform) ||
                _ticTacToeHandler.CheckingWinnerHorizontal(gamePlatform) || _ticTacToeHandler.CheckingLeftDiagonal(gamePlatform))
            { return true;}
            return false;
        }

        private string[,] CreatingArray()
        {
            return new string[,] {
               { Square1.Text, Square2.Text, Square3.Text },
               { Square4.Text, Square5.Text, Square6.Text },
               { Square7.Text, Square8.Text, Square9.Text }};
        }

        private void Clear()
        {
            Button[] tab = new Button[] {
               Square1, Square2, Square3, 
                Square4, Square5, Square6 ,
                Square7, Square8, Square9 };
            tab.ToList().ForEach(x => {
                x.Text = string.Empty;
                x.BackColor = Color.White;
            });
        }
    }
}
