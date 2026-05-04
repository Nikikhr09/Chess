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
    public override string ToString()
    {
       if(IsWhite){return "P";}
       else{return "p";}
    }
}

public class Rook : Figure
{
   public Rook(bool isWhite) : base(isWhite)
   {
   }
    public override string ToString()
    {
       if(IsWhite){return "R";}
       else{return "r";}
    }
}
public class Knight : Figure
{
   public Knight(bool isWhite) : base(isWhite)
   {
   }
    public override string ToString()
    {
       if(IsWhite){return "N";}
       else{return "n";}
    }
}
public class Bishop : Figure
{
   public Bishop(bool isWhite) : base(isWhite)
   {
   }
    public override string ToString()
    {
        if(IsWhite){return "B";}
        else{return "b";}
    }
}
public class Queen : Figure
{
   public Queen(bool isWhite) : base(isWhite)
   {
   }
    public override string ToString()
    {
        if(IsWhite){return "Q";}
        else{return "q";}
    }
}
public class King : Figure
{
   public King(bool isWhite) : base(isWhite)
   {
   }
    public override string ToString()
    {
        if(IsWhite){return "K";}
        else{return "k";}
    }
}
