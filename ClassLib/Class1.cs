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

    public void startingEleven()
    {
        //Bauern
        for(int x = 0; x < 8; x++)
        {
            _board[x,1] = new Pawn(true);
        }
        for(int x = 0;x < 8;x++)
        {
            _board[x,6] = new Pawn(false);
        }
        //Türme
        _board[0,0] = new Rook(true);
        _board[7,0] = new Rook(true);
        _board[0,7] = new Rook(false);
        _board[7,7] = new Rook(false);
        //Pferde
        _board[1,0] = new Knight(true);
        _board[6,0] = new Knight(true);
        _board[1,7] = new Knight(false);
        _board[6,7] = new Knight(false);
        //Zylinder Ding
        _board[2,0] = new Bishop(true);
        _board[5,0] = new Bishop(true);
        _board[2,7] = new Bishop(false);
        _board[5,7] = new Bishop(false);
        //Dame
        _board[3,0] = new Queen(true);
        _board[3,7] = new Queen(false);
        //König
        _board[4,0] = new King(true);
        _board[4,7] = new King(false);

    }
}


