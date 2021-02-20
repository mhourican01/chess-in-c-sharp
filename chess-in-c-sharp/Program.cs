using System;
using System.Collections;

namespace chess_in_c_sharp
{
    class Program
    {
        static readonly int maxPieces = 32;

        static char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        static ArrayList squares = new ArrayList();

        static void Main(string[] args)
        {
            CreateBoard();
        }

        static void CreateBoard()
        { 
            for (int lCount = 0; lCount < letters.Length; lCount++)
            {
                for (int nCount = 1; nCount <= letters.Length; nCount++)
                {
                    Square square = new Square(letters[lCount], nCount);
                    squares.Add(square);
                }
            }
            DisplayBoard();
        }

        static void DisplayBoard()
        {
            foreach (Square s in squares)
            {
                Console.Write("[" + s.Letter + s.Number + "]");
                if (s.Number == 8)
                {
                    Console.WriteLine();
                }
            }
        }

        static void CreatePlayers()
        {
            Player p1 = new Player(Colour.White, null);
            Player p2 = new Player(Colour.Black, null);
        }

        static void CreatePieces()
        {
            int pieceCount = 1;
            while (pieceCount <= maxPieces) { 
                if (pieceCount <= 8)
                {
                    // Piece piece = new Piece(Type.Pawn, squares.);
                }
            }
        }
    }
}
