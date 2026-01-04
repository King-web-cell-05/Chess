using System.Windows;
using System.Windows.Controls;
using ChessLogic;

namespace ChessUI
{
    public partial class MainWindow : Window
    {
        private readonly Image[,] pieceImages = new Image[8, 8];

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Image image = new Image();
                    pieceImages[r, c] = image;

                    Grid.SetRow(image, r);
                    Grid.SetColumn(image, c);

                    PieceGrid.Children.Add(image);
                }
            }
        }

        private void 
    }
}
