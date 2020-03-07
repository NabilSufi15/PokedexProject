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
    /// Interaction logic for CreatePokemonUC.xaml
    /// </summary>
    public partial class CreatePokemonUC : UserControl
    {
        public CreatePokemonUC()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Pokecreate.Visibility = Visibility.Visible;

            using (var db = new PokedexContext())
            {
                Pokemon newPokemon = new Pokemon()
                {
                    Pimage = TextImage.Text,
                    Pname = TextName.Text,
                    Ptype = TextType.Text,
                    Pdescription = TextDescription.Text,
                    Pheight = TextHeight.Text,
                    Pweight = TextWeight.Text
                };

                Stats newStats = new Stats()
                {
                    Hp = TextHP.Text,
                    Attack = TextAttack.Text,
                    Defense = TextType.Text,
                    SpAttack = TextDescription.Text,
                    SpDefense = TextHeight.Text,
                    Speed = TextWeight.Text
                };

                //add to database
                db.Add(newPokemon);
                //add to database
                db.Add(newStats);
                // write changes to database
                db.SaveChanges();
            }
            
        }
    }
}
