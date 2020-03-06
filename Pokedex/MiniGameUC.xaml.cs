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

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for MiniGameUC.xaml
    /// </summary>
    public partial class MiniGameUC : UserControl
    {
        MiniGameLogic game = new MiniGameLogic();
        public MiniGameUC()
        {
            InitializeComponent();
        }

        private void Button_Water(object sender, RoutedEventArgs e)
        {
            game.UserChoice = "water";
            water1.Visibility = Visibility.Visible;
            grass1.Visibility = Visibility.Hidden;
            fire1.Visibility = Visibility.Hidden;

            game.Logic();
            ShowImage();

            WinsText.Text = $"{game.Wins}";
            DrawText.Text = $"{game.Draw}";
            LossText.Text = $"{game.Loss}";
        }

        private void Button_Fire(object sender, RoutedEventArgs e)
        {
            game.UserChoice = "fire";
            water1.Visibility = Visibility.Hidden;
            grass1.Visibility = Visibility.Hidden;
            fire1.Visibility = Visibility.Visible;

            game.Logic();
            ShowImage();

            WinsText.Text = $"{game.Wins}";
            DrawText.Text = $"{game.Draw}";
            LossText.Text = $"{game.Loss}";
        }

        private void Button_Grass(object sender, RoutedEventArgs e)
        {
            game.UserChoice = "grass";
            water1.Visibility = Visibility.Hidden;
            grass1.Visibility = Visibility.Visible;
            fire1.Visibility = Visibility.Hidden;

            game.Logic();
            ShowImage();

            WinsText.Text = $"{game.Wins}";
            DrawText.Text = $"{game.Draw}";
            LossText.Text = $"{game.Loss}";
        }

        private void ShowImage()
        {
            if (game.CpuChoice == "water")
            {
                water2.Visibility = Visibility.Visible;
                grass2.Visibility = Visibility.Hidden;
                fire2.Visibility = Visibility.Hidden;
            }
            else if (game.CpuChoice == "fire")
            {
                water2.Visibility = Visibility.Hidden;
                grass2.Visibility = Visibility.Hidden;
                fire2.Visibility = Visibility.Visible;
            }
            else if (game.CpuChoice == "grass")
            {
                water2.Visibility = Visibility.Hidden;
                grass2.Visibility = Visibility.Visible;
                fire2.Visibility = Visibility.Hidden;
            }
        }

    }
}
