using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; private set; }

        public Result Result { get; private set; } = null;
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }

        public IEnumerable<Move> LegalMovesForPiece(Position pos)
        {
            if (Board.IsEmpty(pos) || Board[pos].Color != CurrentPlayer)
            {
                return Enumerable.Empty<Move>();
            }

            Piece piece = Board[pos];
            IEnumerable<Move> moveCandidates = piece.GetMoves(pos, Board);
            return moveCandidates.Where(move => move.IsLegal(Board));
        }

        public void MakeMove(Move move)
        {
            move.Execute(Board);
            CurrentPlayer = CurrentPlayer.Opponent();
        }

        public IEnumerable<Move> AllLegalMovesFor(Player player)
        {
            return Board.PiecePositions(player)
                .SelectMany(pos =>
                {
                    Piece piece = Board[pos];
                   return piece.GetMoves(pos, Board)
                });

                 return moveCandidates.Where(move => move.IsLegal(Board));

        }
    }
}