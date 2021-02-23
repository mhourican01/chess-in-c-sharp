using System;
using System.Collections;

namespace chess_in_c_sharp
{
    class Program
    {
        static readonly int maxPieces = 32;

        static char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        static ArrayList squares = new ArrayList();
        static Player p1 = new Player(Colour.White, null);
        static Player p2 = new Player(Colour.Black, null);
        static Piece piece;

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
                    if (letters[lCount] == 'a' && (nCount == 1 || nCount == 8))
                    {
                        piece = new Piece(Type.Rook);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'a' && (nCount == 2 || nCount == 7))
                    {
                        piece = new Piece(Type.Knight);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'a' && (nCount == 3 || nCount == 6))
                    {
                        piece = new Piece(Type.Bishop);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'a' && (nCount == 4))
                    {
                        piece = new Piece(Type.King);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'a' && (nCount == 5))
                    {
                        piece = new Piece(Type.Queen);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'b')
                    {
                        piece = new Piece(Type.Pawn);
                        p1.Pieces.Add(piece);
                    } else if (letters[lCount] == 'g')
                    {
                        piece = new Piece(Type.Pawn);
                        p2.Pieces.Add(piece);
                    } else if (letters[lCount] == 'h' && (nCount == 1 || nCount == 8))
                    {
                        piece = new Piece(Type.Rook);
                        p2.Pieces.Add(piece);
                    }
                    else if (letters[lCount] == 'h' && (nCount == 2 || nCount == 7))
                    {
                        piece = new Piece(Type.Knight);
                        p2.Pieces.Add(piece);
                    }
                    else if (letters[lCount] == 'h' && (nCount == 3 || nCount == 6))
                    {
                        piece = new Piece(Type.Bishop);
                        p2.Pieces.Add(piece);
                    }
                    else if (letters[lCount] == 'h' && (nCount == 4))
                    {
                        piece = new Piece(Type.King);
                        p2.Pieces.Add(piece);
                    }
                    else if (letters[lCount] == 'h' && (nCount == 5))
                    {
                        piece = new Piece(Type.Queen);
                        p2.Pieces.Add(piece);
                    }

                    Square square = new Square(letters[lCount], nCount, false);
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
    }
}
