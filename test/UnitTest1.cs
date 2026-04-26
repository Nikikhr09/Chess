namespace test;
using ClassLib;
using Xunit;
public class Figures
{
    [Fact]
    public void SetAndGetFigure()
    {
        var board = new Chessboard();
        var pawn = new Pawn(true);

        board.SetFigure(0, 1, pawn);
        var result = board.GetFigure(0,1);

        Assert.Equal(pawn, result);
    }
    [Fact]
    public void EmptyField_ShouldReturnNull()
    {
        var board = new Chessboard();

        var result = board.GetFigure(3,3);

        Assert.Null(result);
    }
    [Fact]

    public void FigureCorrectColor()
    {
        var pawn = new Pawn(true);
        Assert.True(pawn.IsWhite);
    }
    [Fact]
    public void FiguresShouldBeStoredCorrectly()
    {
        var board = new Chessboard();

        var rook = new Rook(true);
        var knight = new Knight(false);

        board.SetFigure(1, 1, rook);
        board.SetFigure(2,2,knight);

        Assert.Equal(rook, board.GetFigure(1,1));
        Assert.Equal(knight, board.GetFigure(2,2));
    }
}
