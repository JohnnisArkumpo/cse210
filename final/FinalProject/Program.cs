using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        Board board = new Board();
        board.returnPieces();
        Piece thisIsAPiece = new Piece();
        board.recievePiece(thisIsAPiece.givePiece());
    }
}

/**
    FIVE CLASSES
    Pattern - Abstract or interface
    Piece
    Player
    Board
    Effect - Abstract or interface
**/