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
        private Pokemon _selectedPokemon;

        Program pd = new Program();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        public void PopulatePokemonFields()
        {

            if (_selectedPokemon != null)
            {
                TextId.Text = $"{_selectedPokemon.PokemonId}";
                
                pkImage.Source = new BitmapImage(new Uri($"{_selectedPokemon.Pimage}"));
                TextName.Text = _selectedPokemon.Pname;
                TextType.Text = _selectedPokemon.Ptype;
                TextDescription.Text = _selectedPokemon.Pdescription;
                TextHeight.Text = _selectedPokemon.Pheight;
                TextWeight.Text = _selectedPokemon.Pweight;
            }
        }

        public void PopulateListBox()
        {
            using (var db = new PokedexContext())
            {
                ListBoxPokemon.ItemsSource = db.Pokemon.ToList();
            }
        }

        private void ListBoxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPokemon.SelectedItem != null)
            {
                _selectedPokemon = (Pokemon)ListBoxPokemon.SelectedItem;
                PopulatePokemonFields();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Create p = new Create();
            p.Show();
        }
    }
}
