using System;
using System.Collections.Generic;
using System.Text;

namespace chess_in_c_sharp
{
    class Square
    {

        public char Letter { get; set; }
        public int Number { get; set; }
        public Piece Piece { get; set; }
        public Square(char letter, int number, Piece piece)
        {
            Letter = letter;
            Number = number;
            Piece = piece;
        }
    }
}
