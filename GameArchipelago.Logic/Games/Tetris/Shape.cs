namespace GameArchipelago.Logic.Games.Tetris
{
    public class Shape
    {
        public List<Coordinates> elements { get; private set; }
        private Random random;
        public Shape()
        {
            random = new();
            SetNewShape();
        }

        private void SetNewShape()
        {
            elements = new List<Coordinates>() { new Coordinates() };
            int typeOfElement = random.Next(1, 5);

            switch (typeOfElement)
            {
                case 1: // kwadrat
                    elements.Add(new Coordinates(elements.First().X+1, elements.First().Y));
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y+1));
                    elements.Add(new Coordinates(elements.First().X+1, elements.First().Y+1));
                    break;
                case 2: //linia
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y + 1));
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y + 2));
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y + 3));
                    break;
                case 3://z
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y - 1));
                    elements.Add(new Coordinates(elements.First().X + 1, elements.First().Y - 1));
                    elements.Add(new Coordinates(elements.First().X + 1, elements.First().Y - 2));
                    break;
                case 4: //L
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y - 1));
                    elements.Add(new Coordinates(elements.First().X, elements.First().Y - 2));
                    elements.Add(new Coordinates(elements.First().X + 1, elements.First().Y - 2));
                    break;
            }
        }
    }
}
