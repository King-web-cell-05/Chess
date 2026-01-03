using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic.Pieces
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; }

        public Bishop(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
