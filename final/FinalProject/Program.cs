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
    Figure out inheritance functions
    finish out stunting functions and creating their interactions in program
**/