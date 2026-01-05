using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Color { get; }
        public bool HasMoved { get; set; } = false;
        public abstract Piece Copy();

        public abstract IEnumerable<Move> GetMoves(Position from, Board board);

        public IEnumerable<Position>MovePositionsInDir(Position from, Board board, Direction dir)
        { 
            for(Position pos = from + dir; Board.IsInside(pos); pos += dir)
            {
                if (board.IsEmpty(pos))
                {
                    yield return pos;
                }
                Piece piece = board[pos];

                if (piece.Color != this.Color)
                {
                    yield return pos;
                }

                yield break;
            }
        }
    }
}
