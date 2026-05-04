using ClassLib;
namespace Programm
{
    public class Programm
    {
        public static int Main()
        {
            var board = new Chessboard();
            board.startingEleven();
            Console.WriteLine(board);
            return 0;
        }
    }
}