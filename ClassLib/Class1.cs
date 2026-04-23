namespace ClassLib;

public class Chessboard
{

    private Figure[,] _board = new Figure[8,8];

    public Figure GetFigure(int x, int y)
    {
        return _board[x,y];
    }
    public void SetFigure(int x, int y, Figure figure)
    {
        _board[x,y] = figure;
    }
}


