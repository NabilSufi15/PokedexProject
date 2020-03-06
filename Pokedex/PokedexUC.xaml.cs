using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for PokedexUC.xaml
    /// </summary>
    public partial class PokedexUC : UserControl
    {
        private Pokemon _selectedPokemon;
        public PokedexUC()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void ListBoxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPokemon.SelectedItem != null)
            {
                _selectedPokemon = (Pokemon)ListBoxPokemon.SelectedItem;
                PopulatePokemonFields();
            }
        }

        public void PopulateListBox()
        {
            using (var db = new PokedexContext())
            {
                ListBoxPokemon.ItemsSource = db.Pokemon.ToList();
            }
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

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (var db = new PokedexContext())
            {
                var query =
                    from pName in db.Pokemon
                    select pName;

                if (!string.IsNullOrEmpty(SearchBar.Text))
                {
                    query = query.Where(e => e.Pname.StartsWith(SearchBar.Text));
                    ListBoxPokemon.ItemsSource = query.ToList();
                }
                else
                {
                    ListBoxPokemon.ItemsSource = null;
                }

            }

        }
    }
}
