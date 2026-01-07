using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Linq;




namespace ChessUI
{
     public static class ChessCursors
    {
        public static readonly Cursor WhiteCursor = LoadCursor("Assets/Cursor.W.cur");
        public static readonly Cursor BlackCursor = LoadCursor("Assets/Cursor.B.cur");
        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
