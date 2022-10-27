namespace GameArchipelago.Tests
{
    public class TicTacToeTests
    {

        [Test, TestCaseSource(nameof(GetTestArraysForRightDiagonalChecking))]
        public void CheckingWinnerRightDiagonalReturnTrue(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingRightDiagonal(testArray);
            Assert.True(result);
        }

        public static IEnumerable<string[,]> GetTestArraysForRightDiagonalChecking
        {
            get
            {
                yield return new string[3, 3] { { "X", "O", "X" }, { "X", "X", "O" }, { "O", "O", "X" } };
            }
        }

        [Test, TestCaseSource(nameof(GetTestArraysForLeftDiagonalChecking))]
        public void CheckingWinnerLeftDiagonalReturnTrue(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingLeftDiagonal(testArray);
            Assert.True(result);
        }

        public static IEnumerable<string[,]> GetTestArraysForLeftDiagonalChecking
        {
            get
            {
                yield return new string[3, 3] { { "X", "O", "X" }, { "X", "X", "O" }, { "X", "O", "O" } };
            }
        }

        [Test, TestCaseSource(nameof(GetTestArraysForVerticalChecking))]
        public void CheckingWinnerHorizontalReturnTrue(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingWinnerVertical(testArray);
            Assert.True(result);
        }

        public static IEnumerable<string[,]> GetTestArraysForVerticalChecking
        {
            get
            {
                yield return new string[3, 3] { { "X", "O", "X" }, { "X", "X", "O" }, { "X", "O", "O" } };
                yield return new string[3, 3] { { "O", "O", "X" }, { "X", "O", "X" }, { "X", "O", "X" } };
                yield return new string[3, 3] { { "O", "X", "X" }, { "X", "X", "O" }, { "O", "X", "O" } };
            }
        }

        [Test, TestCaseSource(nameof(GetTestArraysForHorizontalChecking))]
        
        public void CheckingWinnerVerticalReturnTrue(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingWinnerHorizontal(testArray);
            Assert.True(result);
        }

        public static IEnumerable<string[,]> GetTestArraysForHorizontalChecking
        {
            get
            {
                yield return new string[3, 3] { { "X", "X", "X" }, { "O", "X", "O" }, { "X", "O", "O" } };
                yield return new string[3, 3] { { "X", "X", "O" }, { "X", "O", "X" }, { "X", "X", "X" } };
                yield return new string[3, 3] { { "X", "X", "O" }, { "X", "O", "O" }, { "X", "X", "X" } };
            }
        }

        [Test, TestCaseSource(nameof(GetTestArraysForTieChecking))]
        public void CheckingWinnerRightDiagonalReturnFalse(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingRightDiagonal(testArray);
            Assert.False(result);
        }

        [Test, TestCaseSource(nameof(GetTestArraysForTieChecking))]
        public void CheckingLeftDiagonalReturnFalse(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingLeftDiagonal(testArray);
            Assert.False(result);
        }

        [Test, TestCaseSource(nameof(GetTestArraysForTieChecking))]
        public void CheckingWinnerVerticalReturnFalse(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingWinnerVertical(testArray);
            Assert.False(result);
        }

        [Test, TestCaseSource(nameof(GetTestArraysForTieChecking))]
        public void CheckingWinnerHorizontalReturnFalse(string[,] testArray)
        {
            var ticTacToeHandler = Substitute.For<TicTacToeHandler>();
            bool result = ticTacToeHandler.CheckingWinnerHorizontal(testArray);
            Assert.False(result);
        }

        public static IEnumerable<string[,]> GetTestArraysForTieChecking
        {
            get
            {
                yield return new string[3, 3] { { "O", "X", "O" }, { "O", "X", "X" }, { "X", "O", "O" } };
                yield return new string[3, 3] { { "O", "X", "O" }, { "O", "X", "X" }, { "X", "O", "O" } };
                yield return new string[3, 3] { { "X", "O", "X" }, { "X", "O", "O" }, { "O", "X", "X" } };
            }
        }
    }
}
