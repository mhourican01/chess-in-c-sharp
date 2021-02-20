using System;
using System.Collections.Generic;
using System.Text;

namespace chess_in_c_sharp
{

    class Piece
    {
        public Type Type { get; set; }
        // public Square StartingSquare { get; set; }
        // public Square CurrentSquare { get; set; }
        public Piece(Type type/*, Square startingSquare, Square currentSquare*/)
        {
            Type = type;
            // StartingSquare = startingSquare;
            // CurrentSquare = currentSquare;
        }
    }
}
