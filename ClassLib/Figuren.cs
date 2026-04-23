using ClassLib;

public class Figure
{
 public bool IsWhite{ get;}
 protected Figure(bool isWhite)
 {
    IsWhite = isWhite;
 }   
}
public class Pawn : Figure 
{
   public Pawn(bool isWhite) : base(isWhite)
    {
    }
}

public class Rook : Figure
{
   public Rook(bool isWhite) : base(isWhite)
   {
   }
}
public class Knight : Figure
{
   public Knight(bool isWhite) : base(isWhite)
   {
   }
}
public class Bishop : Figure
{
   public Bishop(bool isWhite) : base(isWhite)
   {
   }
public class Queen : Figure
{
   public Queen(bool isWhite) : base(isWhite)
   {
   }
}
public class King : Figure
{
   public King(bool isWhite) : base(isWhite)
   {
   }
}
}