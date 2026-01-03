using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; private set; }

        public GameState(Player, player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }
    }
}
