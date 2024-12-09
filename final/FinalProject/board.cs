using System;

public class Board {
    List<string> pieces = new List<string>();
    public string returnPieces() {
        Console.WriteLine("here are all the pieces");
        return "pieces";
    }
    public void recievePiece(string pnew) {
        pieces.Add(pnew);
        Console.WriteLine("added piece x");
    }
}