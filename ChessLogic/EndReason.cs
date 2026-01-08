using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLogic
{
    public enum EndReason
    {
        Checkmate,
        Stalemate,
        FiftyMoveRule,
        ThreefoldRepetition,
        InsufficientMaterial
    }
}
