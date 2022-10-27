namespace GameArchipelago.Forms
{
    public partial class StonePaperScissors : Form
    {
        private readonly StonePaperScissorsHandler _stonePaperScissorsHandler;

        public StonePaperScissors(StonePaperScissorsHandler stonePaperScissorsHandler)
        {
            _stonePaperScissorsHandler = stonePaperScissorsHandler;
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e) 
            => MakeMove("Rock");
        private void btnPaper_Click(object sender, EventArgs e) 
            => MakeMove("Paper");
        private void btnScissors_Click(object sender, EventArgs e) 
            => MakeMove("Scissors");

        private void MakeMove(string playersMove)
        {
            string randomizedMove = _stonePaperScissorsHandler.RandomMove();
            pbOpponentsChoose.Visible = true;
            if (randomizedMove == "Rock") pbOpponentsChoose.Image = Properties.Resources.Rock;
            else if (randomizedMove == "Paper") pbOpponentsChoose.Image = Properties.Resources.Paper;
            else if (randomizedMove == "Scissors") pbOpponentsChoose.Image = Properties.Resources.Scissors;
            lblResultOfMove.Text = _stonePaperScissorsHandler.GetResult(randomizedMove, playersMove);
        }
    }
}
