namespace GameArchipelago.Logic.Games.Tetris
{
    public class TetrisHandler
    {
        public const int MaxWidth = 17;
        public const int MaxHeight = 20;
        public List<Coordinates> falledShapes { get; private set; }
        public Shape fallingShape { get; private set; }
        public int Score { get; private set; }

        public TetrisHandler() 
            => SetupGame();

        public bool IfLose()
        {
            if (falledShapes.Where(s => s.Y < 5).FirstOrDefault() != null) return true;
            else return false;
        }
        public void SetupGame()
        {
            falledShapes = new();
            fallingShape = new Shape();
            Score = 0;
        }
        public void MakeMove(string direction)
        {
            if (direction == "up") TurnShape();
            else if (IsMoveIsPossible(direction))
            {
                switch (direction)
                {
                    case "left":
                        fallingShape.elements.ForEach(e => e.X -= 1);
                        break;
                    case "right":
                        fallingShape.elements.ForEach(e => e.X += 1);
                        break;
                    case "down":
                        fallingShape.elements.ForEach(e => e.Y += 1);
                        break;
                }
            }
        }
        private void TurnShape()
        {
            (int, int) referencePoint = (fallingShape.elements.First().X, fallingShape.elements.First().Y);
            for (int i = 1; i < fallingShape.elements.Count; i++)
            {
                int differenceX = Math.Abs(fallingShape.elements[i].X - referencePoint.Item1);
                int differenceY = Math.Abs(fallingShape.elements[i].Y - referencePoint.Item2);

                fallingShape.elements[i].X = referencePoint.Item1 + differenceY;
                fallingShape.elements[i].Y = referencePoint.Item2 + differenceX;
            }
        }
        private bool IsMoveIsPossible(string direction)
        {
            if (direction == "left" || direction == "right") return AreSidesBlock(direction);
            else if (AreGroundOrFalledShapesBlock())
            {
                PutTheShape();
                RemoveStackedRows();
                fallingShape = new Shape();
                return false;
            }
            return true;
        }
        private void RemoveStackedRows()
        {
            for (int i = MaxHeight*2; i >= 0; i--)
            {
                if (falledShapes.Where(s => s.Y == i).Count() > MaxWidth)
                {
                    falledShapes.Where(s => s.Y == i).ToList().ForEach(x => falledShapes.Remove(x));
                    falledShapes.Where(s => s.Y < i).ToList().ForEach(x => x.Y++);
                    Score += 10;
                }
            }
        }
        private void PutTheShape() 
            => fallingShape.elements.ForEach(e => falledShapes.Add(e));
        private bool AreGroundOrFalledShapesBlock()
        {
            foreach (var element in fallingShape.elements)
            {
                if (element.Y-1 > MaxHeight) return true;
                foreach (var falledShape in falledShapes)
                {
                    if (element.X == falledShape.X)
                        if (element.Y+1 == falledShape.Y) return true;
                }
            }
            return false;
        }
        private bool AreSidesBlock(string direction)
        {
            int directionToCheck;
            if (direction == "left") directionToCheck = -1;
            else if (direction == "right") directionToCheck = 1;
            else throw new ArgumentOutOfRangeException();
            foreach (var element in fallingShape.elements)
            {
                if (element.X + directionToCheck < 0 || element.X + directionToCheck > MaxWidth) return false;
            }
            return true;
        }
    }
}
