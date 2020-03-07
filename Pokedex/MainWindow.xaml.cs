using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
     
        //gets current index of each listview
        private void SideNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = SideNavigation.SelectedIndex;
            MoveCursorMenu(index);

        }

        //Transitions between Home, Pokedex, Create Pokemon and Mini Game section
        private void MoveCursorMenu(int index)
        {
            TransitionSlideC.OnApplyTemplate();

            switch (index)

            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new HomeUC());
                    break;

                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new PokedexUC());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new CreatePokemonUC());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new MiniGameUC());
                    break;
                default:
                    break;

            }
        }

        //closes application
        private void Button_Power(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
