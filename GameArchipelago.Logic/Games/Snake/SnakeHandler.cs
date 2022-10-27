namespace GameArchipelago.Logic.Games.Snake
{
    public class SnakeHandler
    {
        private readonly Random _random;
        public const int MaxWidth = 20;
        public const int MaxHeight = 20;
        public List<Coordinates> Snake { get; private set; }
        public Coordinates Food { get; private set; }
        public string Direction { get; set; }
        public int Score { get; private set; }

        public SnakeHandler()
        {
            _random = new();
            Snake = new();
            SetUpGame();
        }

        public void SetUpGame()
        {
            SetUpSnake();
            Score = 0;
            Direction = "left";
            SetFood();
        }

        public void MoveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (Direction == "left") Snake[i].X--;
                    else if (Direction == "right") Snake[i].X++;
                    else if (Direction == "down") Snake[i].Y++;
                    else Snake[i].Y--;
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        public void EatFood()
        {
            Score++;
            Snake.Add(new Coordinates(Snake[^1].X, Snake[^1].Y));
        }

        public bool IfHitYourself()
        {
            for (int j = 1; j < Snake.Count; j++)
                if (Snake[0].X == Snake[j].X && Snake[0].Y == Snake[j].Y) return true;
            return false;
        }

        public bool IsOutOfBorder()
        {
            if (Snake[0].X < 0 || Snake[0].X >= MaxWidth || Snake[0].Y < 0 || Snake[0].Y >= MaxHeight) return true;
            return false;
        }

        private void SetUpSnake()
        {
            Snake = new();
            Snake.Add(new Coordinates());
            for (int i = 0; i < 9; i++)
                Snake.Add(new Coordinates());
        }

        public void SetFood() 
            => Food = new Coordinates(_random.Next(0, MaxWidth), _random.Next(0, MaxHeight));
    }
}
