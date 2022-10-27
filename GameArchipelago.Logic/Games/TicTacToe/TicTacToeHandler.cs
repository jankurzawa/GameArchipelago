namespace GameArchipelago.Logic.Games.TicTacToe
{
    public class TicTacToeHandler
    {
        public bool CheckingRightDiagonal(string[,] tab)
        {
            int countforP1 = 0; 
            int countforP2 = 0;
            int winningSequence = 3;

            for (int i = 0, j = 0; i <= tab.GetUpperBound(0) && j <= tab.GetUpperBound(1); i++, j++) {
                if (i == j && tab[j, i] == "X") countforP1++;
                if (i == j && tab[j, i] == "O") countforP2++;
                if (countforP1 == winningSequence || countforP2 == winningSequence) return true; 
            }        
            return false;
        }

        public bool CheckingLeftDiagonal(string[,] tab)
        {
            int countforP1 = 0;
            int countforP2 = 0;
            int winningSequence = 3;

            for (int i = 2, j = 0; i <= tab.GetUpperBound(0) && j <= tab.GetUpperBound(1); i--, j++) {
                if (i + j == 2 && tab[i, j] == "X") countforP1 += 1;
                if (i + j == 2 && tab[i, j] == "O") countforP2 += 1;
                if (countforP1 == winningSequence || countforP2 == winningSequence) return true;
            }
            return false;
        }

        public bool CheckingWinnerVertical(string[,] tab)
        {
            for (int i = 0; i < tab.GetUpperBound(0) + 1; i++)
                if (tab[0, i] == tab[1, i] && tab[1, i] == tab[2, i] && tab[0, i] != string.Empty)
                    return true;

            return false;
        }

        public bool CheckingWinnerHorizontal(string[,] tab)
        {
            for (int i = 0; i < tab.GetUpperBound(0) + 1; i++)
                if (tab[i, 0] == tab[i, 1] && tab[i, 1] == tab[i, 2] && tab[i, 0] != string.Empty)
                    return true;

            return false;
        }
    }
}
