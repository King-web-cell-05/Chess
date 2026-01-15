using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public class Counting
    {
        private readonly Dictionary<PieceType, int> whiteCount = new();
        private readonly Dictionary<PieceType, int> blackCount = new();

        public int TotalCount { get; private set;  }

        public Counting()
        {
            foreach(PieceType type in Enum.GetValues (typeof(PieceType)))
            {
                whiteCount[type] = 0;
                blackCount[type] = 0;
            }
        }

    }
}
