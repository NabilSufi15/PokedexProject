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
        private Stats _stats;
        private MediaPlayer _cry = new MediaPlayer();
        private MediaPlayer _speech = new MediaPlayer();
        public PokedexUC()
        {
            InitializeComponent();
            PopulateListBox();
        }


        //Displays pokemon information when selected from the list
        private void ListBoxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPokemon.SelectedItem != null)
            {
                _selectedPokemon = (Pokemon)ListBoxPokemon.SelectedItem;
                PopulatePokemonFields();
            }
        }

        //Populates the listbox from the database table pokemon
        public void PopulateListBox()
        {
            
            using (var db = new PokedexContext())
            {
                ListBoxPokemon.ItemsSource = db.Pokemon.ToList();
            }
        }

        //Populates pokemon information
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
                _cry.Open(new Uri(@$"{_selectedPokemon.Pcry}", UriKind.RelativeOrAbsolute));
                _speech.Open(new Uri(@$"{_selectedPokemon.Psound}", UriKind.RelativeOrAbsolute));

            }
        }

        public void PopulateStatsFields()
        {
            /*
            if (_stats != null)
            {
                HP.Text = $"{_stats.Hp}";
                HP.Text = "aha";
                Attack.Text = $"_stats.Attack";
                Defense.Text = $"_stats.Defense";
                Spattack.Text = $"_stats.SpAttack";
                Spdefense.Text = $"_stats.SpDefense";
                Speed.Text = $"_stats.Speed";
            }
            else
            {
                HP.Text = "n/a";
            }
            */
            
            
        }

        // search pokemon name comparing the search bar text to pname column of pokemon table
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

        //opens PokemonStats window
        private void Button_Stats(object sender, RoutedEventArgs e)
        {
            PokemonStats ps = new PokemonStats();
            ps.Show();
        }

        //Plays the pokemon cry sound
        private void Button_Cry(object sender, RoutedEventArgs e)
        {
            _cry.Play();
        }

        //Plays the the voice description of pokemon
        private void Button_Speech(object sender, RoutedEventArgs e)
        {
            _speech.Play();
        }
    }
}
