using System;
using System.Collections.Generic;
using System.Text;

namespace chess_in_c_sharp
{
    class Square
    {

        public char Letter { get; set; }
        public int Number { get; set; }
        public Square(char letter, int number)
        {
            Letter = letter;
            Number = number;
        }
    }
}
