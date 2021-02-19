using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace chess_in_c_sharp
{
    class Player
    {
        public Colour Colour { get; set; }
        public ArrayList Pieces { get; set; }
        public Player(Colour colour, ArrayList pieces)
        {
            Colour = colour;
            Pieces = pieces;
        }
    }
}
