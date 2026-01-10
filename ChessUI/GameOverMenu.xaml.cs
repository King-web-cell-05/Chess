using ChessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for GameOverMenu.xaml
    /// </summary>
    public partial class GameOverMenu : UserControl
    {
        public event Action<Option> OptionSelected;
        public GameOverMenu()
        {
            InitializeComponent();
        }

        private static string GetWinnerText(Player winner)
        {
            return winner switch
            {
                Player.White => "WHITE WINS!",
                Player.Black => "BLACK WINS!",
                _ => "IT'S A DRAW!"


            };
        }

        private static string PlayerString(Player player)
        {
            return player switch
            {
                Player.White => "WHITE WINS!",
                Player.Black => "BLACK WINS!",
                _ => ""
            };
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Restart);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Exit);

        }
    }
}
