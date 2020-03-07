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
using System.Windows.Shapes;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for PokemonStats.xaml
    /// </summary>
    public partial class PokemonStats : Window
    {
        //private Stats _stats;
        public PokemonStats()
        {
            InitializeComponent();
        }

        /*
        private void ListBoxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPokemon.SelectedItem != null)
            {
                _stats = (Stats)ListBoxPokemon.SelectedItem;
                PopulateStatsFields();
            }
        }
        */
        public void PopulateStatsFields()
        {
            /*
            if (_stats != null)
            {
                HP.Text = $"_stats.Hp";
                Attack.Text = $"_stats.Attack";
                Defense.Text = $"_stats.Defense";
                Spattack.Text = $"_stats.SpAttack";
                Spdefense.Text = $"_stats.SpDefense";
                Speed.Text = $"_stats.Speed";
            }*/

        }
    }
}
