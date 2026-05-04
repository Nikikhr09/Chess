namespace test;

using System.Reflection.Metadata;
using ClassLib;
using Microsoft.VisualBasic;
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
    //Türme
    [Fact]
    public void WhiteRookShouldHaveRightColorAndRightPosition()
    {
        var board = new Chessboard();
        board.startingEleven();

        var figure = board.GetFigure(0,0);
        Assert.IsType<Rook>(figure);
        Assert.True(figure.IsWhite);
    }
    [Fact]
    public void BlackRookShouldHaveRightColorAndRightPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(7,7);
        Assert.IsType<Rook>(figure);
        Assert.False(figure.IsWhite);
    }
    //Bauern Test
    [Fact]
    public void WhitePawnShouldHaveRightColourAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(1,1);
        Assert.IsType<Pawn>(figure);
        Assert.True(figure.IsWhite);
    }
    [Fact]
    public void BlackPawnShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(5,6);
        Assert.IsType<Pawn>(figure);
        Assert.False(figure.IsWhite);
    }
    //Pferde
    [Fact]
    public void WhiteKnightShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(1,0);
        Assert.IsType<Knight>(figure);
        Assert.True(figure.IsWhite);
    }
    [Fact]
    public void BlackKnightShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(6,7);
        Assert.IsType<Knight>(figure);
        Assert.False(figure.IsWhite);
    }
    //Zylinder/Bischoff
    [Fact]
    public void WhiteBishopShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(2,0);
        Assert.IsType<Bishop>(figure);
        Assert.True(figure.IsWhite);
    }
    [Fact]
    public void BlackBishopShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(2,7);
        Assert.IsType<Bishop>(figure);
        Assert.False(figure.IsWhite);
    }
    //Königin
    [Fact]
    public void WhiteQueenShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(3,0);
        Assert.IsType<Queen>(figure);
        Assert.True(figure.IsWhite);
    }
    //König
    [Fact]
    public void BlackKingShouldHaveRightColorAndPosition()
    {
        var board = new Chessboard();
        board.startingEleven();
        var figure = board.GetFigure(4,7);
        Assert.IsType<King>(figure);
        Assert.False(figure.IsWhite);
    }
    [Fact]
    public void BoardMustNotBeLeft(){
    var board = new Chessboard();
    var result = board.movingFigure(7,8,8,8);
    Assert.False(result);
   
    }
    [Fact]

public void MoveFigure_WithFigure_ShouldReturnTrue()
{
    var board = new Chessboard();
    var pawn = new Pawn(true);

    board.SetFigure(0,1, pawn);

    var result = board.movingFigure(0,1,0,3);

    Assert.True(result);
}
}

    
    
